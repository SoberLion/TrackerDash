using System;
using System.Collections.Generic;
using TrackerHelper.DB;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper
{
    public class Vacation
    {
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
    }

    public abstract class Role
    {
    }

    public class Person
    {
        public delegate void Message(string message);

        public event Message onError;
        public event Message onMessage;


        private string _id = string.Empty;
        private string _firstName = string.Empty;
        private string _secondName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty; 
        //private Role _Role;
        private string _companyName = string.Empty;
        private string _city = string.Empty;
        private string _officeNo = string.Empty;        
        private string _phoneNo = string.Empty;
        private string _internalPhoneNo = string.Empty;
        private string _department = string.Empty;
        private string _position = string.Empty;
        private int _rk7Assessment = 0;
        private List<Vacation> _Vacations = new List<Vacation>();
        private string _language = string.Empty;
        private string _baseAddress = @"http://tracker.ucs.ru/";
        private Issues _issues = new Issues();
        private Issues _issuesUpdated = new Issues();
        private string _apiKey = string.Empty;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Firstname
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string Secondname
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        public string Lastname
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }
        /*public Role Role
        {
            get { return _Role; }
            set { _Role = value; }
        }*/
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string OfficeNo
        {
            get { return _officeNo; }
            set { _officeNo = value; }
        }
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        public string InternalPhoneNo
        {
            get { return _internalPhoneNo; }
            set { _internalPhoneNo = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public int RK7Assessment
        {
            get { return _rk7Assessment; }
            set { _rk7Assessment = value; }
        }

        public List<Vacation> Vacations
        {
            get { return _Vacations; }
            set { _Vacations = value; }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public string BaseAddress
        {
            get { return _baseAddress; }
            set
            {
                onMessage?.Invoke("BaseAddress = " + value);
                _baseAddress = value;
            }
        }
        public Issues Issues
        {
            get { return _issues; }
            set { _issues = value; }
        }
        public Issues IssuesUpdated
        {
            get { return _issuesUpdated; }
            set { _issuesUpdated = value; }
        }
        public string ApiKey
        {
            get { return _apiKey; }
            set
            {
                onMessage?.Invoke("ApiKey = " + value);
                _apiKey = value;
            }
        }

        public void FetchOpenedIssues(int Retries)
        {
            string filter = @"set_filter=1&f[]=assigned_to_id&op[assigned_to_id]=%3D&v[assigned_to_id][]=me&f[]=status_id&op[status_id]=o";
            FetchIssuesFiltered(Retries, filter);
        }

        public void FetchUpdatedIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            // string filter = $@"set_filter=1&f[]=assigned_to_id&op[assigned_to_id]=%3D&v[assigned_to_id][]=me&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";
            string filter = $@"set_filter=1&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";
            FetchIssuesFiltered(Retries, filter);
        }

        public void FetchAllIssues(int Retries)
        {
            string filter = @"set_filter=1&f[]=&c[]=project&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=";

            FetchIssuesFiltered(Retries, filter);
        }

        public void GetOpenedIssuesFromDb() => DBman.GetIssuesListByUserId(Id, Issues);

        public void FetchIssuesFiltered(int Retries, string filter)
        {
            ResultModel resultModel = new ResultModel();
            int retries = 0;
            do
            {
                string url = $@"{BaseAddress}issues.xml?utf8=%E2%9C%93&limit={IssuesUpdated.limit}&offset={IssuesUpdated.offset}&key={ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (IssuesUpdated.issue.Count > 0)
                    {
                        XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => IssuesUpdated.issue.Add(p));
                        retries = 0;
                    }
                    else
                    {
                        IssuesUpdated = XML.Deserialize<Issues>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    IssuesUpdated.IncOffset();
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами
                    retries++;
                    if (retries == Retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {IssuesUpdated.issue.Count} issues");
                        break;
                    }
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (IssuesUpdated.offset < IssuesUpdated.total_count);
        }

        public void Update()
        {

        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper.DB
{
    public class EventProgressArgs
    {
        private int _Percents = 0;
        private string _Message = string.Empty;


        public int Percents
        {
            get { return _Percents; }
            set { _Percents = value; }
        }
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }

    public class DBController
    {
        public delegate void Message(string message);
        public delegate void Progress(EventProgressArgs e);
        public static event Message onError;
        public static event Progress onProgressChange;


        private static Person _person = new Person();

        private Time_entries _timeEntries = new Time_entries();

        private Issues _dbIssues = new Issues();
        private Issues _rmIssues = new Issues();
        private Issues _updatedIssues = new Issues();

        private Users _rmUsers = new Users();
        private List<Person> _personList = new List<Person>();

        public DBController(Person person)
        {
            _person = person;
        }

        public void UpdateTimeEntries(int retries, int numOfDays)
        {
            GetRmTimeEntries(retries, numOfDays);
            DBman.InsertTE(_timeEntries);
        }

        public void UpdateIssues(int Retries, int NumofDaysSinceLastUpdate)
        {      
            GetRmIssues(Retries, NumofDaysSinceLastUpdate);
            DBman.GetOpenedIssues(_dbIssues, NumofDaysSinceLastUpdate+1);

            _person.Issues.issue = _rmIssues.issue.Except(_dbIssues.issue, new IssueComparer()).ToList();

            GetJournals();
            DBman.InsertIssues(_person.IssuesUpdated);
        }

        public void UpdateUsers(int Retries)
        {
            GetRmUsers(Retries);
            UsersToPersons(_rmUsers);
            DBman.InsertPersons(_personList);
            //DBman.InsertIssues(_person.IssuesUpdated);
        }

        private void GetRmUsers(int retries)
        {
            ResultModel resultModel = new ResultModel();
            int _retries = 0;
            do
            {
                string url = $@"{_person.BaseAddress}users.xml?&offset={_rmUsers.offset}&limit=100&key={_person.ApiKey}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_rmUsers.users.Count > 0)
                    {
                        XML.Deserialize<Users>(resultModel.Results).users.ForEach(p => _rmUsers.users.Add(p));
                        _retries = 0;
                    }
                    else
                    {
                        _rmUsers = XML.Deserialize<Users>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _rmUsers.IncOffset();
                    if (_rmUsers.total_count != 0)
                    {
                        onProgressChange?.Invoke(new EventProgressArgs
                        {
                            Percents = _rmUsers.offset * 100 / _rmUsers.total_count,
                            Message = _rmUsers.offset < _rmUsers.total_count ?
                                      $@"Обновляются профили пользователей: {_rmUsers.offset}/{_rmUsers.total_count}" :
                                      $@"{_rmUsers.total_count}/{_rmUsers.total_count}"
                        });
                    }
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами
                    _retries++;
                    if (_retries == retries)
                    {
                        onError?.Invoke($"No reply from host. Fetch|ed {_rmUsers.users.Count} users");
                        break;
                    }
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (_rmUsers.offset < _rmUsers.total_count);
        }

        private void GetRmTimeEntries(int retries, int numofDays)
        {
            ResultModel resultModel = new ResultModel();
            string filter = $"from={DateTime.Now.AddDays(-numofDays).ToString("yyyy-MM-dd")}&to={DateTime.Now.ToString("yyyy-MM-dd")}";
            int _retries = 0;
            do
            {
                string url = $@"{_person.BaseAddress}time_entries.xml?&offset={_timeEntries.offset}&limit=100&key={_person.ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_timeEntries.time_entry_list.Count > 0)
                    {
                        XML.Deserialize<Time_entries>(resultModel.Results).time_entry_list.ForEach(p => _timeEntries.time_entry_list.Add(p));
                        _retries = 0;
                    }
                    else
                    {
                        _timeEntries = XML.Deserialize<Time_entries>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _timeEntries.IncOffset();
                    if (_timeEntries.total_count > 0)
                    {
                        onProgressChange?.Invoke(new EventProgressArgs
                        {
                            Percents = _timeEntries.offset * 100 / _timeEntries.total_count,
                            Message = _timeEntries.offset < _timeEntries.total_count ?
                                      $@"Получение трудозатрат: {_timeEntries.offset}/{_timeEntries.total_count}" :
                                      $@"Получение трудозатрат: {_timeEntries.total_count}/{_timeEntries.total_count}"
                        });
                    }
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами
                    _retries++;
                    if (_retries == retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {_timeEntries.time_entry_list.Count} time entries");
                        break;
                    }
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (_timeEntries.offset < _timeEntries.total_count);
        }

        private void GetRmIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            string filter = $@"set_filter=1&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";

            ResultModel resultModel = new ResultModel();
            int retries = 0;
            do
            {
                string url = $@"{_person.BaseAddress}issues.xml?utf8=%E2%9C%93&limit={_rmIssues.limit}&offset={_rmIssues.offset}&key={_person.ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_rmIssues.issue.Count > 0)
                    {
                        XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => _rmIssues.issue.Add(p));
                        retries = 0;
                    }
                    else
                    {
                        _rmIssues = XML.Deserialize<Issues>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _rmIssues.IncOffset();
                    if (_rmIssues.total_count > 0)
                    {
                        onProgressChange?.Invoke(new EventProgressArgs
                        {
                            Percents = _rmIssues.offset * 100 / _rmIssues.total_count,
                            Message = _rmIssues.offset < _rmIssues.total_count ?
                                      $@"Получение списка задач: {_rmIssues.offset}/{_rmIssues.total_count}" :
                                      $@"Получение списка задач: {_rmIssues.total_count}/{_rmIssues.total_count}"
                        });
                    }
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами                    
                    if (retries == Retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {_rmIssues.issue.Count.ToString()} issues");
                        break;
                    }
                    retries++;
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, сделать повторные запросы со смещением
            while (_rmIssues.offset < _rmIssues.total_count);
        }

        private void GetJournals()
        {
            for (int i = 0; i < _person.Issues.issue.Count; i++)
            {
                string url = $@"{_person.BaseAddress}issues/{_person.Issues.issue[i].id}.xml?include=journals&key={_person.ApiKey}";
                Issue issue = new Issue();
                issue = Issue.GetIssue(url);
                if (issue != null)
                    _person.IssuesUpdated.issue.Add(issue);
                if (_person.Issues.issue.Count > 0)
                {
                    onProgressChange?.Invoke(new EventProgressArgs
                    {
                        Percents = i * 100 / _person.Issues.issue.Count,
                        Message = $@"Обновление задачи: {i + 1}/{_person.Issues.issue.Count}"
                    });
                }
            }
        }
        private void UsersToPersons(Users users)
        {
            for (int i = 0; i < users.users.Count; i++)
            {
                _personList.Add(new Person
                {
                    Id = users.users[i].id.ToString(),
                    Firstname = users.users[i].firstname,
                    Lastname = users.users[i].lastname,
                    EMail = users.users[i].mail,
                    CompanyName = users.users[i].custom_fields.Find(p => p.id == 17).value.Select(p => p.value).FirstOrDefault(),
                    City = users.users[i].custom_fields.Find(p => p.id == 18).value.Select(p => p.value).FirstOrDefault(),
                    OfficeNo = users.users[i].custom_fields.Find(p => p.id == 29).value.Select(p => p.value).FirstOrDefault(),
                    InternalPhoneNo = users.users[i].custom_fields.Find(p => p.id == 28).value.Select(p => p.value).FirstOrDefault(),
                    Department = users.users[i].custom_fields.Find(p => p.id == 33).value.Select(p => p.value).FirstOrDefault(),
                    Position = users.users[i].custom_fields.Find(p => p.id == 30).value.Select(p => p.value).FirstOrDefault(),
                    PhoneNo = users.users[i].custom_fields.Find(p => p.id == 58).value.Select(p => p.value).FirstOrDefault(),
                    RK7Assessment = Convert.ToInt32(users.users[i].custom_fields.Find(p => p.id == 61).value.Select(p => p.value).FirstOrDefault()),
                });
            }          
        }
    }
}

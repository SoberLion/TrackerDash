using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    [XmlRoot("issue")]
    public class Issue
    {
        private IdName projectField = new IdName();
        private IdName trackerField = new IdName();
        private IdName statusField = new IdName();
        private IdName priorityField = new IdName();
        private IdName authorField = new IdName();
        private IdName assigned_toField = new IdName();
        private IdName categoryField = new IdName();

        private string idField = string.Empty;
        private string subjectField = string.Empty;
        private string descriptionField = string.Empty;
        private string startDateField = string.Empty;
        private string dueDateField = string.Empty;
        private string doneRatioField = string.Empty;
        private bool isPrivateField = false;
        private string estimatedHoursField = string.Empty;
        private List<custom_field> custom_fieldsField = new List<custom_field>();
        private string createdOnField = string.Empty;
        private string updatedOnField = string.Empty;
        private string closedOnField = string.Empty;

        private List<IssueJournalItem> IssueJournalList = new List<IssueJournalItem>();

        [XmlElement]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }
        [XmlElement]
        public IdName project
        {
            get { return projectField; }
            set { projectField = value; }
        }
        [XmlElement]
        public IdName tracker
        {
            get { return trackerField; }
            set { trackerField = value; }
        }
        [XmlElement]
        public IdName status
        {
            get { return statusField; }
            set { statusField = value; }
        }
        [XmlElement]
        public IdName priority
        {
            get { return priorityField; }
            set { priorityField = value; }
        }
        [XmlElement]
        public IdName author
        {
            get { return authorField; }
            set { authorField = value; }
        }

        [XmlElement]
        public IdName assigned_to
        {
            get { return assigned_toField; }
            set { assigned_toField = value; }
        }
        [XmlElement]
        public IdName category
        {
            get { return categoryField; }
            set { categoryField = value; }
        }

        [XmlElement]
        public string subject
        {
            get { return subjectField; }
            set { subjectField = value; }
        }
        [XmlElement]
        public string description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }
        [XmlElement("start_date")]
        public string startDate
        {
            get { return startDateField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    startDateField = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    startDateField = string.Empty;
            }
        }

        [XmlElement("due_date")]
        public string dueDate
        {
            get { return dueDateField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    dueDateField = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    dueDateField = string.Empty;
            }
        }

        [XmlElement("done_ratio")]
        public string doneRatio
        {
            get { return doneRatioField; }
            set { doneRatioField = value; }
        }

        [XmlElement("is_private")]
        public bool IsPrivate
        {
            get { return isPrivateField; }
            set { isPrivateField = value; }
        }

        [XmlElement("estimated_hours")]
        public string estimatedHours
        {
            get { return estimatedHoursField; }
            set { estimatedHoursField = value; }
        }

        [XmlArray("custom_fields")]
        [XmlArrayItem("custom_field")]
        public List<custom_field> custom_fields
        {
            get { return custom_fieldsField; }
            set { custom_fieldsField = value; }
        }

        [XmlElement("created_on")]
        public string createdOn
        {
            get { return createdOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    createdOnField = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    createdOnField = string.Empty;
            }
        }

        [XmlElement("updated_on")]
        public string updatedOn
        {
            get { return updatedOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    updatedOnField = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    updatedOnField = string.Empty;
            }
        }

        [XmlElement("closed_on")]
        public string closedOn
        {
            get { return closedOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    closedOnField = dt.ToString("yyyy-MM-dd HH:mm:ss.000");
                }
                else
                    closedOnField = string.Empty;
            }

        }

        [XmlArray("journals"), XmlArrayItem(ElementName = "journal", Type = typeof(IssueJournalItem))]
        public List<IssueJournalItem> JournalList
        {
            get { return IssueJournalList; }
            set { IssueJournalList = value; }
        }



        public static Issue GetIssue(string url)
        {
            Issue issue = null;
            ResultModel model = new ResultModel();

            model = Http.Get(url);
            if (model.IsSuccess)
            {
                issue = XML.Deserialize<Issue>(model.Results);
            }
            return issue = issue ?? null;
        }
    }
    public class IssueComparer : IEqualityComparer<Issue>
    {
        public bool Equals(Issue x, Issue y)
        {
            return x.id.Equals(y.id) && x.updatedOn.Equals(y.updatedOn) && (x.JournalList.Count == y.JournalList.Count);
        }

        public int GetHashCode(Issue obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;

            return obj.updatedOn.GetHashCode();
        }
    }
}

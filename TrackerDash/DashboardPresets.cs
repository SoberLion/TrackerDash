using System;
using System.Collections.Generic;
using TrackerHelper.RedmineEntities;
using System.ComponentModel;

namespace TrackerHelper
{
    public class Status : INotifyPropertyChanged, IComparer<Status>, IComparable<Status>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private string _name;
        private int _maxHours = 0;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxHours
        {
            get { return _maxHours; }
            set
            {
                if (value != this.MaxHours)
                {
                    _maxHours = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaxHours"));
                }
            }
        }

        public int Compare(Status x, Status y)
        {
            int i = 0;
            if (x.ID > y.ID)
                i = 1;
            else if (x.ID < y.ID)
                i = -1;

            return i;
        }

        public int CompareTo(Status other)
        {
          return Compare(this, other);
        }
    }
    public class StatusComparer : IEqualityComparer<Status>
    {
        

        public bool Equals(Status x, Status y)
        {
            return x.ID.Equals(y.ID);
        }

        public int GetHashCode(Status obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;

            return obj.ID.GetHashCode();
        }
    }

    public class DashboardPreset
    {
        private static int _counter = 0;

        private int _id = 0;
        private string _name = string.Empty;
        private List<IdName> _employees = new List<IdName>();
        private List<IdName> _projects = new List<IdName>();
        private List<Status> _statuses = new List<Status>();
        private bool _isActive = false;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<IdName> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }
        public List<IdName> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
        public List<Status> Statuses
        {
            get { return _statuses; }
            set { _statuses = value; }
        }
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public DashboardPreset()
        {
            _counter++;
            ID = _counter;
        }
        
        public static void SetCounter(int counter) => _counter = counter;

    }
}

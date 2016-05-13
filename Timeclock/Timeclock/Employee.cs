using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFX.Timeclock
{
    public class Employee
    {
        private string _loginCode;
        private List<TimePeriod> _periods = new List<TimePeriod>();

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string LoginCode { get { return _loginCode; } }
        public List<TimePeriod> Periods { get { return _periods; } }

        public Employee()
        {
        }

        public Employee(string id, string first, string last, string login)
        {
            this.ID = id;
            this.FirstName = first;
            this.LastName = last;
            _loginCode = login;
        }
        
        public bool Verify(string code)
        {
            if (_loginCode == code) return true;
            return false;
        }

        public void AddTimePeriod(TimePeriod tp)
        {
            _periods.Add(tp);
        }

        public void AddTimePeriods(List<TimePeriod> tps)
        {
            foreach (TimePeriod tp in tps)
            {
                this.AddTimePeriod(tp);
            }
        }

        public void CreateNewTimePeriod()
        {
            DateTime tempTime = DateTime.Now;  //Makes sure time is exactly equal.
            TimePeriod newtp = new TimePeriod() { TimeIn = tempTime, TimeOut = tempTime };
            AddTimePeriod(newtp);
        }

        public void UpdateInTime()
        {
            UpdateInTime(_periods.Count-1);
        }

        public void UpdateInTime(int which)
        {
            UpdateInTime(which, DateTime.Now);
        }

        public void UpdateInTime(int which, DateTime dt)
        {
            _periods[which].TimeOut = dt;
        }

        public void UpdateOutTime()
        {
            UpdateOutTime(_periods.Count - 1);
        }

        public void UpdateOutTime(int which)
        {
            UpdateOutTime(which, DateTime.Now);
        }

        public void UpdateOutTime(int which, DateTime dt)
        {
            _periods[which].TimeOut = dt;
        }


        internal void AddLoginCode(string loginCode)
        {
            _loginCode = loginCode;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", this.ID, this.FirstName, this.LastName);
        }

    }

    public class TimePeriod
    {
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
    } 

}

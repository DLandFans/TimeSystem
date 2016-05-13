using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using INFX.Timeclock;

namespace LogEmployee
{
    public partial class TimeClock : Form
    {
        private string _adminAccess;
        public Employees TheEmployees = new Employees();

        public TimeClock()
        {
            InitializeComponent();
            readConfig();
        }

        private void TimeClock_Load(object sender, EventArgs e)
        {
            TheEmployees.Read("employees.xml");
            lstEmployees.DataSource = TheEmployees.EmployeeList;
            buttonToggle(0);
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.Items.Count > 0 && lstEmployees.SelectedIndex >= 0)
            {
                buttonToggle(lstEmployees.SelectedIndex);
            }
        }

        private bool checkClockedIn(int emp)
        {
            if (TheEmployees.EmployeeList[emp].Periods.Count == 0) return false;

            TimePeriod test = TheEmployees.EmployeeList[emp].Periods.Last();

            if (test != null)
            {
                if (test.TimeIn == test.TimeOut)
                {
                    if (test.TimeIn.Date.ToShortDateString() != DateTime.Now.ToShortDateString())
                    {
                        //btnIn.Text = test.TimeIn.Date.ToShortDateString();
                        //btnOut.Text = DateTime.Now.ToShortDateString();
                        return false;
                    }
                    return true;
                }
            }
            return false; 
        }

        private void lstEmployees_DoubleClick(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin(TheEmployees,_adminAccess, this.Location, this.Size);
            form.ShowDialog();
            if (form.Changed)
            {
                lstEmployees.DataSource = null;
                lstEmployees.DataSource = TheEmployees.EmployeeList;
            }
            form.Dispose();
        }

        private void readConfig()
        {
            XmlReader reader = XmlReader.Create("config.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AdminCode":
                            this._adminAccess = reader.ReadString();
                            break;
                        default:
                            break;
                    }
                }
            }
            reader.Close();
        }

        private void buttonToggle(int user)
        {
            if (checkClockedIn(user))
            {
                btnIn.Enabled = false;
                btnOut.Enabled = true;
            }
            else
            {
                btnIn.Enabled = true;
                btnOut.Enabled = false;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmSecurity form = new frmSecurity(TheEmployees.EmployeeList[lstEmployees.SelectedIndex].LoginCode, this.Location, this.Size);
            form.ShowDialog();
            if (form.Changed)
            {
                TheEmployees.EmployeeList[lstEmployees.SelectedIndex].UpdateOutTime();
                TheEmployees.Write("employees.xml");

                lstEmployees.DataSource = null;
                lstEmployees.DataSource = TheEmployees.EmployeeList;
            }
            form.Dispose();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmSecurity form = new frmSecurity(TheEmployees.EmployeeList[lstEmployees.SelectedIndex].LoginCode, this.Location, this.Size);
            form.ShowDialog();
            if (form.Changed)
            {
                TheEmployees.EmployeeList[lstEmployees.SelectedIndex].CreateNewTimePeriod();
                TheEmployees.Write("employees.xml");

                lstEmployees.DataSource = null;
                lstEmployees.DataSource = TheEmployees.EmployeeList;
            }
            form.Dispose();
        }

        //Overrides the form closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

    }





}


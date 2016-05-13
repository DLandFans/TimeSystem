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
    public partial class frmAdmin : Form
    {
        private string _adminAccess;
        private Employees _employees = new Employees();
        private string _codetyped = "";
        private Point _parentLocation;
        private Size _parentSize;

        public bool Changed { get; set; }

        public frmAdmin(Employees employees, string adminAccess, Point location, Size size)
        {
            InitializeComponent();
            _employees = employees;
            _adminAccess = adminAccess;
            _parentLocation = location;
            _parentSize = size;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            grpHide.Location = new Point(-10, -10);
            this.Changed = false;

            //Centers the position of the form in the middle of the main form
            this.Location = new Point(
                (_parentLocation.X + (_parentSize.Width / 2)) - (this.Size.Width / 2),   //Take parent top-left, add 1/2 width, then subtract 1/2 width this form
                (_parentLocation.Y + (_parentSize.Height / 2)) - (this.Size.Height / 2)  //Do the same for the height
            );


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(grpHide.Visible)
            {
                string fill = "";
                _codetyped = string.Concat(_codetyped, e.KeyChar.ToString());
                int len = _codetyped.Length;

                if (_codetyped != _adminAccess.Substring(0, _codetyped.Length))
                {
                    _codetyped = "";
                }

                if (_codetyped == _adminAccess)
                {
                    grpHide.Visible = false;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            dlgImport.ShowDialog();
            _employees.EmployeeList.Clear();
            _employees.Read(dlgImport.FileName);
            _employees.Write("employees.xml");
            this.Changed = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dlgExport.ShowDialog();
            _employees.Write(dlgExport.FileName);
        }

    }
}

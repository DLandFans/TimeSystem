using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogEmployee
{
    public partial class frmSecurity : Form
    {

        private Point _parentLocation;
        private Size _parentSize;

        private string _codetyped = "";
        private string _loginCode;

        public bool Changed { get; set; }

        public frmSecurity(string loginCode, Point location, Size size)
        {
            InitializeComponent();
            _loginCode = loginCode;
            _parentLocation = location;
            _parentSize = size;

        }

        private void frmSecurity_Load(object sender, EventArgs e)
        {
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

        private void frmSecurity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _codetyped = string.Concat(_codetyped, e.KeyChar.ToString());
            int len = _codetyped.Length;

            if (_codetyped != _loginCode.Substring(0, _codetyped.Length))
            {
                _codetyped = "";
            }

            if (_codetyped == _loginCode)
            {
                this.Changed = true;
                this.Close();
            }

        }
    }
}

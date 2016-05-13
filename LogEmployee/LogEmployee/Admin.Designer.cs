namespace LogEmployee
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpHide = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseInside = new System.Windows.Forms.Button();
            this.dlgImport = new System.Windows.Forms.OpenFileDialog();
            this.dlgExport = new System.Windows.Forms.SaveFileDialog();
            this.grpHide.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(10, 75);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 33);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(10, 42);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(130, 33);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 108);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Time Clock";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpHide
            // 
            this.grpHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grpHide.Controls.Add(this.label1);
            this.grpHide.Controls.Add(this.btnClose);
            this.grpHide.Location = new System.Drawing.Point(-1000, -10);
            this.grpHide.Margin = new System.Windows.Forms.Padding(0);
            this.grpHide.Name = "grpHide";
            this.grpHide.Padding = new System.Windows.Forms.Padding(0);
            this.grpHide.Size = new System.Drawing.Size(170, 170);
            this.grpHide.TabIndex = 3;
            this.grpHide.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Code";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(22, 49);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 99);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseInside
            // 
            this.btnCloseInside.Location = new System.Drawing.Point(10, 9);
            this.btnCloseInside.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseInside.Name = "btnCloseInside";
            this.btnCloseInside.Size = new System.Drawing.Size(130, 33);
            this.btnCloseInside.TabIndex = 0;
            this.btnCloseInside.Text = "Close";
            this.btnCloseInside.UseVisualStyleBackColor = true;
            this.btnCloseInside.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dlgImport
            // 
            this.dlgImport.DefaultExt = "xml";
            this.dlgImport.FileName = "employees.xml";
            // 
            // dlgExport
            // 
            this.dlgExport.DefaultExt = "xml";
            this.dlgExport.FileName = "employees";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.ControlBox = false;
            this.Controls.Add(this.grpHide);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCloseInside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(150, 150);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAdmin_KeyPress);
            this.grpHide.ResumeLayout(false);
            this.grpHide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseInside;
        private System.Windows.Forms.OpenFileDialog dlgImport;
        private System.Windows.Forms.SaveFileDialog dlgExport;
    }
}
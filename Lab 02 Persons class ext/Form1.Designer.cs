namespace Lab_02_Persons_class_ext
{
    partial class Form1
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.lblGpa = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.lblHiredate = new System.Windows.Forms.Label();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(12, 27);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(12, 82);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name";
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.AllowDrop = true;
            this.btnCreatePerson.Location = new System.Drawing.Point(15, 386);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(235, 23);
            this.btnCreatePerson.TabIndex = 99;
            this.btnCreatePerson.Text = "Create Person";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(150, 27);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(150, 75);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowDrop = true;
            this.btnSearch.Location = new System.Drawing.Point(15, 472);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(235, 23);
            this.btnSearch.TabIndex = 98;
            this.btnSearch.Text = "Search by Last Name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(150, 229);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(12, 282);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhonenumber.TabIndex = 7;
            this.lblPhonenumber.Text = "Phone Number";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(150, 177);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 6;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 229);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 282);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(12, 177);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(30, 13);
            this.lblDob.TabIndex = 11;
            this.lblDob.Text = "DOB";
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(150, 129);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(100, 20);
            this.txtGpa.TabIndex = 5;
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Location = new System.Drawing.Point(12, 129);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(29, 13);
            this.lblGpa.TabIndex = 13;
            this.lblGpa.Text = "GPA";
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(150, 332);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(100, 20);
            this.txtHireDate.TabIndex = 9;
            // 
            // lblHiredate
            // 
            this.lblHiredate.AutoSize = true;
            this.lblHiredate.Location = new System.Drawing.Point(12, 332);
            this.lblHiredate.Name = "lblHiredate";
            this.lblHiredate.Size = new System.Drawing.Size(52, 13);
            this.lblHiredate.TabIndex = 15;
            this.lblHiredate.Text = "Hire Date";
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.Location = new System.Drawing.Point(150, 429);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameSearch.TabIndex = 10;
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.Location = new System.Drawing.Point(12, 436);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameSearch.TabIndex = 16;
            this.lblLastNameSearch.Text = "Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 596);
            this.Controls.Add(this.txtLastNameSearch);
            this.Controls.Add(this.lblLastNameSearch);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.lblHiredate);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnCreatePerson);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Name = "Form1";
            this.Text = "Lab 2 New Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label lblHiredate;
        private System.Windows.Forms.TextBox txtLastNameSearch;
        private System.Windows.Forms.Label lblLastNameSearch;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_02_Persons_class_ext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare List1 as the PersonList data type to store people in a list
        public PersonList List1 = new PersonList();
        int Count;



        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Person person1 = new Person(txtFName.Text, txtLName.Text, txtGpa.Text, txtDob.Text, txtSalary.Text, txtPhoneNumber.Text, txtHireDate.Text);
            List1.add(person1);
            MessageBox.Show("Person added!");
            
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getname = txtLastNameSearch.Text;
            Person p2 = new Person();
            p2 = List1[getname];
            p2.getPersonInfo();

        }
    }
}

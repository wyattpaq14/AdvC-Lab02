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
        //Declare List1 of the PersonList data type to store people in a list
        public PersonList List1 = new PersonList();



        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Person person1 = new Person(txtFName.Text, txtLName.Text, txtGpa.Text, txtDob.Text, txtSalary.Text, txtPhoneNumber.Text, txtHireDate.Text);
            //Start validation
            if (fieldCheck())
            {
                List1.add(person1);
                MessageBox.Show("Person added!");
                clearFields();
            }

            else
            {
                //Placeholder for later
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getname = txtLastNameSearch.Text;
            Person p2 = new Person();
            p2 = List1[getname];
            try
            {

                p2.getPersonInfo();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error!", "Error!");
            }

            clearFields();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }






        private void clearFields()
        {
            txtDob.Text = "";
            txtFName.Text = "";
            txtGpa.Text = "";
            txtHireDate.Text = "";
            txtLastNameSearch.Text = "";
            txtLName.Text = "";
            txtPhoneNumber.Text = "";
            txtSalary.Text = "";
        }

        private bool fieldCheck()
        {
            if (Validation.isValidName(txtFName.Text) && Validation.isValidName(txtLName.Text) && Validation.isValidGPA(txtGpa.Text) && Validation.isValidDate(txtDob.Text, "DOB") && Validation.isValidSalary(txtSalary.Text) && Validation.FieldCheck(txtPhoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

}

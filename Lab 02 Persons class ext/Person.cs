using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02_Persons_class_ext
{
    public class Person
    {
        //Declare variables that deal with person information
        private string fname;
        private string lname;
        private string gpa;
        private string dob;
        private string salary;
        private string phonenumber;
        private string hiredate;


        //Empty constructor
        public Person()
        {
        }


        //Constructors
        public Person(string fname, string lname, string gpa, string dob, string salary, string phonenumber, string hiredate)
        {
            this.FName = fname;
            this.LName = lname;
            this.Gpa = Validation.Gpa;
            this.Dob = Validation.DOBCheck(dob);
            this.Salary = salary;
            this.PhoneNumber = phonenumber;

            //Check if hire date, and set it to todays date if it isn't set
            this.HireDate = Validation.HireDateCheck(hiredate);
        }


        //Properties
        public string FName
        {
            get
            {

                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string LName
        {
            get
            {
                return lname;
            }
            set
            {

                lname = value;
            }

        }

        public string Gpa
        {
            get
            {
                return gpa;
            }
            set
            {

                gpa = value;
            }

        }

        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {

                dob = value;
            }

        }

        public string Salary
        {
            get
            {
                return salary;
            }
            set
            {

                salary = value;
            }

        }

        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {

                phonenumber = value;
            }

        }

        public string HireDate
        {
            get
            {

                return hiredate;
            }
            set
            {

                hiredate = value;
            }

        }

        //Methods

        //Display all information that was entered
        public void getPersonInfo()
        {
            MessageBox.Show("First Name: " + fname + "\n" + "Last Name: " + lname + "\n" + "GPA: " + gpa + "\n" + "DOB: " + dob + "\n" + "Salary: " + salary + "\n" + "Phone NUmber:" + phonenumber + "\n" + "Hire Date:" + hiredate + "\n", fname + " " + lname + "'s Information");
        }
    }
}


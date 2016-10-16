using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02_Persons_class_ext
{
    public static class Validation
    {
        private static string message = "Error";

        //Property
        public static string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }


        }

        //Check to see if fields are not empty, returns which box needs to be entered
        public static bool FieldCheck(TextBox txtbx)
        {
            TextBox currentTxtBox = txtbx;
            if (txtbx.Text == "")
            {
                MessageBox.Show("Please make sure the " + txtbx.Name + " field isn't empty!", "Empty field!");
                return false;
            }
            else
            {
                return true;
            }
        }



        //Check the hiredate and set it based on its validity
        public static string HireDateCheck(string hiredate)
        {
            if (isValidDate(hiredate))
            {
                return DateTime.Today.ToString("d");
            }
            else
            {
                return hiredate;
            }
        }


        //Method that returns date of birth
        public static string DOBCheck(string dob)
        {
            if (isValidDate(dob))
            {
                return "Error!";
            }
            else
            {
                return dob;
            }
        }
        //Method that returns GPA
        public static string GPACheck(string gpa)
        {
            if (isValidDate(gpa))
            {
                return "Error!";
            }
            else
            {
                return gpa;
            }
        }
        //Method that returns salary
        public static string SalaryCheck(string salary)
        {
            if (isValidDate(salary))
            {
                return "Error!";
            }
            else
            {
                return salary;
            }
        }




        //Check if a date is valid
        private static bool isValidDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Date isn't valid!", "Date error!");
                return false;
            }
        }

        //See if GPA is valid
        private static bool isValidGPA(string gpa)
        {
            decimal stringConversion = Convert.ToDecimal(gpa);
            if (stringConversion > 0 && stringConversion < 4)
            {
                return true;
            }
            else
            {
                MessageBox.Show("GPA isn't valid!", "GPA error!");
                return false;
            }
        }

        //See if sallary is valid
        private static bool isValidSalary(string salary)
        {
            decimal stringConversion = Convert.ToDecimal(salary);
            if (stringConversion > 0 && stringConversion < 113000000000)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Sallary isn't valid!", "Sallary error!");
                return false;
            }
        }
    }
}

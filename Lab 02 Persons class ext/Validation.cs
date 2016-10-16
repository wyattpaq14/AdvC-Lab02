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



        //Check the hiredate and set it based on validity
        public static string HireDateCheck(string hiredate)
        {
            if (isValidDate(hiredate, "Hire"))
            {
                return hiredate;
            }
            else
            {
                return DateTime.Today.ToString("d");

            }
        }


        //Method that returns date of birth
        public static string DOBCheck(string dob)
        {
            if (isValidDate(dob, "DOB"))
            {
                return dob;

            }
            else
            {
                return "Error!";
            }
        }
        //Method that returns GPA
        public static string GPACheck(string gpa)
        {
            if (isValidGPA(gpa))
            {
                return gpa;
            }
            else
            {
                return "Error!";

            }
        }
        //Method that returns salary
        public static string SalaryCheck(string salary)
        {
            if (isValidSalary(salary))
            {

                return salary;
            }
            else
            {
                return "Error!";
            }
        }
        //Method that returns names
        public static string NameCheck(string name)
        {

            if (isValidName(name))
            {

                return name;
            }
            else
            {
                return "Error!";
            }


        }
        //Check if a date is valid
        public static bool isValidDate(string date, string dateField)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show(dateField + " date isn't valid!", "Date error!");
                return false;
            }
        }

        //See if GPA is valid
        public static bool isValidGPA(string gpa)
        {
            decimal stringConversion = 0;
            try
            {
                stringConversion = Convert.ToDecimal(gpa);
            }
            catch(FormatException)
            {
                //Catch blank entry
            }
            catch (OverflowException)
            {
                //Catch large entry
            }


            if (stringConversion >= 0 && stringConversion <= 4)
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
        public static bool isValidSalary(string salary)
        {
            decimal stringConversion = 0;
            try
            {
                stringConversion = Convert.ToDecimal(salary);
            }
            catch (FormatException)
            {
                //Catch blank entry
            }
            catch (OverflowException)
            {
                //Catch large entry
            }

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



        //See if a name is valid
        public static bool isValidName(string name)
        {
            if (name.Length > 0 && name.Length < 20)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your name was either too short, or too long!", "Name error!");
                return false;
            }
        }
    }
}

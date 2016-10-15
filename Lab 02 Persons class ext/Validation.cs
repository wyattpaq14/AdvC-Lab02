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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02_Persons_class_ext
{
    public class Validation
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


        public static bool NameCheck(TextBox txtbx)
        {
            if (txtbx.Text == "")
            {
                return false;

            }
            else
            {
                return true;
            }



        }
    }
}

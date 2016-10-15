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
        private string name; //Fields for Name and ID
        private string idnum;

        //Empty constructor
        public Person()
        {
        }


        //Constructors
        public Person(string name)
        {
            this.Name = name;
            this.Idnum = "9999";

        }

        public Person(string name, string idnum)
        {
            this.Name = name;
            this.Idnum = idnum;
        }

        //Properties
        public string Name
        {
            get
            {

                return name;
            }
            set
            {
                name = value;
            }
        }


        public string Idnum
        {
            get
            {
                return idnum;
            }
            set
            {

                idnum = value;
            }

        }

        //Methods
        public string getPersonInfo()  //method to display name and ID
        {
            return "The New person's name is " + name + " and their ID is " + idnum;
        }
    }
}


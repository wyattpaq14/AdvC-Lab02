using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Persons_class_ext
{
    public class PersonList
    {
        private List<Person> peoplelist;

        public PersonList()
        {
            peoplelist = new List<Person>();
        }

        //Read only property to return the number of people in the list
        public int Count
        {

            get
            {
                return peoplelist.Count;

            }


        }


        public void add(Person p)
        {
            peoplelist.Add(p);

        }

        public Person getbyindex(int i)
        {
            return peoplelist[i];

        }


        public Person this[string name]
        {
            get
            {
                foreach (Person p in peoplelist)
                {
                    if (p.Name == name)
                    {
                        return p;
                    }


                }
                return null;
            }


        }


        public static PersonList operator +(PersonList pl, Person p)
        {
            pl.add(p);
            return pl;

        }
    }
}

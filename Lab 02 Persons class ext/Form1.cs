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
            Person person1 = new Person(txtName.Text, txtId.Text);

            List1.add(person1);
            Count = List1.Count;

            MessageBox.Show("A new person has been added to the list. There are a total of " + Count + " in the list");

            lblOutput.Text = person1.getPersonInfo();



            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getname = txtName.Text;
            Person p2 = new Person();
            p2 = List1[getname];
            lblOutput.Text = p2.getPersonInfo();
        }
    }
}

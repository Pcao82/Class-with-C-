using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__with_Class
{
    public partial class Form : System.Windows.Forms.Form
    {
        class Person 
        {
            private string name;
            private string address;
            private string city;
            private string state;
            private string zipcode;

            public string Name
            {
                get { return name;}
                set { name = value;}
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }

                public string City
            {
                get { return city; }
                set { city = value; }
                }

            public string Zipcode
            {
                get { return zipcode;}
                set { zipcode = value;}
               
            }

            public string State
            {
                get { return state;}
                set { state = value; }
            }

            



        
        }
        public Form()
        {
            InitializeComponent();
        }

        private void Labelresults_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person personobject = new Person();
            personobject.Name = txtName.Text;
            personobject.Address = txtAddress.Text;
            personobject.State = txtState.Text;
            personobject.City = txtCity.Text;
            personobject.Zipcode = txtZipcode.Text;

            listBoxResults.Items.Add(personobject.Name);
            listBoxResults.Items.Add(personobject.Address);
            listBoxResults.Items.Add(personobject.City);
            listBoxResults.Items.Add(personobject.State);
            listBoxResults.Items.Add(personobject.Zipcode);


        }

        private void Textname_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

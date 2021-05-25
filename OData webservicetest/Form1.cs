using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OData_webservicetest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Read data from business central
            Odataservice.NAV nav = new Odataservice.NAV(new Uri("http://localhost:7048/BC140/OData/Company('CRONUS%20International%20Ltd.')"));
            nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var customers = from c in nav.my_customer_service select c;
            dataGridView1.DataSource = customers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Insert data  from business central
            Odataservice.NAV nav = new Odataservice.NAV(new Uri("http://localhost:7048/BC140/OData/Company('CRONUS%20International%20Ltd.')"));
            nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var customers = new Odataservice.my_customer_service
            {
                Name = "myodata service ",
                Address="Bole",
                Credit_Limit_LCY=1500
            };
            nav.AddTomy_customer_service(customers);
            nav.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Update date from business central
            Odataservice.NAV nav = new Odataservice.NAV(new Uri("http://localhost:7048/BC140/OData/Company('CRONUS%20International%20Ltd.')"));
            nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var cusatomers = nav.my_customer_service.Where(c => c.No == "C00010").First();
            cusatomers.Credit_Limit_LCY = 20000;
            cusatomers.Name = "Myodata Demos";
            // cusatomers.Address = "boles";
            nav.UpdateObject(cusatomers);
            nav.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete data from business central
            Odataservice.NAV nav = new Odataservice.NAV(new Uri("http://localhost:7048/BC140/OData/Company('CRONUS%20International%20Ltd.')"));
            nav.Credentials = CredentialCache.DefaultNetworkCredentials;
            var cusatomers = nav.my_customer_service.Where(c => c.No == "C00010").First();
            nav.DeleteObject(cusatomers);
            nav.SaveChanges();
        }
    }
}

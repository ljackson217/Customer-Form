// Lindsay Allen (Jackson)
// CIS162AD - #31778
// 04/26/21
// Chapter 11 - Person and Customer Classes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Form
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // creates new Customner object
            Customer customer = new Customer();

            try
            {
                // assigns values to Customer properties
                customer.Name = nameInput.Text;
                customer.Address = addressInput.Text;
                customer.Telephone = telephoneInput.Text;
                customer.CustomerID = Convert.ToInt32(idNumberInput.Text);
                customer.MailingList = mailingListValue();


                // Displays customer info
                customerInfoOutput.Text = "Name: " + customer.Name + "\n" +
                                          "Address: " + customer.Address + "\n" +
                                          "Telephone: " + customer.Telephone + "\n" +
                                          "ID Number: " + customer.CustomerID + "\n" +
                                          MailingListOutput(customer.MailingList);
            }
            catch
            {
                MessageBox.Show("Please enter valid data.");
            }

        }

        public bool mailingListValue ()
        {
            if (mailingListCheckbox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string MailingListOutput(bool mailingListValue)
        {
            if (mailingListValue)
            {
                return "I would like to be on the mailing list";
            }
            else
            {
                return "I do not want to be on the mailing list";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

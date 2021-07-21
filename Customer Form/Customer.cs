// Lindsay Allen (Jackson)
// CIS162AD - #31778
// 04/26/21
// Chapter 11 - Person and Customer Classes

using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Form
{
    class Customer : Person
    {
        private int customerID;
        private bool mailingList;

        // constructor
        public Customer()
        {
            name = "";
            address = "";
            telephone = "";
            customerID = 0;
            mailingList = true;
        }

        // CustomerID property
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        // MailingList property
        public bool MailingList
        {
            get
            {
                return mailingList;
            }

            set
            {
                mailingList = value;
            }
        }

    }
}

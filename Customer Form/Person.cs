// Lindsay Allen (Jackson)
// CIS162AD - #31778
// 04/26/21
// Chapter 11 - Person and Customer Classes

using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Form
{
    class Person
    {
        protected string name;
        protected string address;
        protected string telephone;

        // constructor
        public Person()
        {
            name = "";
            address = "";
            telephone = "";
        }

        // Name property
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

        // Address property
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        // Telephone property
        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1st
{
    class customer
    {
        int CustomerID;
        string CustomerName;
        string CustomerMail;
        string Location;
        string DOB;

        public int CustomerID1
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
            }
        }

        public string CustomerName1
        {
            get
            {
                return CustomerName;
            }

            set
            {
                CustomerName = value;
            }
        }

        public string CustomerMail1
        {
            get
            {
                return CustomerMail;
            }

            set
            {
                CustomerMail = value;
            }
        }

        public string Location1
        {
            get
            {
                return Location;
            }

            set
            {
                Location = value;
            }
        }

        public string DOB1
        {
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }
    }
}

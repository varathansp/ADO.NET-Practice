using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO1st
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomerDataAccess obj = new CustomerDataAccess();
        start:
            Console.WriteLine("1.AddCustomer\t2.Get\t3.update\t4.delete");
            int sw;
            Console.WriteLine("Enter the option");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    obj.addCustomer();
                    break;
                case 2:
                    Console.WriteLine("Enter the customer id");
                    int idd = Convert.ToInt32(Console.ReadLine());
                    obj.getCustomerDetails(idd);
                    break;

                case 3:

                    obj.updateCustomer();
                    break;
                case 4:
                    obj.deleteCustomer();
                    break;
            }
            goto start;

        }
    }
}

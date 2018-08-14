using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO1st
{
    class CustomerDataAccess
    {
        SqlConnection conObj = new SqlConnection("server=VARATHAN;database=dbsample;integrated security=true");
        SqlCommand commandObj;
        public void addCustomer()
        {
            int result;

            try
            {
                customer cusObj = new customer();
                Console.WriteLine("Enter the Customer ID");
                cusObj.CustomerID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Customer Name");
                cusObj.CustomerName1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer Mail");
                cusObj.CustomerMail1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer Location");
                cusObj.Location1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer DOB");
                cusObj.DOB1 = Console.ReadLine();

                commandObj = new SqlCommand("insert into customer values(" + cusObj.CustomerID1 + ",'" + cusObj.CustomerName1 + "','" + cusObj.CustomerMail1 + "','" + cusObj.Location1 + "','" + cusObj.DOB1 + "')", conObj);
                conObj.Open();
                result = commandObj.ExecuteNonQuery();
                if (result > 0)
                { Console.WriteLine("Customer added"); }
                else
                { Console.WriteLine("Customer not added"); }
                conObj.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void getCustomerDetails(int id)
        {
            try
            {
                commandObj = new SqlCommand("select * from customer where customerID=" + id, conObj);
                conObj.Open();
                SqlDataReader readerObj = commandObj.ExecuteReader();
                while (readerObj.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", readerObj["CustomerName"], readerObj["CustomerMail"], readerObj["Location"], readerObj["DOB"]);
                }
                readerObj.Close();
                conObj.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void updateCustomer()
        {
            int result;

            try
            {
                customer cusObj = new customer();
                Console.WriteLine("Enter the Customer ID");
                cusObj.CustomerID1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Customer Name");
                cusObj.CustomerName1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer Mail");
                cusObj.CustomerMail1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer Location");
                cusObj.Location1 = Console.ReadLine();
                Console.WriteLine("Enter the Customer DOB");
                cusObj.DOB1 = Console.ReadLine();

                commandObj = new SqlCommand("update customer set CustomerName='" + cusObj.CustomerName1 + "',CustomerMail='" + cusObj.CustomerMail1 + "',Location='" + cusObj.Location1 + "',DOB='" + cusObj.DOB1 + "' where CustomerID=" + cusObj.CustomerID1, conObj);
                conObj.Open();
                result = commandObj.ExecuteNonQuery();
                if (result > 0)
                { Console.WriteLine("Updated"); }
                else
                { Console.WriteLine("Not updated"); }
                conObj.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void deleteCustomer()
        {
            int result;

            try
            {
                customer cusObj = new customer();
                Console.WriteLine("Enter the Customer ID");
                cusObj.CustomerID1 = Convert.ToInt32(Console.ReadLine());

                commandObj = new SqlCommand("delete customer where CustomerID=" + cusObj.CustomerID1, conObj);
                conObj.Open();
                result = commandObj.ExecuteNonQuery();
                if (result > 0)
                { Console.WriteLine("Deleted"); }
                else
                { Console.WriteLine("Not Deleted"); }
                conObj.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

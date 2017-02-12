using ShoppingCartDataAccess;
using ShoppingCartEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////String lastName1  = "Shawn"test";
            ////String lastName = "Smith\"test"; // Output: Smith"test
            //String lastName = @"Smith\";// test"; @ treat escape char \ as normal char
            //Console.WriteLine(lastName);
            //Console.ReadLine();

            //TestClass testClass = null;

            //String firstName = testClass.FirstName;

            //ReadOrderDataFromSql();

            //Console.WriteLine("Please enter customer Id:");
            //var customerId = Convert.ToInt32(Console.ReadLine());
            //ReadOrderDataFromSp(customerId);

            DemoOrmWithEntity(true);
            Console.ReadLine();
        }


        private static void ReadOrderDataFromSql()
        {
            String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
            string queryString = "SELECT * FROM dbo.MyOrder;";

            //using =  TRY {} CATCH{} FINAL()
            using (var connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                //command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                //enumerator
                while (reader.Read())
                {
                    //ReadSingleRow((IDataRecord)reader);
                    //var record = (IDataRecord)reader;
                    Console.WriteLine(String.Format("{0}, {1}, {2}", reader[0], reader[1], reader[2]));
                }

                // Call Close when done reading.
                reader.Close();
            }
        }


        private static void ReadOrderDataFromSp(int customerId)
        {
            String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";

            using (var connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("usp_Customer_GetOrders", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", customerId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                //enumerator
                while (reader.Read())
                {
                    //ReadSingleRow((IDataRecord)reader);
                    //var record = (IDataRecord)reader;
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]));
                }

                // Call Close when done reading.
                reader.Close();
            }
        }


        private static void DemoOrmWithEntity(Boolean isActive)
        {
            //String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";

            //using (var connection =
            //           new SqlConnection(connectionString))
            //{
            //    SqlCommand command =
            //        new SqlCommand("usp_Customer_GetAllActive", connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("IsActive", isActive);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();
            //    List<Customer> customers = new List<Customer>();

            //    while (reader.Read())
            //    {
            //        //ReadSingleRow((IDataRecord)reader);
            //        //var record = (IDataRecord)reader;
            //        //Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]));
            //        //Serialization

            //        var customer = Serialization(reader);
            //        customers.Add(customer);
            //    }

            //    // Call Close when done reading.
            //    reader.Close();

            var customers = CustomerDao.GetAllCustomers(true);

            Display(customers);

        }


        //private static Customer Serialization(IDataReader reader)
        //{
        //    Customer customer = new Customer();
        //    customer.Id = Convert.ToInt32(reader[0]);
        //    customer.FirstName = Convert.ToString(reader[1]);
        //    customer.LastName = Convert.ToString(reader[2]);
        //    customer.Email = Convert.ToString(reader[3]);
        //    customer.UserName = Convert.ToString(reader[4]);
        //    customer.Password = Convert.ToString(reader[5]);
        //    customer.Phone = Convert.ToString(reader[6]);
        //    customer.IsActive = Convert.ToBoolean(reader[7]);
        //    customer.CreateDate = Convert.ToDateTime(reader[8]);
        //    return customer;
        //}

        private static void Display(List<Customer> customers)
        {
            foreach (var c in customers)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",
                    c.Id, c.FirstName, c.LastName, c.Email, c.UserName, c.Password, c.Phone, c.IsActive, c.CreateDate));
            }
        }

        //private static void ReadSingleRow(IDataRecord record)
        //{
        //    Console.WriteLine(String.Format("{0}, {1}, {2}", record[0], record[1], record[2]));
        //}

    }
}


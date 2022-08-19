
using System;
using System.Collections.Generic;
using Persistence;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class CustomerDAL
    {
        private string query;
        private MySqlConnection connection = DbConfig.GetMySqlConnection();
        private MySqlDataReader reader;

        public Customer GetById(string customerId)
        {
            Customer c = null;
            try
            {
                connection.Open();
                query = @"select id_customer, name_customers,gender_customers,birth_date,id_card,phone_number,id_app,email,
                ifnull(customer_address, '') as customer_address
                
                from Customers where id_customers=" + customerId + ";";
                reader = (new MySqlCommand(query, connection)).ExecuteReader();
                if (reader.Read())
                {
                    c = GetCustomer(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return c;
        }
        internal Customer GetCustomer(MySqlDataReader reader)
        {
            Customer c = new Customer();
            c.CustomerId = reader.GetString("id_customer");
            c.CustomerName = reader.GetString("name_customers");
            c.CustomerGender = reader.GetString("gender_customers");
            c.CustomerBirthDate = reader.GetDateTime("birth_date");
            c.CustomerCardId = reader.GetDouble("id_card");
            c.CustomerPhoneNumber=reader.GetDouble("phone_number");
            c.IdApp=reader.GetString("id_app");
            c.CustomerEmail=reader.GetString("email");
            c.CustomerAddress = reader.GetString("customer_address");
            return c;
        }
        public int? AddCustomer(Customer c)
        {
            int? result = null;
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = @"insert into customers(id_customers,name_customers,gender_customers,birth_date,id_card,phone_number,id_app,email,customer_address) 
            values(@id_customers,@name_customers,@gender_customers,@birth_date,@id_card,@phone_number,@id_app,@email,@customer_address)  ";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_customers", c.CustomerId);
            command.Parameters.AddWithValue("@name_customers", c.CustomerName);
            command.Parameters.AddWithValue("@gender_customers", c.CustomerGender);
            command.Parameters.AddWithValue("@birth_date", c.CustomerBirthDate);
            command.Parameters.AddWithValue("@id_card", c.CustomerCardId);
            command.Parameters.AddWithValue("@phone_number", c.CustomerPhoneNumber);
            command.Parameters.AddWithValue("@id_app", c.IdApp);
            command.Parameters.AddWithValue("@email", c.CustomerEmail);
            command.Parameters.AddWithValue("@customer_address", c.CustomerAddress);
            command.ExecuteNonQuery();
            return result;
        }
    }
}

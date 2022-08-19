using System;
using System.Collections.Generic;
using Persistence;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class CustomerTrialDAL
    {
        private string query;
        private MySqlConnection connection = DbConfig.GetMySqlConnection();
        private MySqlDataReader reader;
        public CustomerTrial GetById(string CustomerTrialId)
        {
            CustomerTrial c = null;
            try
            {
                connection.Open();
                query = @"select id_customer,name_customer,email,birth_date,gender,id_app,date_sub_cus,address_customer,
                    ifnull(address_customer,'')as address_customer
                    from Customers_trial where id_customer=" + CustomerTrialId + ";";
                reader = (new MySqlCommand(query, connection)).ExecuteReader();
                if (reader.Read())
                {
                    c = GetCustomerTrial(reader);
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
        internal CustomerTrial GetCustomerTrial(MySqlDataReader reader)
        {
            CustomerTrial c = new CustomerTrial();
            c.CustomerTrialId = reader.GetString("id_customer");
            c.CustomerTrialName = reader.GetString("name_customer");
            c.CustomerTrialEmail=reader.GetString("email");
            c.CustomerTrialBirthDate=reader.GetDateTime("birth_date");
            c.CustomerTrialGender=reader.GetString("gender");
            c.IdApp=reader.GetString("id_app");
            c.CustomerTrialSubDate=reader.GetDateTime("date_sub_cus");
            c.CustomerAddress = reader.GetString("address_customer");
            return c;
        }
        public int? AddCustomer(CustomerTrial c){
            int? result=null;
            if(connection.State==System.Data.ConnectionState.Closed){
                connection.Open();
            }
            MySqlCommand command=new MySqlCommand();
            command.Connection=connection;
            command.CommandText=@"insert into customers_trial(id_customer,name_customer,email,birth_date,gender,id_app,date_sub_cus,address_customer)
            values(@id_customer,@name_customer,@email,@birth_date,@gender,@id_app,@date_sub_cus,@address_customer)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_customer",c.CustomerTrialId);
            command.Parameters.AddWithValue("@name_customer",c.CustomerTrialName);            
            command.Parameters.AddWithValue("@email",c.CustomerTrialEmail);
            command.Parameters.AddWithValue("@birth_date",c.CustomerTrialBirthDate);
            command.Parameters.AddWithValue("@gender",c.CustomerTrialGender);
            command.Parameters.AddWithValue("@id_app",c.IdApp);
            command.Parameters.AddWithValue("@date_sub_cus",c.CustomerTrialSubDate);
            command.Parameters.AddWithValue("@address_customer",c.CustomerAddress);
            command.ExecuteNonQuery();
            return result;
        }
    }
}
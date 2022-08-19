using System;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DbConfig
    {
       private static MySqlConnection connection=new MySqlConnection();
       private DbConfig(){}
       public static MySqlConnection GetDeaultConnection(){
      
       connection.ConnectionString="server=localhost;userid=root;password=thanh12345;database=Project;";
       return connection;
       }
        public static MySqlConnection GetMySqlConnection(){
            try{
                string conString;
                using(System.IO.FileStream fileStream=System.IO.File.OpenRead("DbConfig.txt")){
                    using(System.IO.StreamReader reader=new System.IO.StreamReader(fileStream)){
                        conString=reader.ReadLine();
                    }
                }
                return GetMySqlConnection(conString);
            }
            catch{
                return null;
            }
        }
        public static MySqlConnection GetMySqlConnection(string connectionString){
            connection.ConnectionString=connectionString;
            return connection;
        }
    }
}



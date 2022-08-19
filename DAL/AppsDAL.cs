using System;
using System.Collections.Generic;
using Persistence;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAL
{
    // public static class ItemFilter{
    //     public const int GET_ALL=0;
    //     public const int FILTER_BY_ITEM_NAME=1;
    // }
    public class AppsDAL
    {
        private MySqlConnection connection = DbConfig.GetMySqlConnection();
        private MySqlDataReader? reader;
        private MySqlCommand command = new MySqlCommand();
        public App GetById(string idApp)
        {
            App app = null;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select id_app, version_app,date_debut,name_app,type_app
            ifnull(price_app'')as price_app
            from Apps where id_app=" + idApp + ";";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    app = GetApp(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            };
            return app;


        }
        public List<App> GetAllApps()
        {
            List<App> listapp = new List<App>();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Apps";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    App app = GetApp(reader);
                    listapp.Add(app);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("loi o dayvfr" + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return listapp;
        }
        internal App GetApp(MySqlDataReader reader)
        {
            App c = new App();
            try
            {
                c.AppId = reader.GetString("id_app");
                c.AppName = reader.GetString("name_app");
                c.AppVersion = reader.GetString("version_app");
                c.AppDateDebut = DateOnly.Parse(reader.GetDateTime("date_debut").ToString("dd/MM/yyyy"));
                c.AppType = reader.GetString("type_app");
                c.AppPrice = reader.GetDouble("price_app");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return c;
        }
        public int? AddApp(App c)
        {
            int? result = null;
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = @"insert into apps(id_app,name_app,version_app,date_debut,type_app,pirce_app)
            values(@id_app,@name_app,@version_app,@date_debut,@type_app,@price_app)";
            command.Parameters.Clear();
            // command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_app", c.AppId);
            command.Parameters.AddWithValue(",@name_app", c.AppName);
            command.Parameters.AddWithValue(",@version_app", c.AppVersion);
            command.Parameters.AddWithValue("@date_debut", c.AppDateDebut);
            command.Parameters.AddWithValue("@type_app", c.AppType);
            command.Parameters.AddWithValue("@price_app", c.AppPrice);
            command.ExecuteNonQuery();
            return result;

        }
    }
}
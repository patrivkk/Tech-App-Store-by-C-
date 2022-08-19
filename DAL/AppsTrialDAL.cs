using System;
using System.Collections.Generic;
using Persistence;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class AppsTrialDAL{
        private string query;
        private MySqlConnection connection=DbConfig.GetMySqlConnection();
        private MySqlDataReader reader;
        public AppsTrial GetById(string idApp){
            AppsTrial app=null;
            try{
                connection.Open();
                query=@"select id_app,name_app,type_app,date_debut,paid_or_free,version_app
                ifnull(version_app'')as version_app
                from trialmode where id_app="+idApp+";";
                reader=(new MySqlCommand(query,connection)).ExecuteReader();
                if(reader.Read()){
                    app=GetApps(reader);
                }
                reader.Close();
            }catch{}
            finally{
                connection.Close();
            };
        return app;
        }
        internal AppsTrial GetApps(MySqlDataReader reader){
            AppsTrial c=new AppsTrial();
            c.AppTrialId=reader.GetString("id_app");
            c.AppTrialName=reader.GetString("name_app");
            c.AppTrialType=reader.GetString("type_app");
            c.AppTrialDateDebut=reader.GetDateTime("date_deubt");
            c.AppTrialPaidOrFree=reader.GetString("paid_or_free");
            c.AppTrialVersion=reader.GetString("version_app");
            return c;
        }
        public int? AddApp(AppsTrial c){
            int? result=null;
            if(connection.State==System.Data.ConnectionState.Closed){
                connection.Open();
            }
            MySqlCommand command=new MySqlCommand();
            command.Connection=connection;
            command.CommandText=@"insert into trialmode(id_app,name_app,type_app,date_debut,paid_or_free,version_app)
            values(@id_app,@name_app,@type_app,@date_debut,@paid_or_free,@version_app)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_app",c.AppTrialId);
            command.Parameters.AddWithValue("@name_app",c.AppTrialName);
            command.Parameters.AddWithValue("@type_app",c.AppTrialType);
            command.Parameters.AddWithValue("@date_debut",c.AppTrialDateDebut);
            command.Parameters.AddWithValue("@paid_or_free",c.AppTrialPaidOrFree);
            command.Parameters.AddWithValue("@version_app",c.AppTrialVersion);
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QAProject
{
    class SiteTest
    {
        private static MySqlConnection connection;

        public static void SiteReset()
        {
            string myConnectionString = "server=47.55.247.242;database=bitter-site8;uid=nick;pwd=asdf;";
            connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}

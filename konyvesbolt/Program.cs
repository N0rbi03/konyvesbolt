using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace konyvesbolt
{
    internal class Program
    {
        static MySqlConnection conn=null;
        static MySqlCommand sql = null;

        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            mySqlConnectionStringBuilder.Server = "localhost";
            mySqlConnectionStringBuilder.Database = "konyvesbolt";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "";
            conn = new MySqlConnection(mySqlConnectionStringBuilder.ToString());
            conn.Open();
        }
        static void legidosebb()
        { 
            //sql command lefuttatását,hozzáadását nem tudom ezeket is tanárúr git jéről szedtem mert mindent elfelejtettem kb
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ConsoleApp1
{
    class ConexionBD
    {
        public static MySqlConnection GetMySqlConnection()
        {

            string server = "127.0.0.1";
            int port = 3306;
            string username = "root";
            string password = "admin";
            string database = "trabajo_practico_prog3";
            string ssl = "None";

            return ConexionMySQLBD.GetMySqlConnection(server,port,username,password,database, ssl);

        }
        

    }
}

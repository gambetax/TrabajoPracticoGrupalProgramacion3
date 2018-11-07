using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class ConexionMySQLBD
    {
        public static MySqlConnection GetMySqlConnection(string server, int port, string username, string password, string database, string ssl)
        {

            string connString = "server= " + server + ";port= " + port +
                                ";username= " + username + ";password= " + password + ";database= " + database + ";SSL Mode= " + ssl;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Conexion;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class ConexionMySQLBD
    {
        private string connString;
        private static ConexionMySQLBD _INSTANCE;



        private ConexionMySQLBD(string server, int port, string username, string password, string database, string ssl)
        {
            this.connString = "server= " + server + ";port= " + port +
                                 ";username= " + username + ";password= " + password + ";database= " + database + ";SSL Mode= " + ssl;
        }

        public static ConexionMySQLBD getInstance()
        {
            if (_INSTANCE == null)
            {
                _INSTANCE = create();
            }
            return _INSTANCE;
        }

        private static ConexionMySQLBD create()
        {
            string server = "127.0.0.1";
            int port = 3306;
            string username = "root";
            string password = "admin";
            string database = "trabajo_practico_prog3";
            string ssl = "None";

            return new ConexionMySQLBD(server, port, username, password, database, ssl);
        }



        public MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(this.connString);

        }


        public void insertIntoTable(Insertable element, String tableName)
        {
            MySqlConnection con = GetMySqlConnection();
           
            try
            {

                string sql = "INSERT INTO " + tableName + " ( " + element.getOrderedFields() + " )" +
                                " VALUES ( " + element.getOrderedValues() + " ) ";
                con.Open();
                using (MySqlCommand cm = new MySqlCommand(sql,con))
                {    
                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                try { con.Close(); } catch (Exception e) { }

            }

        }

        public void SelectFromTable()
        {
            MySqlConnection con = GetMySqlConnection();

            try
            {

                string sql = "Select * from usuarios";
                string consulta = "";
                con.Open();

                using (MySqlCommand cm = new MySqlCommand(sql, con))
                {
                    MySqlDataReader dr = cm.ExecuteReader();

                    while(dr.Read())
                    {
                        consulta += dr[0] + "-- Nombre: " + dr[2] + ", Apellido: " + dr[3] + "\n" ;
                    }

                    Console.WriteLine(consulta);

                    Console.ReadKey();

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                try { con.Close(); } catch (Exception e) { }

            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectando...");
            Console.ReadLine();

            MySqlConnection conexion = ConexionBD.GetMySqlConnection();

            Console.WriteLine("Conectando...");
            Console.ReadLine();

            try
            {
                Console.WriteLine("Conectando a base de datos.");

                conexion.Open();

                Console.WriteLine("Conexion a base de datos exitosa!.");

                Console.ReadLine();

                string sql = "Select * from tipo_usuario";
                string output = "";
                MySqlCommand command = new MySqlCommand(sql, conexion);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + "ID: " + dataReader.GetValue(0) +
                        "NOMBRE: " + dataReader.GetValue(1) + 
                        "DESCRIPCION: " + dataReader.GetValue(2) +  "\n";

                    
                }

                Console.WriteLine(output);


                Console.ReadLine();




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            conexion.Close();

            Console.WriteLine("Desconectado. Presione tecla para terminar");

            Console.ReadLine();
        }
    }
}

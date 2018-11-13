using ConsoleApp1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Clases
{
    class Usuarios : Insertable
    {
        private int id_TipoUsuario;
        private string nombre;
        private string apellido;
        private string dni;
        private string usuario;
        private string pass;
        private string email;


        //CONSTRUCTOR
        public Usuarios(int idusuarios, int id_TipoUsuario, string nombre, string apellido, string dni, string usuario, string pass, string email)
        {
            this.GetSetIdusuarios = idusuarios;
            this.GetSetId_TipoUsuario = id_TipoUsuario;
            this.GetSetNombre = nombre;
            this.GetSetApellido = apellido;
            this.GetSetDni = dni;
            this.GetSetUsuario = usuario;
            this.GetSetPass = pass;
            this.GetSetEmail = email;
        }

        public Usuarios(int id_TipoUsuario, string nombre, string apellido, string dni, string usuario, string pass, string email)
        {
            this.GetSetId_TipoUsuario = id_TipoUsuario;
            this.GetSetNombre = nombre;
            this.GetSetApellido = apellido;
            this.GetSetDni = dni;
            this.GetSetUsuario = usuario;
            this.GetSetPass = pass;
            this.GetSetEmail = email;
        }

        private Usuarios() { }

        //METODOS

        public string getOrderedFields()
        {
            return "id_tipo_usuario, nombre, apellido, dni, usuario, pass, email";
        }

        public string getOrderedValues()
        {
            string escape = "'";

            return this.GetSetId_TipoUsuario+", "+
                escape+this.GetSetNombre+escape+", " +
                escape+this.GetSetApellido + escape + ", " +
                escape+this.GetSetDni + escape + ", " +
                escape+this.GetSetUsuario + escape + ", " +
                escape+this.GetSetPass +escape + ", " +
                escape+this.GetSetEmail +escape;
        }

        public string getIdField()
        {
            throw new NotImplementedException();
        }

        public string getIdValue()
        {
            throw new NotImplementedException();
        }

        //GET Y SET

        public int GetSetIdusuarios { get; set; }

        public int GetSetId_TipoUsuario { get => id_TipoUsuario; set => id_TipoUsuario = value; }
        public string GetSetNombre { get => nombre; set => nombre = value; }
        public string GetSetApellido { get => apellido; set => apellido = value; }
        public string GetSetDni { get => dni; set => dni = value; }
        public string GetSetUsuario { get => usuario; set => usuario = value; }
        public string GetSetPass { get => pass; set => pass = value; }
        public string GetSetEmail { get => email; set => email = value; }
    }
}

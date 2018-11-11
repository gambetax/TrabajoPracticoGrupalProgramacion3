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
            this.id_TipoUsuario = id_TipoUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.pass = pass;
            this.email = email;
        }

        public Usuarios(int id_TipoUsuario, string nombre, string apellido, string dni, string usuario, string pass, string email)
        {
            this.id_TipoUsuario = id_TipoUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.pass = pass;
            this.email = email;
        }

        private Usuarios() { }

        //METODOS

        public virtual string toString()
        {
            return "Id = " + this.GetSetIdusuarios + "Tipo de Usuario=  " + this.id_TipoUsuario + "Nombre :" + this.nombre +
               "Apellido=  " + this.apellido + "DNI= " + this.dni + "Usuario=" + this.usuario + "Email= " + this.email;
        }

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

        public int GetSetId_TipoUsuario
        {
            get
            {
                return id_TipoUsuario;
            }

            set
            {
                id_TipoUsuario = value;
            }
        }

        public string GetSetNombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string GetSetApellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string GetSetDni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string GetSetUsuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string GetSetPass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string GetSetEmail
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }




    }
}

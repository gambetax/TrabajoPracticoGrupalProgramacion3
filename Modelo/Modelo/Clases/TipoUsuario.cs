using ConsoleApp1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Clases
{
    class TipoUsuario : Insertable
    {
        private int IdTipoUsuario;
        private string Nombre;
        private string Descripcion;



        //CONSTRUCTOR

        public TipoUsuario (int id, string nombre, string des)
        {
            this.GetSetIdTipoUsuario = id;
            this.GetSetNombre = nombre;
            this.GetSetDescripcion = des;
        }

        public TipoUsuario() { }


        //GET Y SET


        public int GetSetIdTipoUsuario { get => IdTipoUsuario; set => IdTipoUsuario = value; }
        public string GetSetNombre { get => Nombre; set => Nombre = value; }
        public string GetSetDescripcion { get => Descripcion; set => Descripcion = value; }


        //METODO


        public string getOrderedFields()
        {
            return "idtipoUsuario, nombre, descripcion";
        }

        public string getOrderedValues()
        {
            string escape = "'";

            return this.GetSetIdTipoUsuario + ", " +
                escape + this.GetSetNombre + escape + ", " +
                escape + this.GetSetDescripcion + escape;
        }

        public string getIdField()
        {
            throw new NotImplementedException();
        }

        public string getIdValue()
        {
            throw new NotImplementedException();
        }




    }
}

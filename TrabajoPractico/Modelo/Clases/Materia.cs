using ConsoleApp1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Materia : Insertable
    {
        private int idMateria;
        private string nombre;
        private string descripcion;

        //CONSTRUCTOR

        public Materia(int idMateria, string nombre, string descripcion)
        {
            this.GetSetIdMateria = idMateria;
            this.GetSetNombre = nombre;
            this.GetSetDescripcion = descripcion;
        }

        //GET Y SET

        public int GetSetIdMateria { get => idMateria; set => idMateria = value; }
        public string GetSetNombre { get => nombre; set => nombre = value; }
        public string GetSetDescripcion { get => descripcion; set => descripcion = value; }



        //METODO

        public string getIdField()
        {
            throw new NotImplementedException();
        }

        public string getIdValue()
        {
            throw new NotImplementedException();
        }

        public string getOrderedFields()
        {
            return "idmateria, nombre, descripcion";
        }

        public string getOrderedValues()
        {
            string escape = "'";

            return this.GetSetIdMateria + ", " +
                escape + this.GetSetNombre + escape + ", " +
                escape + this.GetSetDescripcion + escape;
        }


    }
}

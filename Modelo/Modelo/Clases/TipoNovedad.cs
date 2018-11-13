using ConsoleApp1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class TipoNovedad : Insertable
    {

        private int idTipoNovedad;
        private string nombre;
        private string descripcion;

        // CONSTRUCTOR

        public TipoNovedad(int idTipoNovedad, string nombre, string descripcion)
        {
            this.GetSetIdTipoNovedad = idTipoNovedad;
            this.GetSetNombre = nombre;
            this.GetSetDescripcion = descripcion;
        }


        //GET Y SET

        public int GetSetIdTipoNovedad { get => idTipoNovedad; set => idTipoNovedad = value; }
        public string GetSetNombre { get => nombre; set => nombre = value; }
        public string GetSetDescripcion { get => descripcion; set => descripcion = value; }


        //METODOS


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
            return "idTipoNovedad, nombre, descripcion";
        }

        public string getOrderedValues()
        {
            string escape = "'";

            return this.GetSetIdTipoNovedad + ", " +
                escape + this.GetSetNombre + escape + ", " +
                escape + this.GetSetDescripcion + escape;
        }
    }
}

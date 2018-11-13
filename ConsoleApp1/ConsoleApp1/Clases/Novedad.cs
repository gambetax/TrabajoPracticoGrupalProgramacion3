using ConsoleApp1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Novedad : Insertable
    {

        private int idNovedad;
        private int idUsuario;
        private DateTime Fecha;
        private int idMateria;
        private string descripcion;


        //CONSTRUCTOR 

        public Novedad(int idNovedad, int idUsuario, DateTime fecha, int idMateria, string descripcion)
        {
            this.GetSetIdNovedad = idNovedad;
            this.GetSetIdUsuario = idUsuario;
            this.GetSetFecha = fecha;
            this.GetSetIdMateria = idMateria;
            this.GetSetDescripcion = descripcion;
        }

        //METODOS

        public string getOrderedFields()
        {
            return "idNovedad, idusuario, fecha, idmateria, descripcion";
        }

        public string getOrderedValues()
        {
            string escape = "'";

            return this.GetSetIdNovedad + ", " +
                escape + this.GetSetIdUsuario + escape + ", " +
                escape + this.GetSetFecha + escape + ", " +
                escape + this.GetSetIdMateria + escape + ", " +
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


        // GET Y SET

        public int GetSetIdNovedad { get => idNovedad; set => idNovedad = value; }
        public int GetSetIdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime GetSetFecha { get => Fecha; set => Fecha = value; }
        public int GetSetIdMateria { get => idMateria; set => idMateria = value; }
        public string GetSetDescripcion { get => descripcion; set => descripcion = value; }


    }
}

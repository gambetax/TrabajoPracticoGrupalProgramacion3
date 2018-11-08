using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Clases
{
    class TipoUsuario
    {
        private int IdTipoUsuario;
        private string Nombre;
        private string Descripcion;


        //CONSTRUCTOR

        public TipoUsuario (int id, string nombre, string des)
        {
            this.IdTipoUsuario = id;
            this.Nombre = nombre;
            this.Descripcion = des;
        }

        public TipoUsuario() { }


        //METODO

        public virtual string ToString()
        {
            return "Id = " + this.IdTipoUsuario + "Nombre :" + this.Nombre +
                "Descripcion " + this.Descripcion;

        }



        //GET SET

        public string GetSetNombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string GetSetDescripcion
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

        public int GetSetIdTipoUsuario
        {
            get
            {
                return IdTipoUsuario;
            }

            set
            {
                IdTipoUsuario = value;
            }
        }
    }
}

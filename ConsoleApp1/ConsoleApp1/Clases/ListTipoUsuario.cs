using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Clases
{
    class ListTipoUsuario
    {

        ArrayList listaUsuarios = new ArrayList();

        //CONSTRUCTOR
        public ListTipoUsuario()
        {
            this.listaUsuarios = new ArrayList();
        }

        //METODOS
        public ArrayList MostrarListaTipoUsuarios()
        {

            foreach (TipoUsuario usu in listaUsuarios)
            {
               
                Console.WriteLine(usu.ToString());

            }

            return this.listaUsuarios;

        }

        public void SetListaTipoUsuarios(TipoUsuario TipoUsu)
        {
            this.listaUsuarios.Add(TipoUsu);
        }
    }
}

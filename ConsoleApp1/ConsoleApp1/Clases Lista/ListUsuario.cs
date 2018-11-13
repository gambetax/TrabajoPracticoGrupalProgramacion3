using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1.Clases
{
    class ListUsuarios
    {
        ArrayList ListaUsuarios = new ArrayList();

        //CONSTRUCTOR
        public ListUsuarios()
        {
            this.ListaUsuarios = new ArrayList();
        }

        //METODOS
         public ArrayList mostrarLista()
        {

            foreach (TipoUsuario usu in ListaUsuarios)
            {

            }

            return null;
        }

        public void SetListaUsuario(Usuarios Usu)
        {
            this.ListaUsuarios.Add(Usu);
        }
    }


}

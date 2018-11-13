using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApp1.Clases;

namespace ConsoleApp1.Clases_Lista
{
    class ListaNovedades
    {
        ArrayList listaNovedades = new ArrayList();

        //CONSTRUCTOR
        public ListaNovedades()
        {
            this.listaNovedades = new ArrayList();
        }

        
        //METODOS

        
        public void SetListaNovedades(Novedad novedad)
        {
            this.listaNovedades.Add(novedad);
        }

        public void LimpiarListaNovedades()
        {
            this.listaNovedades.Clear();
        }




       




    }
}

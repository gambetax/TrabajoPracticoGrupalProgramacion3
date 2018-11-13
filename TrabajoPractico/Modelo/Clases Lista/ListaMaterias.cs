using System;
using System.Collections;
using ConsoleApp1.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases_Lista
{
    class ListaMaterias
    {

        ArrayList listaMaterias = new ArrayList();


        //CONSTRUCTOR

        public ListaMaterias()
        {
            this.listaMaterias = new ArrayList();
        }

        //METODOS

        public void SetListaMaterias(Materia materia)
        {
            this.listaMaterias.Add(materia);
        }

        public void LimpiarLista()
        {
            this.listaMaterias.Clear();
        }



    }
}

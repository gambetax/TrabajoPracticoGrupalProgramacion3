﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UImoderna1
{
    public partial class frmDocentesGestion : Form
    {
        //MANEJADOR DE EVENTOS PARA LOS CLICK DE LOS BOTONES
        public delegate void mEventosAccion(string accion, int id);
        public event mEventosAccion clickAccion;

        public frmDocentesGestion()
        {
            InitializeComponent();
        }

        public DataGridView getGrid() { return gridUsuarios; }

        private void button1_Click(object sender, EventArgs e)
        {
            clickAccion("agregar", 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = System.Convert.ToInt32(gridUsuarios.Rows[gridUsuarios.SelectedRows[0].Index].Cells[0].Value);

                if (gridUsuarios.SelectedRows.Count > 0 && id > 0)
                {
                    clickAccion("modificar", id);
                }

            }
            catch (Exception err) { Console.WriteLine(err.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = System.Convert.ToInt32(gridUsuarios.Rows[gridUsuarios.SelectedRows[0].Index].Cells[0].Value);

                if (gridUsuarios.SelectedRows.Count > 0 && id > 0)
                {
                    clickAccion("eliminar", id);
                }
            }
            catch (Exception err) { Console.WriteLine(err.Message); }

        }
            

        private void gridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = System.Convert.ToInt32(gridUsuarios.Rows[gridUsuarios.SelectedRows[0].Index].Cells[0].Value);

                if (gridUsuarios.SelectedRows.Count > 0 && id > 0)
                {
                    clickAccion("modificar", id);
                }

            }
            catch (Exception err) { Console.WriteLine(err.Message); }
        }
    }
}

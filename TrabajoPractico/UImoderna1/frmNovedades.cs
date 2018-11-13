using System;
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
    public partial class frmNovedades : Form
    {
        public delegate bool dAccion();
        public event dAccion clickAccion;

        public frmNovedades()
        {
            InitializeComponent();
        }

        public DataGridView getGrid() {
            return gridInforme;
        }
        public void AjustarGrid() {
                gridInforme.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public ComboBox getCmbMateria() { return cmbMateria; }
        public ComboBox getCmbNovedad() { return cmbNovedad; }

        public int getNovedad() { return System.Convert.ToInt32(cmbNovedad.SelectedValue); }
        public int getMateria() { return System.Convert.ToInt32(cmbMateria.SelectedValue); }
        public DateTime getFecha() { return dtpFecha.Value; }
        public string getDescripcion() { return txtDescripcion.Text; }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {            
                if (clickAccion())
                    MessageBox.Show("Agregada!!");
                else
                    MessageBox.Show("No se agrego Novedad.");            
        }
    }
}

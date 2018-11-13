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
    public partial class frmNovedadesHistorial : Form
    {
        public delegate void dAccion();
        public event dAccion clickAccion;

        public frmNovedadesHistorial()
        {
            InitializeComponent();
            //seteamos primer y ultimo dia del mes en curso
            setRango(  new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                       new DateTime(DateTime.Now.Year, DateTime.Now.Month+1,1 ).AddDays(-1)
                     );
        }

        public void setRango( DateTime desde, DateTime hasta ) {
            dtpDesde.Value = desde;
            dtpHasta.Value = hasta;
        }
        public void AjustarGrid()
        {
            gridInforme.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public DateTime getDtpDesde() { return dtpDesde.Value; }
        public DateTime getDtpHasta() { return dtpHasta.Value; }
        public DataGridView getGrid() { return gridInforme; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clickAccion();
        }
    }
}

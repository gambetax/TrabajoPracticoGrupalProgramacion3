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
    public partial class frmMaterias : Form
    {   
        public frmMaterias()
        {
            InitializeComponent();
        }

        public DataGridView getGrid() {
            return gridMaterias;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

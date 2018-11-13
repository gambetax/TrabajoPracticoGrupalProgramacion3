
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
    public partial class frmAcceso : Form
    {
        
        public delegate bool dAccion(string user, string pass);
        public event dAccion clickAccion;


        public frmAcceso()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!clickAccion(txtUser.Text.Trim(), txtPass.Text.Trim()))
            { //el evento es atendido en el controlador, retorna bool
                MessageBox.Show("Credenciales incorrectas!");
                txtUser.SelectAll();
                txtUser.Focus();
            }
            else
                this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }
    }
}

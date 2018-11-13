using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace UImoderna1
{
   

    public partial class frmPrincipal : Form
    {
        //MANEJADOR DE EVENTOS PARA LOS CLICK EN MENU
        public delegate void mEventosMenu(string menu);
        public event mEventosMenu clickMenu;

        public frmPrincipal()
        {
            InitializeComponent();
            setTipoUsuario(1); //por defecto docente
        }

        public void setNombreUsuario(string user) { lblUsuario.Text = user; }

        
        public void setTipoUsuario( int tipo )
        {
            
            switch (tipo)
            {
                case 1: //DOCENTE
                    lblTipoUsuario.Text = "[ DOCENTE ]";
                    btnGestionMaterias.Enabled = false;
                    btnGestionDocentes.Enabled = false;
                    btnHistorialNovedades.Enabled = false;
                    break;
                case 2: //ADMINISTARDOR
                    lblTipoUsuario.Text = "[ ADMINISTARDOR ]";
                    btnGestionMaterias.Enabled = true;
                    btnGestionDocentes.Enabled = true;
                    btnHistorialNovedades.Enabled = false;
                    break;
                case 3: //DIRECTOR
                    lblTipoUsuario.Text = "[ DIRECTOR ]";
                    btnHistorialNovedades.Enabled = true;
                    break;                
            }


        }

        

           
        //BOTONES CERRAR, MAXIMIZAR Y MINIMIZAR. BOTON SALIR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            clickMenu("cerrarSesion");
        }

        //CARGA EL FORMULARIO INICIO AL CARGAR EL PROG.
        private void Form1_Load(object sender,EventArgs e)
        {
            //btnInicio_Click(null, e);
        }

        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMesage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMesage(this.Handle, 0x112, 0xf012, 0);
        }
        //

        //FUNCION
        public void AbrirFormHijo(object FormHijo)
        {
            if (this.lblTipo.Controls.Count > 0)
            {
                this.lblTipo.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.lblTipo.Controls.Add(fh);
            this.lblTipo.Tag = fh;
            fh.Show();
        }

        //BOTON REPORTES
        private void btnReportes_Click(object sender, EventArgs e)
        {
            //SubmenuReportes.Visible = true;
            clickMenu("novedades");

        }
      
       

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new frmMaterias());
            clickMenu("materias");
        }

        

        private void btnConfUsuario_Click(object sender, EventArgs e)
        {
            clickMenu("usuario");
        }

        private void btnGestionDocentes_Click(object sender, EventArgs e)
        {
            clickMenu("gestionDocentes");
        }

        private void btnGestionMaterias_Click(object sender, EventArgs e)
        {
            clickMenu("gestionMaterias");
        }

        private void btnHistorialNovedades_Click(object sender, EventArgs e)
        {
            clickMenu("historialNovedades");
        }
    }



       


}


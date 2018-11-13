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
    public partial class FormDocente : Form
    {
        public delegate void dAccion();
        public event dAccion clickAccion;

        private string modo;

        public FormDocente()
        {
            InitializeComponent();
            this.setMod(); //accion por defecto
        }

        public FormDocente(int id, int idTipo, string nom, string ape, string dni, string email, string user, string pass) : this() {
                        
            setControles(id, idTipo, nom, ape, dni, email, user, pass);
            
        }

        public void setControles(int id, int idTipo, string nom, string ape, string dni, string email, string user, string pass) {
            txtId.Text = id.ToString();
            cmbTipo.SelectedValue = idTipo;
            txtNom.Text = nom;
            txtApellido.Text = ape;
            txtDni.Text = dni;
            txtEmail.Text = email;
            txtUsuario.Text = user;
            txtPass.Text = pass;
        }

        public int getTipo() { return System.Convert.ToInt32(cmbTipo.SelectedValue); }
        public ComboBox getCmbTipo() { return cmbTipo; }
        private void btnAccion_Click(object sender, EventArgs e)
        {            
                clickAccion();
        }

        public void setNuevo() {
            this.Text = lblTitulo.Text = "Nuevo Docente";
            btnAccion.Text = "Registrar Nuevo";
            cmbTipo.Enabled = true;
            resetControles();
            this.modo = "NUEVO";
            
        }
        public void setMod() {
            resetControles();
            this.Text = lblTitulo.Text = "Modificar Docente";
            btnAccion.Text = "Registrar modificacion";
            cmbTipo.Enabled = false;
            this.modo = "MODIFICAR";
        }

        private void resetControles() {
            txtId.Text ="" ;
            cmbTipo.SelectedValue = 1;
            txtNom.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        public string getModo() { return this.modo; }
        public void setModTipo() { cmbTipo.Enabled = true; }

        public int getId() { return System.Convert.ToInt32(txtId.Text); }
        public int getIdTipo() { return System.Convert.ToInt32(cmbTipo.SelectedValue); }
        public string getNombre() { return txtNom.Text; }
        public string getApellido() { return txtApellido.Text; }
        public string getDni() { return txtDni.Text; }
        public string getEmail() { return txtEmail.Text; }
        public string getUser() { return txtUsuario.Text; }
        public string getPass() { return txtPass.Text; }

        private void FormDocente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

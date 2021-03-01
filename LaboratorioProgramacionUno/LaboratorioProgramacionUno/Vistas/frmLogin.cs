using LaboratorioProgramacionUno.Dominio;
using LaboratorioProgramacionUno.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.VIstas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClsEntidades clsEntidad = new ClsEntidades();
            ClsLogin clsLogin = new ClsLogin();
            ClsLoginAdmin clsLoginAdmin = new ClsLoginAdmin();
            Form1 frmMenu = new Form1();
            frmOperaciones _frmOperaciones = new frmOperaciones();

            clsEntidad.User = txtUser.Text;
            clsEntidad.UserPass = txtPass.Text;

            clsEntidad.Admin = txtUser.Text;
            clsEntidad.AdminPass = txtPass.Text;

            int acceder = clsLogin.acceso(clsEntidad);
            //int accederAdmin = clsLoginAdmin.accesoAdmin(clsEntidad);

            if (clsEntidad.Estado == 1)
            {
                if(acceder == 1)
                {
                    MessageBox.Show("Bienvenido " + txtUser.Text);
                    _frmOperaciones.usuarioEstado = txtUser.Text;
                    _frmOperaciones.Show();
                    this.Hide();
                    _frmOperaciones.txtIVA.Enabled = false;
                    _frmOperaciones.txtNombreProducto.Enabled = false;
                }
                
                else if(acceder == 2)
                {
                    MessageBox.Show("Error");
                }
            }

            else if (clsEntidad.Estado == 2)
            {
                if (acceder == 2)
                {
                    MessageBox.Show("Bienvenido " + txtUser.Text.ToString());
                    _frmOperaciones.usuarioEstado = txtUser.Text;
                    _frmOperaciones.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Error");
                }
            }

            else if ((this.txtUser.Text == "") && (this.txtPass.Text == ""))
            {
                MessageBox.Show("Llene los campos");

            }

            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.PerformClick();
            }
        }
    }
}

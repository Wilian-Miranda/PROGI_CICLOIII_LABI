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
            ClsLoginUser clsLogin = new ClsLoginUser();
            ClsLoginAdmin clsLoginAdmin = new ClsLoginAdmin();

            clsEntidad.User = txtUser.Text;
            clsEntidad.UserPass = txtPass.Text;

            clsEntidad.Admin = txtUser.Text;
            clsEntidad.AdminPass = txtPass.Text;

            int accederUser = clsLogin.accesoUser(clsEntidad);
            int accederAdmin = clsLoginAdmin.accesoAdmin(clsEntidad);

            if(accederUser == 1 && accederAdmin == 0)
            {
                MessageBox.Show("Bienvenido " + txtUser.Text.ToString());
            }

            else if (accederAdmin == 1 && accederUser == 0)
            {
                MessageBox.Show("Bienvenido " + txtUser.Text.ToString());
            }

            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}

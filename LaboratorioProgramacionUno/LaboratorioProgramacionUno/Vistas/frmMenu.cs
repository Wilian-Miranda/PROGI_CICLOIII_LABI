using LaboratorioProgramacionUno.VIstas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class Form1 : Form
    {
        frmLogin OfrmLogin = new frmLogin();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            OfrmLogin.Show();
            this.Hide();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            OfrmLogin.Show();
            this.Hide();
        }
    }
}

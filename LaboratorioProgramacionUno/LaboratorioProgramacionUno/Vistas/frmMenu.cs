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
        public Form1()
        {
            InitializeComponent();
        }

        public int estado;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnUsuario_Click(object sender, EventArgs e)
        {
                estado = 1;
                frmLogin frmLoginUser = new frmLogin();
                frmLoginUser.Show();
                this.Hide();
                
        }

        public void btnAdministrador_Click(object sender, EventArgs e)
        {
            estado = 2;
            frmLogin frmLoginAdmin = new frmLogin();
            frmLoginAdmin.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

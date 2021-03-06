﻿using LaboratorioProgramacionUno.Dominio;
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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }


        public string usuarioEstado;
        frmLogin lo = new frmLogin();
        private void frmOperaciones_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioEstado;

            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRA DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRA UN DESUENTO DEL 0.05 ", ">50 and <100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRA UN DESUENTO DEL 0.10 ", ">= 100 and <101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRA UN DESUENTO DEL 0.20 ", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRA UN DESUENTO DEL 0.50 ", ">150");

            if (lo.estadoU== false)
            {
                txtNombreProducto.Text = "LAPTOP";
                txtIVA.Text = "0.13";
                txtCantidad.Text = "1";
                txtPrecioDelProducto.Text = "100";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (((txtIVA.Text == "") || (txtNombreProducto.Text == ""))
                || ((txtPrecioDelProducto.Text == "") || (txtCantidad.Text == "")))
            {
                MessageBox.Show("Información incompleta");
            }
            else
            {
                ClsDescriptorTablaDescuentos datos = new ClsDescriptorTablaDescuentos();

                datos.NombreProducto = txtNombreProducto.Text;
                datos.Iva = Convert.ToDouble(txtIVA.Text);
                datos.Precio = Convert.ToDouble(txtPrecioDelProducto.Text);
                datos.Cantidad = Convert.ToInt32(txtCantidad.Text);


                funcionesTabla(datos);


            }

        }

        private void funcionesTabla(ClsDescriptorTablaDescuentos tablaAtributos)
        {

            Double iva = tablaAtributos.Iva;
            string producto = tablaAtributos.NombreProducto;
            Double precio = tablaAtributos.Precio;
            int cantidad = tablaAtributos.Cantidad;


            if (tablaAtributos.Precio > 0 && tablaAtributos.Precio <= 50)
            {
                lblProductoNombre.Text = producto;
                lblTotalSinIVA.Text = (precio * cantidad).ToString();
                lblIVAaAgregar.Text = ((precio * cantidad) * iva).ToString();
                lblTotalSinDescuentoMasIVA.Text = ((precio * cantidad) + ((precio * cantidad) * iva)).ToString();
                double TotalSinDescuento = ((precio * cantidad) + ((precio * cantidad) * iva));
                lblTotalConDescuento.Text = (TotalSinDescuento - (TotalSinDescuento * 0.0)).ToString();
            }
            else if (tablaAtributos.Precio > 50 && tablaAtributos.Precio < 100)
            {
                lblProductoNombre.Text = producto;
                lblTotalSinIVA.Text = (precio * cantidad).ToString();
                lblIVAaAgregar.Text = ((precio * cantidad) * iva).ToString();
                lblTotalSinDescuentoMasIVA.Text = ((precio * cantidad) + ((precio * cantidad) * iva)).ToString();
                double TotalSinDescuento = ((precio * cantidad) + ((precio * cantidad) * iva));
                lblTotalConDescuento.Text = (TotalSinDescuento - (TotalSinDescuento * 0.05)).ToString();
            }
            else if (tablaAtributos.Precio >= 100 && tablaAtributos.Precio < 101)
            {
                lblProductoNombre.Text = producto;
                lblTotalSinIVA.Text = (precio * cantidad).ToString();
                lblIVAaAgregar.Text = ((precio * cantidad) * iva).ToString();
                lblTotalSinDescuentoMasIVA.Text = ((precio * cantidad) + ((precio * cantidad) * iva)).ToString();
                double TotalSinDescuento = ((precio * cantidad) + ((precio * cantidad) * iva));
                lblTotalConDescuento.Text = (TotalSinDescuento - (TotalSinDescuento * 0.10)).ToString();
            }
            else if (tablaAtributos.Precio >= 101 && tablaAtributos.Precio < 150)
            {
                lblProductoNombre.Text = producto;
                lblTotalSinIVA.Text = (precio * cantidad).ToString();
                lblIVAaAgregar.Text = ((precio * cantidad) * iva).ToString();
                lblTotalSinDescuentoMasIVA.Text = ((precio * cantidad) + ((precio * cantidad) * iva)).ToString();
                double TotalSinDescuento = ((precio * cantidad) + ((precio * cantidad) * iva));
                lblTotalConDescuento.Text = (TotalSinDescuento - (TotalSinDescuento * 0.20)).ToString();
            }
            else
            {
                lblProductoNombre.Text = producto;
                lblTotalSinIVA.Text = (precio * cantidad).ToString();
                lblIVAaAgregar.Text = ((precio * cantidad) * iva).ToString();
                lblTotalSinDescuentoMasIVA.Text = ((precio * cantidad) + ((precio * cantidad) * iva)).ToString();
                double TotalSinDescuento = ((precio * cantidad) + ((precio * cantidad) * iva));
                lblTotalConDescuento.Text = (TotalSinDescuento - (TotalSinDescuento * 0.50)).ToString();
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOperaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcular.PerformClick();
            }
        }
    }
}

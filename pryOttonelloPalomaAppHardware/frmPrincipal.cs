using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOttonelloPalomaAppHardware
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración de Variables
        DateTime VFecha = DateTime.Now;
        string VProducto;
        int VCantidad;
        int VPrecioUnitario;
        int VPrecioFinal;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VFecha = dtpFecha.Value;
            VProducto = cmbProducto.Text;
            VCantidad = Convert.ToInt32(nudCantidad.Value);
            VPrecioFinal = Convert.ToInt32(mtbPrecioUnitario.Text);
            VPrecioFinal = VPrecioUnitario * VCantidad;
           
            lblResultados.Text = VFecha + " " + VProducto + " " + VCantidad + " $" + 
                VPrecioFinal + "\n";
        }

        private void cmbProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                nudCantidad.Enabled = false;
            }
            else
            {
                nudCantidad.Enabled = true;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value == 0)
            {
                mtbPrecioUnitario.Enabled = false;
            }
            else
            {
                mtbPrecioUnitario.Enabled = true;
            }
        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecioUnitario.Text == "") 
            {
                btmRegistrar.Enabled = false;
            }
            else 
            { 
                btmRegistrar.Enabled = true; 
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            cmbProducto.SelectedIndex = -1;
            nudCantidad.Text = "";
            mtbPrecioUnitario.Text = "";

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.Add("CPU");
            cmbProducto.Items.Add("RAM");
            cmbProducto.Items.Add("GUP");
        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }
    }
}

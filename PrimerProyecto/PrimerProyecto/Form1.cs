using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto
{
    public partial class frmVentana1 : Form
    {
        public frmVentana1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 64 || e.KeyChar > 91) && e.KeyChar != 8) && ((e.KeyChar < 96 || e.KeyChar > 123) && e.KeyChar != 8))
                e.Handled = true;
        }

        private void frmVentana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a este primer programa... por favor ingrese sus datos :)");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa...");
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
                txtApellido.BackColor = Color.LightGreen;
            else
                txtApellido.BackColor = Color.Red;
            if (txtNombre.Text != "")
                txtNombre.BackColor = Color.LightGreen;
            else
                txtNombre.BackColor = Color.Red;
            if (txtEdad.Text != "")
                txtEdad.BackColor = Color.LightGreen;
            else
                txtEdad.BackColor = Color.Red;
            if (txtDireccion.Text != "")
                txtDireccion.BackColor = Color.LightGreen;
            else
                txtDireccion.BackColor = Color.Red;
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtEdad.Text != "" && txtNombre.Text != "")
                txtResultado.Text = ("Nombre y apellido: " + txtNombre.Text + " " +txtApellido.Text + Environment.NewLine + "Edad: " + txtEdad.Text + Environment.NewLine + "Su dirección es: " + txtDireccion.Text);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < 31 || e.KeyChar > 123) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }
    }
}

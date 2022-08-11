using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atencion");
            if (txtbxCajaPrincipal.Text == "")
                txtbxCajaPrincipal.BackColor = Color.Red;
            else
                txtbxCajaPrincipal.BackColor = Color.Green;
        }

        private void VentanaPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón izquierdo!");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho!");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del medio!!");
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            lblTitulo.BackColor = Color.Cyan;
            lblTitulo.Cursor = Cursors.Hand;
        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            lblTitulo.Cursor = Cursors.Arrow;
        }

        private void txtbxCajaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbxSecundaria_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtbxSecundaria.Text.Length + " Caracteres.");
        }
    }
}

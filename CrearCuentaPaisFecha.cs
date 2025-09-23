using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class CrearCuentaPaisFecha : Form
    {
        public CrearCuentaPaisFecha()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Seleccionar Panamá por defecto
            Pais.SelectedItem = "Panamá";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logoGS_Click(object sender, EventArgs e)
        {

        }

        private void BotonNext_Click(object sender, EventArgs e)
        {
            CrearCuentaContrasena crearcontrasena = new CrearCuentaContrasena();

            crearcontrasena.Show();
            this.Hide();

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Pais_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CrearCuentaCorreo : Form
    {
        public CrearCuentaCorreo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void títuloIS_Click(object sender, EventArgs e)
        {

        }

        private void fondoGS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonIS_Click(object sender, EventArgs e)
        {
            CrearCuentaNombre f4 = new CrearCuentaNombre();

            f4.Show();

            this.Hide();
        }

        private void textBoxIS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

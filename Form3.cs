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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            Form4 f4 = new Form4();

            f4.Show();

            this.Hide();
        }

        private void textBoxIS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

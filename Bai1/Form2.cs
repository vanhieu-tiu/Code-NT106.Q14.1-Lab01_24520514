using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int max=int.Parse(txtA.Text);
            int min= int.Parse(txtA.Text);
            if (int.Parse(txtB.Text) > max) max = int.Parse(txtB.Text);
            if (int.Parse(txtC.Text) > max) max = int.Parse(txtC.Text);

            if (int.Parse(txtB.Text) < min) min = int.Parse(txtB.Text);
            if (int.Parse(txtC.Text) < min) min = int.Parse(txtC.Text);

            lblSoLonNhat.Text = max + " ";
            lblSoNhoNhat.Text = min + " ";
        }

        private void lblSoLonNhat_Click(object sender, EventArgs e)
        {

        }

        private void lblSoNhoNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblSoLonNhat.Text = "";
            lblSoNhoNhat.Text = "";
            txtA.Text = "";
            txtC.Text = "";
            txtB.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoNguyenA_TextChanged(object sender, EventArgs e)
        {
            string text = txtSoNguyenA.Text;

            if (string.IsNullOrEmpty(text))
                return;

            if (text == "-")
                return;

            int value;
            if (!int.TryParse(text, out value))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoNguyenA.Clear();
            }
        }

        private void txtSoNguyenB_TextChanged(object sender, EventArgs e)
        {
            string text = txtSoNguyenB.Text;

            if (string.IsNullOrEmpty(text))
                return;

            if (text == "-")
                return;

            int value;
            if (!int.TryParse(text, out value))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoNguyenB.Clear();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int Tong;
            Tong=int.Parse(txtSoNguyenA.Text)+ int.Parse(txtSoNguyenB.Text);
            lblKetQua.Text=txtSoNguyenA.Text+" + "+txtSoNguyenB.Text+" = "+Tong + "";
        }
    }
}

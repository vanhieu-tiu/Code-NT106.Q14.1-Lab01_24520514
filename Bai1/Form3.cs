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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Vui lòng nhập một số từ 0 đến 9!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int so;

            if (!int.TryParse(txtA.Text, out so))
            {
                MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng nhập số nguyên.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtA.Clear();
                txtA.Focus();
                return;
            }

            if (so < 0 || so > 9)
            {
                MessageBox.Show("Số nhập vào phải nằm trong khoảng 0 đến 9!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtA.Clear();
                txtA.Focus();
                return;
            }

            switch (so)
            {
                case 0: lblKetQua.Text = "Không"; break;
                case 1: lblKetQua.Text = "Một"; break;
                case 2: lblKetQua.Text = "Hai"; break;
                case 3: lblKetQua.Text = "Ba"; break;
                case 4: lblKetQua.Text = "Bốn"; break;
                case 5: lblKetQua.Text = "Năm"; break;
                case 6: lblKetQua.Text = "Sáu"; break;
                case 7: lblKetQua.Text = "Bảy"; break;
                case 8: lblKetQua.Text = "Tám"; break;
                case 9: lblKetQua.Text = "Chín"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            lblKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

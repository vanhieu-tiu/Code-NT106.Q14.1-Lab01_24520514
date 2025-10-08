using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace Bai1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int A, B;
            if (!int.TryParse(txtA.Text, out A) || !int.TryParse(txtB.Text, out B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            string luaChon = comboBox1.SelectedItem.ToString();
            lblKetQua.Text = ""; // reset trước khi hiển thị

            if (luaChon == "Bảng Cửu Chương")
            {
                int n = B - A;
                lblKetQua.Text = $" Bảng cửu chương của {n}\n";
                for (int i = 1; i <= 10; i++)
                {
                    lblKetQua.Text += $"{n} x {i} = {n * i}\n";
                }
            }
            else if (luaChon == "Tính Toán Các Giá Trị")
            {
                int hieu = A - B;

                // (A-B)!
                BigInteger giaiThua = 1;
                for (int i = 1; i <= hieu; i++)
                    giaiThua *= i;

                // Tổng S = A^1 + A^2 + ... + A^B
                BigInteger tong = 0;
                for (int i = 1; i <= B; i++)
                    tong += BigInteger.Pow(A, i);   

                lblKetQua.Text = $" (A - B)! = {giaiThua}\n";
                lblKetQua.Text += $" Tổng S = {tong}\n";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

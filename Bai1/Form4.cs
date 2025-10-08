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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string input = txtA.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(input, out long number))
            {
                MessageBox.Show("Chuỗi nhập vào phải là số nguyên!");
                return;
            }

            if (input.Length != 12)
            {
                MessageBox.Show("Bạn phải nhập chính xác 12 chữ số!");
                return;
            }

            lblKetQua.Text = DocSo(number);
        }

        private string DocSo(long number)
        {
            if (number == 0) return "Không";

            string[] donVi = { "", "nghìn", "triệu", "tỷ" };
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string ketQua = "";
            int donViIndex = 0;

            while (number > 0)
            {
                int block = (int)(number % 1000);
                if (block > 0)
                {
                    string blockText = DocBaChuSo(block, chuSo);
                    ketQua = blockText + " " + donVi[donViIndex] + " " + ketQua;
                }
                number /= 1000;
                donViIndex++;
            }

            return ketQua.Trim();
        }

        private string DocBaChuSo(int number, string[] chuSo)
        {
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donvi = number % 10;

            string result = "";

            if (tram > 0)
            {
                result += chuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0)
                    result += " linh";
            }

            if (chuc > 0)
            {
                if (chuc == 1)
                    result += " mười";
                else
                    result += " " + chuSo[chuc] + " mươi";
            }

            if (donvi > 0)
            {
                if (chuc == 0 && tram == 0)
                    result += chuSo[donvi];
                else if (donvi == 1 && chuc > 1)
                    result += " mốt";
                else if (donvi == 5 && chuc > 0)
                    result += " lăm";
                else
                    result += " " + chuSo[donvi];
            }

            return result.Trim();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            lblKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

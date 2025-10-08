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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhCung_Click(object sender, EventArgs e)
        {
            int day, month;
            string zodiac = "";

            // Lấy dữ liệu từ textbox
            if (!int.TryParse(txtA.Text, out day) || !int.TryParse(txtB.Text, out month))
            {
                lblKetQua.Text = "Vui lòng nhập số hợp lệ!";
                return;
            }

            switch (month)
            {
                case 1:
                    if (day <= 19) zodiac = "Ma Kết";
                    else zodiac = "Bảo Bình";
                    break;
                case 2:
                    if (day <= 18) zodiac = "Bảo Bình";
                    else zodiac = "Song Ngư";
                    break;
                case 3:
                    if (day <= 20) zodiac = "Song Ngư";
                    else zodiac = "Bạch Dương";
                    break;
                case 4:
                    if (day <= 20) zodiac = "Bạch Dương";
                    else zodiac = "Kim Ngưu";
                    break;
                case 5:
                    if (day <= 21) zodiac = "Kim Ngưu";
                    else zodiac = "Song Tử";
                    break;
                case 6:
                    if (day <= 21) zodiac = "Song Tử";
                    else zodiac = "Cự Giải";
                    break;
                case 7:
                    if (day <= 22) zodiac = "Cự Giải";
                    else zodiac = "Sư Tử";
                    break;
                case 8:
                    if (day <= 22) zodiac = "Sư Tử";
                    else zodiac = "Xử Nữ";
                    break;
                case 9:
                    if (day <= 23) zodiac = "Xử Nữ";
                    else zodiac = "Thiên Bình";
                    break;
                case 10:
                    if (day <= 23) zodiac = "Thiên Bình";
                    else zodiac = "Thần Nông";
                    break;
                case 11:
                    if (day <= 22) zodiac = "Thần Nông";
                    else zodiac = "Nhân Mã";
                    break;
                case 12:
                    if (day <= 21) zodiac = "Nhân Mã";
                    else zodiac = "Ma Kết";
                    break;
                default:
                    lblKetQua.Text = "Tháng không hợp lệ!";
                    return;
            }

            lblKetQua.Text = "Cung hoàng đạo của bạn là: " + zodiac;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

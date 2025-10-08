using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        string hoTen;
        List<double> diem = new List<double>();

        private bool XuLyInput()
        {
            string input = txtA.Text?.Trim();
            if (string.IsNullOrEmpty(input)) return false;

            // Tách chuỗi theo dấu phẩy
            string[] parts = input.Split(',');

            if (parts.Length < 2) return false; // phải có ít nhất 1 dấu phẩy (tên + điểm)

            // Lấy họ tên
            hoTen = parts[0].Trim();

            diem.Clear();

            // Các phần còn lại là điểm
            for (int i = 1; i < parts.Length; i++)
            {
                string token = parts[i].Trim();

                // Chỉ chấp nhận số với dấu chấm
                double value;
                if (!double.TryParse(token, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
                {
                    return false; // sai format
                }
                diem.Add(value);
            }

            return true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
            {
                double tb = diem.Average();
                lblKetQua.Text = "Điểm trung bình: " + tb.ToString("0.00");
            }
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
            {
                int soDau = diem.Count(d => d >= 5);
                lblKetQua.Text = "Số môn đậu: " + soDau;
            }
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTenSinhVien_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
                lblKetQua.Text = "Họ và tên: " + hoTen;
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void btnDanhSachDiem_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
            {
                string kq = "Danh sách điểm: ";
                for (int i = 0; i < diem.Count; i++)
                {
                    kq += $"Môn {i + 1}: {diem[i]}  ";
                }
                lblKetQua.Text = kq;
            }
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void btnDiemCaoNhat_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
                lblKetQua.Text = "Điểm cao nhất: " + diem.Max();
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void btnDiemThapNhat_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
                lblKetQua.Text = "Điểm thấp nhất: " + diem.Min();
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void btnSoMonKhongDau_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
            {
                int soRot = diem.Count(d => d < 5);
                lblKetQua.Text = "Số môn không đậu: " + soRot;
            }
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (XuLyInput())
            {
                double tb = diem.Average();
                int soRot = diem.Count(d => d < 5);
                string xl = "";

                if (tb >= 8 && diem.All(d => d >= 6.5))
                    xl = "Giỏi";
                else if (tb >= 6.5 && soRot == 0)
                    xl = "Khá";
                else if (tb >= 5 && soRot == 0)
                    xl = "Trung bình";
                else if (tb >= 3.5 && soRot <= 2)
                    xl = "Yếu";
                else
                    xl = "Kém";

                lblKetQua.Text = "Xếp loại: " + xl;
            }
            else
                lblKetQua.Text = "Dữ liệu nhập sai format!";
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
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

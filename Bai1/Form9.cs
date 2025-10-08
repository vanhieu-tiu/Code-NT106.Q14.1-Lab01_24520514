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
    public partial class Form9 : Form
    {
        List<string> dsMonAn = new List<string>
        {
            "Cơm tấm",
            "Bún bò",
            "Phở",
        };

        public Form9()
        {
            InitializeComponent();
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            listBox1.Items.Clear();
            foreach (var mon in dsMonAn)
                listBox1.Items.Add(mon);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = txtMonMoi.Text.Trim();

            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập món ăn!");
                return;
            }

            if (dsMonAn.Contains(monMoi, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Món này đã có trong danh sách!");
                return;
            }

            dsMonAn.Add(monMoi);
            HienThiDanhSach();
            txtMonMoi.Clear();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!");
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(dsMonAn.Count);
            string monAnHomNay = dsMonAn[index];

            lblKetQua.Text = "Hôm nay bạn nên ăn: " + monAnHomNay;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!");
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(dsMonAn.Count);
            string monAnHomNay = dsMonAn[index];

            lblKetQua.Text = "Hôm nay bạn nên ăn: " + monAnHomNay;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMonMoi.Text = "";
            lblKetQua.Text = "";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string monMoi = txtMonMoi.Text.Trim();

            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập món ăn!");
                return;
            }

            if (dsMonAn.Contains(monMoi, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Món này đã có trong danh sách!");
                return;
            }

            dsMonAn.Add(monMoi);
            HienThiDanhSach();
            txtMonMoi.Clear();
        }
    }
}

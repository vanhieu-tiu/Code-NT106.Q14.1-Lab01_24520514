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
    public partial class Form5 : Form
    {
        Dictionary<string, (int giaChuan, List<int> phong)> dsPhim = new Dictionary<string, (int, List<int>)>();

        Dictionary<string, string> loaiGhe = new Dictionary<string, string>();

        HashSet<string> gheDaBan = new HashSet<string>();
        public Form5()
        {
            InitializeComponent();
            KhoiTaoData();
            LoadComboPhim();
            LoadLoaiGhe();
        }

        private void KhoiTaoData()
        {
            dsPhim.Add("Đào, phở và piano", (45000, new List<int> { 1, 2, 3 }));
            dsPhim.Add("Mai", (100000, new List<int> { 2, 3 }));
            dsPhim.Add("Gặp lại chị bầu", (70000, new List<int> { 1 }));
            dsPhim.Add("Tarot", (90000, new List<int> { 3 }));
        }

        private void LoadComboPhim()
        {
            cboChonPhim.DataSource = dsPhim.Keys.ToList();
            cboChonPhim.SelectedIndex = -1; 
            cboChonPhong.SelectedIndex = -1;
        }

        private void LoadLoaiGhe()
        {
           
            foreach (string g in new[] { "A1", "A5", "C1", "C5" }) loaiGhe[g] = "Vot";
            
            foreach (string g in new[] { "A2", "A3", "A4", "C2", "C3", "C4" }) loaiGhe[g] = "Thuong";
            
            foreach (string g in new[] { "B2", "B3", "B4" }) loaiGhe[g] = "VIP";
           
            foreach (string g in new[] { "B1", "B5" }) loaiGhe[g] = "Chuan";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonPhim.SelectedIndex == -1) return;
            string phim = cboChonPhim.SelectedItem.ToString();
            cboChonPhong.DataSource = dsPhim[phim].phong;
            cboChonPhong.SelectedIndex = -1;
        }

        private List<CheckBox> GetAllCheckBoxes(Control parent)
        {
            List<CheckBox> list = new List<CheckBox>();
            foreach (Control c in parent.Controls)
            {
                if (c is CheckBox cb)
                    list.Add(cb);
                if (c.HasChildren)
                    list.AddRange(GetAllCheckBoxes(c));
            }
            return list;
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string sdt = txtSoDienThoai.Text;

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập họ tên và số điện thoại!");
                return;
            }

            string phim = cboChonPhim.SelectedItem.ToString();
            int giaChuan = dsPhim[phim].giaChuan;
            int phong = int.Parse(cboChonPhong.SelectedItem.ToString());

            List<string> gheChon = new List<string>();
            foreach (CheckBox chk in GetAllCheckBoxes(this))
            {
                if (chk.Checked) gheChon.Add(chk.Text);
            }

            if (gheChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế!");
                return;
            }

            if (gheChon.Count > 2)
            {
                MessageBox.Show("Không được chọn quá 2 ghế!");
                return;
            }

            foreach (string g in gheChon)
            {
                if (gheDaBan.Contains(g))
                {
                    MessageBox.Show($"Ghế {g} đã bán, vui lòng chọn ghế khác!");
                    return;
                }
            }

            int tongTien = 0;
            foreach (string g in gheChon)
            {
                int gia = giaChuan;
                if (loaiGhe[g] == "Vot") gia = giaChuan / 4;
                else if (loaiGhe[g] == "Thuong") gia = giaChuan / 2;
                else if (loaiGhe[g] == "VIP") gia = giaChuan * 2;

                tongTien += gia;
                gheDaBan.Add(g); 
            }

            lblKetQua.Text =
                $"Khách hàng: {ten}\n" +
                $"SĐT: {sdt}\n" +
                $"Phim: {phim}\n" +
                $"Phòng: {phong}\n" +
                $"Ghế: {string.Join(", ", gheChon)}\n" +
                $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSoDienThoai.Text = "";
            cboChonPhim.Text = "";
            cboChonPhong.Text = "";

            lblKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

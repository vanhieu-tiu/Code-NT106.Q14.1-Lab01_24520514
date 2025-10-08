namespace Bai1
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnTenSinhVien = new System.Windows.Forms.Button();
            this.btnDanhSachDiem = new System.Windows.Forms.Button();
            this.btnDiemTrungBinh = new System.Windows.Forms.Button();
            this.btnDiemCaoNhat = new System.Windows.Forms.Button();
            this.btnDiemThapNhat = new System.Windows.Forms.Button();
            this.btnSoMonDau = new System.Windows.Forms.Button();
            this.btnSoMonKhongDau = new System.Windows.Forms.Button();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Thông Tin:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(304, 45);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(510, 27);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            // 
            // btnTenSinhVien
            // 
            this.btnTenSinhVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenSinhVien.Location = new System.Drawing.Point(135, 125);
            this.btnTenSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTenSinhVien.Name = "btnTenSinhVien";
            this.btnTenSinhVien.Size = new System.Drawing.Size(129, 47);
            this.btnTenSinhVien.TabIndex = 2;
            this.btnTenSinhVien.Text = "Tên Sinh Viên";
            this.btnTenSinhVien.UseVisualStyleBackColor = true;
            this.btnTenSinhVien.Click += new System.EventHandler(this.btnTenSinhVien_Click);
            // 
            // btnDanhSachDiem
            // 
            this.btnDanhSachDiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachDiem.Location = new System.Drawing.Point(432, 125);
            this.btnDanhSachDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachDiem.Name = "btnDanhSachDiem";
            this.btnDanhSachDiem.Size = new System.Drawing.Size(129, 47);
            this.btnDanhSachDiem.TabIndex = 3;
            this.btnDanhSachDiem.Text = "Danh Sách Điểm";
            this.btnDanhSachDiem.UseVisualStyleBackColor = true;
            this.btnDanhSachDiem.Click += new System.EventHandler(this.btnDanhSachDiem_Click);
            // 
            // btnDiemTrungBinh
            // 
            this.btnDiemTrungBinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemTrungBinh.Location = new System.Drawing.Point(731, 125);
            this.btnDiemTrungBinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiemTrungBinh.Name = "btnDiemTrungBinh";
            this.btnDiemTrungBinh.Size = new System.Drawing.Size(129, 47);
            this.btnDiemTrungBinh.TabIndex = 4;
            this.btnDiemTrungBinh.Text = "Điểm Trung Bình";
            this.btnDiemTrungBinh.UseVisualStyleBackColor = true;
            this.btnDiemTrungBinh.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDiemCaoNhat
            // 
            this.btnDiemCaoNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemCaoNhat.Location = new System.Drawing.Point(44, 210);
            this.btnDiemCaoNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiemCaoNhat.Name = "btnDiemCaoNhat";
            this.btnDiemCaoNhat.Size = new System.Drawing.Size(129, 47);
            this.btnDiemCaoNhat.TabIndex = 5;
            this.btnDiemCaoNhat.Text = "Điểm Cao Nhất";
            this.btnDiemCaoNhat.UseVisualStyleBackColor = true;
            this.btnDiemCaoNhat.Click += new System.EventHandler(this.btnDiemCaoNhat_Click);
            // 
            // btnDiemThapNhat
            // 
            this.btnDiemThapNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemThapNhat.Location = new System.Drawing.Point(234, 210);
            this.btnDiemThapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiemThapNhat.Name = "btnDiemThapNhat";
            this.btnDiemThapNhat.Size = new System.Drawing.Size(129, 47);
            this.btnDiemThapNhat.TabIndex = 6;
            this.btnDiemThapNhat.Text = "Điểm Thấp Nhất";
            this.btnDiemThapNhat.UseVisualStyleBackColor = true;
            this.btnDiemThapNhat.Click += new System.EventHandler(this.btnDiemThapNhat_Click);
            // 
            // btnSoMonDau
            // 
            this.btnSoMonDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoMonDau.Location = new System.Drawing.Point(432, 210);
            this.btnSoMonDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoMonDau.Name = "btnSoMonDau";
            this.btnSoMonDau.Size = new System.Drawing.Size(129, 47);
            this.btnSoMonDau.TabIndex = 7;
            this.btnSoMonDau.Text = "Số Môn Đậu";
            this.btnSoMonDau.UseVisualStyleBackColor = true;
            this.btnSoMonDau.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSoMonKhongDau
            // 
            this.btnSoMonKhongDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoMonKhongDau.Location = new System.Drawing.Point(623, 210);
            this.btnSoMonKhongDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoMonKhongDau.Name = "btnSoMonKhongDau";
            this.btnSoMonKhongDau.Size = new System.Drawing.Size(129, 47);
            this.btnSoMonKhongDau.TabIndex = 8;
            this.btnSoMonKhongDau.Text = "Số Không Đậu";
            this.btnSoMonKhongDau.UseVisualStyleBackColor = true;
            this.btnSoMonKhongDau.Click += new System.EventHandler(this.btnSoMonKhongDau_Click);
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.Location = new System.Drawing.Point(841, 210);
            this.btnXepLoai.Margin = new System.Windows.Forms.Padding(4);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(129, 47);
            this.btnXepLoai.TabIndex = 9;
            this.btnXepLoai.Text = "Xếp Loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kết Quả: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKetQua.Location = new System.Drawing.Point(318, 367);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(234, 66);
            this.lblKetQua.TabIndex = 11;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(574, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 47);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(289, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 47);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(997, 469);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.btnSoMonKhongDau);
            this.Controls.Add(this.btnSoMonDau);
            this.Controls.Add(this.btnDiemThapNhat);
            this.Controls.Add(this.btnDiemCaoNhat);
            this.Controls.Add(this.btnDiemTrungBinh);
            this.Controls.Add(this.btnDanhSachDiem);
            this.Controls.Add(this.btnTenSinhVien);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnTenSinhVien;
        private System.Windows.Forms.Button btnDanhSachDiem;
        private System.Windows.Forms.Button btnDiemTrungBinh;
        private System.Windows.Forms.Button btnDiemCaoNhat;
        private System.Windows.Forms.Button btnDiemThapNhat;
        private System.Windows.Forms.Button btnSoMonDau;
        private System.Windows.Forms.Button btnSoMonKhongDau;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
    }
}
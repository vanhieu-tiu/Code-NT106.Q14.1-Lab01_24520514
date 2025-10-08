namespace Bai1
{
    partial class Form1
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
            this.lblSoNguyenA = new System.Windows.Forms.Label();
            this.lblSoNguyenB = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoNguyenA = new System.Windows.Forms.TextBox();
            this.txtSoNguyenB = new System.Windows.Forms.TextBox();
            this.lblHienThiKetQua = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoNguyenA
            // 
            this.lblSoNguyenA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSoNguyenA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyenA.Location = new System.Drawing.Point(25, 186);
            this.lblSoNguyenA.Name = "lblSoNguyenA";
            this.lblSoNguyenA.Size = new System.Drawing.Size(281, 49);
            this.lblSoNguyenA.TabIndex = 0;
            this.lblSoNguyenA.Text = "Nhập số nguyên a:";
            this.lblSoNguyenA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoNguyenB
            // 
            this.lblSoNguyenB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSoNguyenB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyenB.Location = new System.Drawing.Point(24, 256);
            this.lblSoNguyenB.Name = "lblSoNguyenB";
            this.lblSoNguyenB.Size = new System.Drawing.Size(282, 49);
            this.lblSoNguyenB.TabIndex = 1;
            this.lblSoNguyenB.Text = "Nhập số nguyên b:";
            this.lblSoNguyenB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(210, 341);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(108, 44);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(426, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoNguyenA
            // 
            this.txtSoNguyenA.Location = new System.Drawing.Point(353, 204);
            this.txtSoNguyenA.Name = "txtSoNguyenA";
            this.txtSoNguyenA.Size = new System.Drawing.Size(429, 22);
            this.txtSoNguyenA.TabIndex = 2;
            this.txtSoNguyenA.TextChanged += new System.EventHandler(this.txtSoNguyenA_TextChanged);
            // 
            // txtSoNguyenB
            // 
            this.txtSoNguyenB.Location = new System.Drawing.Point(353, 274);
            this.txtSoNguyenB.Name = "txtSoNguyenB";
            this.txtSoNguyenB.Size = new System.Drawing.Size(430, 22);
            this.txtSoNguyenB.TabIndex = 3;
            this.txtSoNguyenB.TextChanged += new System.EventHandler(this.txtSoNguyenB_TextChanged);
            // 
            // lblHienThiKetQua
            // 
            this.lblHienThiKetQua.AutoSize = true;
            this.lblHienThiKetQua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiKetQua.ForeColor = System.Drawing.Color.White;
            this.lblHienThiKetQua.Location = new System.Drawing.Point(102, 69);
            this.lblHienThiKetQua.Name = "lblHienThiKetQua";
            this.lblHienThiKetQua.Size = new System.Drawing.Size(127, 32);
            this.lblHienThiKetQua.TabIndex = 5;
            this.lblHienThiKetQua.Text = "Kết quả: ";
            this.lblHienThiKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHienThiKetQua.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Yellow;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(270, 60);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(360, 52);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblHienThiKetQua);
            this.Controls.Add(this.txtSoNguyenB);
            this.Controls.Add(this.txtSoNguyenA);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblSoNguyenB);
            this.Controls.Add(this.lblSoNguyenA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tổng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoNguyenA;
        private System.Windows.Forms.Label lblSoNguyenB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoNguyenA;
        private System.Windows.Forms.TextBox txtSoNguyenB;
        private System.Windows.Forms.Label lblHienThiKetQua;
        private System.Windows.Forms.Label lblKetQua;
    }
}


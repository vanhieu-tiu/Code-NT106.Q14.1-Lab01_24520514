namespace Bai1
{
    partial class Form2
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHTSoLonNhat = new System.Windows.Forms.Label();
            this.lblHTSoNhoNhat = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblSoLonNhat = new System.Windows.Forms.Label();
            this.lblSoNhoNhat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(34, 71);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(109, 19);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Số Thứ Nhất: ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(261, 71);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(97, 19);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Số Thứ Hai:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(488, 71);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(90, 19);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "Số Thứ Ba:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(129, 187);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 41);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(332, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(534, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHTSoLonNhat
            // 
            this.lblHTSoLonNhat.AutoSize = true;
            this.lblHTSoLonNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTSoLonNhat.Location = new System.Drawing.Point(80, 358);
            this.lblHTSoLonNhat.Name = "lblHTSoLonNhat";
            this.lblHTSoLonNhat.Size = new System.Drawing.Size(109, 19);
            this.lblHTSoLonNhat.TabIndex = 9;
            this.lblHTSoLonNhat.Text = "Số Lớn Nhất: ";
            // 
            // lblHTSoNhoNhat
            // 
            this.lblHTSoNhoNhat.AutoSize = true;
            this.lblHTSoNhoNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTSoNhoNhat.Location = new System.Drawing.Point(425, 355);
            this.lblHTSoNhoNhat.Name = "lblHTSoNhoNhat";
            this.lblHTSoNhoNhat.Size = new System.Drawing.Size(106, 19);
            this.lblHTSoNhoNhat.TabIndex = 11;
            this.lblHTSoNhoNhat.Text = "Số Nhỏ Nhất:";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtA.Location = new System.Drawing.Point(149, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(88, 22);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtB.Location = new System.Drawing.Point(364, 68);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(88, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtC.Location = new System.Drawing.Point(584, 68);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(88, 22);
            this.txtC.TabIndex = 5;
            this.txtC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSoLonNhat
            // 
            this.lblSoLonNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSoLonNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLonNhat.Location = new System.Drawing.Point(227, 344);
            this.lblSoLonNhat.Name = "lblSoLonNhat";
            this.lblSoLonNhat.Size = new System.Drawing.Size(99, 47);
            this.lblSoLonNhat.TabIndex = 10;
            this.lblSoLonNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoLonNhat.Click += new System.EventHandler(this.lblSoLonNhat_Click);
            // 
            // lblSoNhoNhat
            // 
            this.lblSoNhoNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSoNhoNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNhoNhat.Location = new System.Drawing.Point(572, 344);
            this.lblSoNhoNhat.Name = "lblSoNhoNhat";
            this.lblSoNhoNhat.Size = new System.Drawing.Size(107, 47);
            this.lblSoNhoNhat.TabIndex = 12;
            this.lblSoNhoNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoNhoNhat.Click += new System.EventHandler(this.lblSoNhoNhat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(744, 482);
            this.Controls.Add(this.lblSoNhoNhat);
            this.Controls.Add(this.lblSoLonNhat);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblHTSoNhoNhat);
            this.Controls.Add(this.lblHTSoLonNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Min, Max";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHTSoLonNhat;
        private System.Windows.Forms.Label lblHTSoNhoNhat;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblSoLonNhat;
        private System.Windows.Forms.Label lblSoNhoNhat;
    }
}
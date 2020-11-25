namespace QLLopHoc
{
    partial class frmSinhVien
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
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtDiaChiSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLopHoc = new System.Windows.Forms.ComboBox();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnTimKiemDC = new System.Windows.Forms.Button();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.btnTimKiemTuoi = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(69, 35);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(183, 20);
            this.txtTenSV.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(69, 9);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(183, 20);
            this.txtMaSV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã SV";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(69, 86);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(183, 20);
            this.txtTuoi.TabIndex = 11;
            // 
            // txtDiaChiSV
            // 
            this.txtDiaChiSV.Location = new System.Drawing.Point(69, 60);
            this.txtDiaChiSV.Name = "txtDiaChiSV";
            this.txtDiaChiSV.Size = new System.Drawing.Size(183, 20);
            this.txtDiaChiSV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã lớp";
            // 
            // cmbLopHoc
            // 
            this.cmbLopHoc.FormattingEnabled = true;
            this.cmbLopHoc.Location = new System.Drawing.Point(69, 111);
            this.cmbLopHoc.Name = "cmbLopHoc";
            this.cmbLopHoc.Size = new System.Drawing.Size(183, 21);
            this.cmbLopHoc.TabIndex = 13;
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Location = new System.Drawing.Point(466, 63);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(117, 23);
            this.btnSuaSV.TabIndex = 14;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = true;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(466, 34);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(117, 23);
            this.btnXoaSV.TabIndex = 15;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(466, 5);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(117, 23);
            this.btnThemSV.TabIndex = 16;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(15, 154);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(568, 237);
            this.dgvSinhVien.TabIndex = 17;
            // 
            // btnTimKiemDC
            // 
            this.btnTimKiemDC.Location = new System.Drawing.Point(267, 60);
            this.btnTimKiemDC.Name = "btnTimKiemDC";
            this.btnTimKiemDC.Size = new System.Drawing.Size(117, 23);
            this.btnTimKiemDC.TabIndex = 16;
            this.btnTimKiemDC.Text = "Tìm kiếm";
            this.btnTimKiemDC.UseVisualStyleBackColor = true;
            this.btnTimKiemDC.Click += new System.EventHandler(this.btnTimKiemDC_Click);
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.Location = new System.Drawing.Point(267, 111);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(117, 23);
            this.btnTimKiemLop.TabIndex = 16;
            this.btnTimKiemLop.Text = "Tìm kiếm";
            this.btnTimKiemLop.UseVisualStyleBackColor = true;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // btnTimKiemTuoi
            // 
            this.btnTimKiemTuoi.Location = new System.Drawing.Point(267, 86);
            this.btnTimKiemTuoi.Name = "btnTimKiemTuoi";
            this.btnTimKiemTuoi.Size = new System.Drawing.Size(117, 23);
            this.btnTimKiemTuoi.TabIndex = 16;
            this.btnTimKiemTuoi.Text = "Tìm kiếm";
            this.btnTimKiemTuoi.UseVisualStyleBackColor = true;
            this.btnTimKiemTuoi.Click += new System.EventHandler(this.btnTimKiemTuoi_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(466, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 407);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnTimKiemLop);
            this.Controls.Add(this.btnTimKiemTuoi);
            this.Controls.Add(this.btnTimKiemDC);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.cmbLopHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtDiaChiSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtDiaChiSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLopHoc;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTimKiemDC;
        private System.Windows.Forms.Button btnTimKiemLop;
        private System.Windows.Forms.Button btnTimKiemTuoi;
        private System.Windows.Forms.Button btnRefresh;
    }
}
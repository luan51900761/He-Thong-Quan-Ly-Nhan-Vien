﻿
namespace QuanLyNhanSu.ListForm
{
    partial class PhongBan
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
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbSoNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenPB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(166, 116);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(324, 22);
            this.txtMaPB.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(166, 175);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(324, 22);
            this.txtTen.TabIndex = 12;
            // 
            // lbSoNV
            // 
            this.lbSoNV.AutoSize = true;
            this.lbSoNV.Location = new System.Drawing.Point(813, 135);
            this.lbSoNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoNV.Name = "lbSoNV";
            this.lbSoNV.Size = new System.Drawing.Size(46, 17);
            this.lbSoNV.TabIndex = 7;
            this.lbSoNV.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Phòng Ban";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(919, 245);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(759, 245);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(605, 245);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgPhongBan
            // 
            this.dgPhongBan.AllowUserToAddRows = false;
            this.dgPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPB,
            this.SoNV});
            this.dgPhongBan.Location = new System.Drawing.Point(51, 304);
            this.dgPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgPhongBan.Name = "dgPhongBan";
            this.dgPhongBan.ReadOnly = true;
            this.dgPhongBan.RowHeadersWidth = 51;
            this.dgPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhongBan.Size = new System.Drawing.Size(1027, 244);
            this.dgPhongBan.TabIndex = 6;
            this.dgPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhongBan_CellClick);
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.FillWeight = 150F;
            this.MaPB.HeaderText = "Mã Phòng Ban";
            this.MaPB.MinimumWidth = 6;
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            this.MaPB.Width = 125;
            // 
            // TenPB
            // 
            this.TenPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.HeaderText = "Tên Phòng Ban";
            this.TenPB.MinimumWidth = 6;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // SoNV
            // 
            this.SoNV.DataPropertyName = "SoNV";
            this.SoNV.FillWeight = 150F;
            this.SoNV.HeaderText = "Số Nhân Vên";
            this.SoNV.MinimumWidth = 6;
            this.SoNV.Name = "SoNV";
            this.SoNV.ReadOnly = true;
            this.SoNV.Width = 125;
            // 
            // lbTenPB
            // 
            this.lbTenPB.AutoSize = true;
            this.lbTenPB.Location = new System.Drawing.Point(810, 80);
            this.lbTenPB.Name = "lbTenPB";
            this.lbTenPB.Size = new System.Drawing.Size(49, 17);
            this.lbTenPB.TabIndex = 13;
            this.lbTenPB.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "PHÒNG BAN";
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbSoNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhongBan";
            this.ShowIcon = false;
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbSoNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNV;
        private System.Windows.Forms.Label lbTenPB;
        private System.Windows.Forms.Label label2;
    }
}
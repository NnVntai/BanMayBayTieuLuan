
namespace banvemaybay.GUI
{
    partial class CHUYENBAY
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
            this.txtmachuyenbay = new System.Windows.Forms.TextBox();
            this.txtthoigian = new System.Windows.Forms.TextBox();
            this.dpngaygio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btchi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.lvchuyenbay = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btthoat = new System.Windows.Forms.Button();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsanbayden = new System.Windows.Forms.ComboBox();
            this.cbsanbaydi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmachuyenbay
            // 
            this.txtmachuyenbay.Location = new System.Drawing.Point(209, 82);
            this.txtmachuyenbay.Name = "txtmachuyenbay";
            this.txtmachuyenbay.Size = new System.Drawing.Size(200, 20);
            this.txtmachuyenbay.TabIndex = 0;
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(209, 157);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.Size = new System.Drawing.Size(200, 20);
            this.txtthoigian.TabIndex = 1;
            // 
            // dpngaygio
            // 
            this.dpngaygio.Location = new System.Drawing.Point(209, 243);
            this.dpngaygio.Name = "dpngaygio";
            this.dpngaygio.Size = new System.Drawing.Size(200, 20);
            this.dpngaygio.TabIndex = 2;
            this.dpngaygio.ValueChanged += new System.EventHandler(this.dpngaygio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Chuyến Bay ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời Gian Bay ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Bay ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btthem.Location = new System.Drawing.Point(108, 378);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Them";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btchi
            // 
            this.btchi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btchi.Location = new System.Drawing.Point(278, 378);
            this.btchi.Name = "btchi";
            this.btchi.Size = new System.Drawing.Size(75, 23);
            this.btchi.TabIndex = 7;
            this.btchi.Text = "ghi";
            this.btchi.UseVisualStyleBackColor = false;
            this.btchi.Click += new System.EventHandler(this.btchi_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btxoa.Location = new System.Drawing.Point(634, 378);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xoa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btcapnhat.Location = new System.Drawing.Point(472, 378);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(75, 23);
            this.btcapnhat.TabIndex = 9;
            this.btcapnhat.Text = "Cap Nhat";
            this.btcapnhat.UseVisualStyleBackColor = false;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // lvchuyenbay
            // 
            this.lvchuyenbay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvchuyenbay.HideSelection = false;
            this.lvchuyenbay.Location = new System.Drawing.Point(87, 458);
            this.lvchuyenbay.Name = "lvchuyenbay";
            this.lvchuyenbay.Size = new System.Drawing.Size(699, 143);
            this.lvchuyenbay.TabIndex = 10;
            this.lvchuyenbay.UseCompatibleStateImageBehavior = false;
            this.lvchuyenbay.View = System.Windows.Forms.View.Details;
            this.lvchuyenbay.SelectedIndexChanged += new System.EventHandler(this.lvchuyenbay_SelectedIndexChanged);
            this.lvchuyenbay.Click += new System.EventHandler(this.lvchuyenbay_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ma Chuyen Bay";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngay Gio";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thoi gian Bay";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gia";
            this.columnHeader10.Width = 118;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SanBay Den";
            this.columnHeader11.Width = 124;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "San Bay Di";
            this.columnHeader12.Width = 143;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btthoat.Location = new System.Drawing.Point(826, 578);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 11;
            this.btthoat.Text = "Thoat";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(209, 314);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(200, 20);
            this.txtgia.TabIndex = 12;
            this.txtgia.Leave += new System.EventHandler(this.txtgia_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbsanbayden
            // 
            this.cbsanbayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbsanbayden.FormattingEnabled = true;
            this.cbsanbayden.Location = new System.Drawing.Point(736, 155);
            this.cbsanbayden.Name = "cbsanbayden";
            this.cbsanbayden.Size = new System.Drawing.Size(177, 25);
            this.cbsanbayden.TabIndex = 14;
            // 
            // cbsanbaydi
            // 
            this.cbsanbaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbsanbaydi.FormattingEnabled = true;
            this.cbsanbaydi.Location = new System.Drawing.Point(517, 157);
            this.cbsanbaydi.Name = "cbsanbaydi";
            this.cbsanbaydi.Size = new System.Drawing.Size(163, 25);
            this.cbsanbaydi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(459, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đi Từ ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(686, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đến ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "QUẢN LÝ CHUYẾN BAY ";
            // 
            // CHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::banvemaybay.Properties.Resources._222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 613);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbsanbaydi);
            this.Controls.Add(this.cbsanbayden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.lvchuyenbay);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btchi);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpngaygio);
            this.Controls.Add(this.txtthoigian);
            this.Controls.Add(this.txtmachuyenbay);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "CHUYENBAY";
            this.Text = "CHUYENBAY";
            this.Load += new System.EventHandler(this.CHUYENBAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmachuyenbay;
        private System.Windows.Forms.TextBox txtthoigian;
        private System.Windows.Forms.DateTimePicker dpngaygio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btchi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.ListView lvchuyenbay;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsanbayden;
        private System.Windows.Forms.ComboBox cbsanbaydi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label7;
    }
}
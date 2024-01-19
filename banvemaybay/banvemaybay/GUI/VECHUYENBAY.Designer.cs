
namespace banvemaybay.GUI
{
    partial class VECHUYENBAY
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
            this.txmachuyenbay = new System.Windows.Forms.TextBox();
            this.cbhangve = new System.Windows.Forms.ComboBox();
            this.cbchuyenbay = new System.Windows.Forms.ComboBox();
            this.CBKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTTHEM = new System.Windows.Forms.Button();
            this.BTGHI = new System.Windows.Forms.Button();
            this.BTXOA = new System.Windows.Forms.Button();
            this.BTCAPNHAT = new System.Windows.Forms.Button();
            this.BTTHOAT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txmachuyenbay
            // 
            this.txmachuyenbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txmachuyenbay.Location = new System.Drawing.Point(180, 42);
            this.txmachuyenbay.Name = "txmachuyenbay";
            this.txmachuyenbay.Size = new System.Drawing.Size(172, 26);
            this.txmachuyenbay.TabIndex = 0;
            this.txmachuyenbay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbhangve
            // 
            this.cbhangve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhangve.FormattingEnabled = true;
            this.cbhangve.Location = new System.Drawing.Point(608, 51);
            this.cbhangve.Name = "cbhangve";
            this.cbhangve.Size = new System.Drawing.Size(172, 28);
            this.cbhangve.TabIndex = 1;
            // 
            // cbchuyenbay
            // 
            this.cbchuyenbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchuyenbay.FormattingEnabled = true;
            this.cbchuyenbay.Location = new System.Drawing.Point(180, 118);
            this.cbchuyenbay.Name = "cbchuyenbay";
            this.cbchuyenbay.Size = new System.Drawing.Size(172, 28);
            this.cbchuyenbay.TabIndex = 1;
            // 
            // CBKH
            // 
            this.CBKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBKH.FormattingEnabled = true;
            this.CBKH.Location = new System.Drawing.Point(608, 118);
            this.CBKH.Name = "CBKH";
            this.CBKH.Size = new System.Drawing.Size(172, 28);
            this.CBKH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Vé Chuyến Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Chuyến Bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hạng Vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 313);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(860, 149);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma Ve Chuyen Bay";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAKH";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ma chuyen Bay";
            this.columnHeader3.Width = 266;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ma Hang Ve";
            this.columnHeader4.Width = 213;
            // 
            // BTTHEM
            // 
            this.BTTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTHEM.Location = new System.Drawing.Point(36, 204);
            this.BTTHEM.Name = "BTTHEM";
            this.BTTHEM.Size = new System.Drawing.Size(84, 40);
            this.BTTHEM.TabIndex = 10;
            this.BTTHEM.Text = "THEM";
            this.BTTHEM.UseVisualStyleBackColor = true;
            this.BTTHEM.Click += new System.EventHandler(this.BTTHEM_Click);
            // 
            // BTGHI
            // 
            this.BTGHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGHI.Location = new System.Drawing.Point(158, 206);
            this.BTGHI.Name = "BTGHI";
            this.BTGHI.Size = new System.Drawing.Size(92, 37);
            this.BTGHI.TabIndex = 11;
            this.BTGHI.Text = "GHI";
            this.BTGHI.UseVisualStyleBackColor = true;
            this.BTGHI.Click += new System.EventHandler(this.BTGHI_Click);
            // 
            // BTXOA
            // 
            this.BTXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXOA.Location = new System.Drawing.Point(326, 204);
            this.BTXOA.Name = "BTXOA";
            this.BTXOA.Size = new System.Drawing.Size(87, 39);
            this.BTXOA.TabIndex = 12;
            this.BTXOA.Text = "XOA";
            this.BTXOA.UseVisualStyleBackColor = true;
            this.BTXOA.Click += new System.EventHandler(this.BTXOA_Click);
            // 
            // BTCAPNHAT
            // 
            this.BTCAPNHAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCAPNHAT.Location = new System.Drawing.Point(494, 207);
            this.BTCAPNHAT.Name = "BTCAPNHAT";
            this.BTCAPNHAT.Size = new System.Drawing.Size(105, 37);
            this.BTCAPNHAT.TabIndex = 13;
            this.BTCAPNHAT.Text = "CAP NHAT";
            this.BTCAPNHAT.UseVisualStyleBackColor = true;
            this.BTCAPNHAT.Click += new System.EventHandler(this.BTCAPNHAT_Click);
            // 
            // BTTHOAT
            // 
            this.BTTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTHOAT.Location = new System.Drawing.Point(663, 207);
            this.BTTHOAT.Name = "BTTHOAT";
            this.BTTHOAT.Size = new System.Drawing.Size(102, 37);
            this.BTTHOAT.TabIndex = 14;
            this.BTTHOAT.Text = "THOAT";
            this.BTTHOAT.UseVisualStyleBackColor = true;
            this.BTTHOAT.Click += new System.EventHandler(this.BTTHOAT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quản Lý Vé Chuyến Bay";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(786, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 277);
            this.listBox1.TabIndex = 16;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // VECHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 492);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTTHOAT);
            this.Controls.Add(this.BTCAPNHAT);
            this.Controls.Add(this.BTXOA);
            this.Controls.Add(this.BTGHI);
            this.Controls.Add(this.BTTHEM);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBKH);
            this.Controls.Add(this.cbchuyenbay);
            this.Controls.Add(this.cbhangve);
            this.Controls.Add(this.txmachuyenbay);
            this.Name = "VECHUYENBAY";
            this.Text = "VECHUYENBAY";
            this.Load += new System.EventHandler(this.VECHUYENBAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txmachuyenbay;
        private System.Windows.Forms.ComboBox cbhangve;
        private System.Windows.Forms.ComboBox cbchuyenbay;
        private System.Windows.Forms.ComboBox CBKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BTTHEM;
        private System.Windows.Forms.Button BTGHI;
        private System.Windows.Forms.Button BTXOA;
        private System.Windows.Forms.Button BTCAPNHAT;
        private System.Windows.Forms.Button BTTHOAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}
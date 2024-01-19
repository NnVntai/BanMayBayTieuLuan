
namespace banvemaybay.GUI
{
    partial class DATVE
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tre = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbchuyenbay = new System.Windows.Forms.ComboBox();
            this.cbsodienthoat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbhangve = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btthem = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Machuyenbayla = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 452);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 178);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma phieu Dat cho";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ma Chuyen Bay";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ten Khach Hang";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HangVe";
            this.columnHeader4.Width = 151;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngay Dat";
            this.columnHeader5.Width = 259;
            // 
            // tre
            // 
            this.tre.Location = new System.Drawing.Point(681, 390);
            this.tre.Name = "tre";
            this.tre.Size = new System.Drawing.Size(269, 240);
            this.tre.TabIndex = 1;
            this.tre.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 266);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(195, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cbchuyenbay
            // 
            this.cbchuyenbay.FormattingEnabled = true;
            this.cbchuyenbay.Location = new System.Drawing.Point(195, 122);
            this.cbchuyenbay.Name = "cbchuyenbay";
            this.cbchuyenbay.Size = new System.Drawing.Size(200, 21);
            this.cbchuyenbay.TabIndex = 4;
            // 
            // cbsodienthoat
            // 
            this.cbsodienthoat.FormattingEnabled = true;
            this.cbsodienthoat.Location = new System.Drawing.Point(195, 190);
            this.cbsodienthoat.Name = "cbsodienthoat";
            this.cbsodienthoat.Size = new System.Drawing.Size(200, 21);
            this.cbsodienthoat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Phiếu Đặt Chỗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Chuyến Bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(23, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(83, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hạng Vé";
            // 
            // cbhangve
            // 
            this.cbhangve.FormattingEnabled = true;
            this.cbhangve.Location = new System.Drawing.Point(195, 258);
            this.cbhangve.Name = "cbhangve";
            this.cbhangve.Size = new System.Drawing.Size(200, 21);
            this.cbhangve.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(74, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày Đặt ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(27, 381);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(83, 32);
            this.btthem.TabIndex = 15;
            this.btthem.Text = "Them";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btghi
            // 
            this.btghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btghi.Location = new System.Drawing.Point(128, 381);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(91, 32);
            this.btghi.TabIndex = 16;
            this.btghi.Text = "GHI";
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(252, 381);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(90, 34);
            this.btxoa.TabIndex = 17;
            this.btxoa.Text = "XOA";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Location = new System.Drawing.Point(381, 381);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(88, 34);
            this.btcapnhat.TabIndex = 18;
            this.btcapnhat.Text = "SUA";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(516, 381);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(82, 35);
            this.btthoat.TabIndex = 19;
            this.btthoat.Text = "THOAT";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(122, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quản Lý Khách Hàng Đặt Vé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(530, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Danh Sách Khách  Đã Đặt Chuyến Bay ";
            // 
            // Machuyenbayla
            // 
            this.Machuyenbayla.AutoSize = true;
            this.Machuyenbayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Machuyenbayla.Location = new System.Drawing.Point(851, 20);
            this.Machuyenbayla.Name = "Machuyenbayla";
            this.Machuyenbayla.Size = new System.Drawing.Size(53, 20);
            this.Machuyenbayla.TabIndex = 22;
            this.Machuyenbayla.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(677, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Hiển thị chuyến bay ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(12, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hiển  thị Thông tin  chi tiết vé đặt";
            // 
            // DATVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::banvemaybay.Properties.Resources.ve_may_bay_gia_re;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(987, 669);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Machuyenbayla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btghi);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbhangve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsodienthoat);
            this.Controls.Add(this.cbchuyenbay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tre);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Name = "DATVE";
            this.Text = "DATVE";
            this.Load += new System.EventHandler(this.DATVE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView tre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbchuyenbay;
        private System.Windows.Forms.ComboBox cbsodienthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbhangve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btghi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Machuyenbayla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
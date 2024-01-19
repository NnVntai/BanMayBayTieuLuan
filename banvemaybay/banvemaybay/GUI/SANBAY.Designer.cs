
namespace banvemaybay.GUI
{
    partial class SANBAY
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
            this.txMaSanBay = new System.Windows.Forms.TextBox();
            this.txTenSanBay = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txMaSanBay
            // 
            this.txMaSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMaSanBay.Location = new System.Drawing.Point(304, 37);
            this.txMaSanBay.Name = "txMaSanBay";
            this.txMaSanBay.Size = new System.Drawing.Size(212, 26);
            this.txMaSanBay.TabIndex = 0;
            // 
            // txTenSanBay
            // 
            this.txTenSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTenSanBay.Location = new System.Drawing.Point(304, 93);
            this.txTenSanBay.Name = "txTenSanBay";
            this.txTenSanBay.Size = new System.Drawing.Size(212, 26);
            this.txTenSanBay.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(69, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(657, 153);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma San Bay";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten San Bay";
            this.columnHeader2.Width = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sân Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Sân Bay";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(69, 199);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(91, 26);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(212, 199);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(98, 26);
            this.btGhi.TabIndex = 6;
            this.btGhi.Text = "GHI";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(367, 199);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 26);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(514, 199);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(102, 26);
            this.btCapNhat.TabIndex = 8;
            this.btCapNhat.Text = "Cap Nhat";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(665, 199);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(87, 26);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // SANBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::banvemaybay.Properties.Resources.photo_1_15858767016252034736476;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txTenSanBay);
            this.Controls.Add(this.txMaSanBay);
            this.Name = "SANBAY";
            this.Text = "SANBAY";
            this.Load += new System.EventHandler(this.SANBAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMaSanBay;
        private System.Windows.Forms.TextBox txTenSanBay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
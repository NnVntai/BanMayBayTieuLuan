
namespace banvemaybay.GUI
{
    partial class VAITRO
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
            this.txmavaitro = new System.Windows.Forms.TextBox();
            this.txtenvaitro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btthem = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.bbtcapnhat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txmavaitro
            // 
            this.txmavaitro.Location = new System.Drawing.Point(226, 64);
            this.txmavaitro.Name = "txmavaitro";
            this.txmavaitro.ReadOnly = true;
            this.txmavaitro.Size = new System.Drawing.Size(168, 20);
            this.txmavaitro.TabIndex = 0;
            // 
            // txtenvaitro
            // 
            this.txtenvaitro.Location = new System.Drawing.Point(226, 123);
            this.txtenvaitro.Name = "txtenvaitro";
            this.txtenvaitro.Size = new System.Drawing.Size(168, 20);
            this.txtenvaitro.TabIndex = 1;
            this.txtenvaitro.TextChanged += new System.EventHandler(this.txtenvaitro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ma Vai Tro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten Vai Tro";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(420, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 196);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaVaiTro";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten Vai Tro";
            this.columnHeader2.Width = 180;
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(59, 214);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(92, 35);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "them";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btghi
            // 
            this.btghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btghi.Location = new System.Drawing.Point(213, 214);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(103, 35);
            this.btghi.TabIndex = 6;
            this.btghi.Text = "ghi";
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(372, 214);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(86, 35);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // bbtcapnhat
            // 
            this.bbtcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtcapnhat.Location = new System.Drawing.Point(519, 214);
            this.bbtcapnhat.Name = "bbtcapnhat";
            this.bbtcapnhat.Size = new System.Drawing.Size(85, 35);
            this.bbtcapnhat.TabIndex = 8;
            this.bbtcapnhat.Text = "cap nhat";
            this.bbtcapnhat.UseVisualStyleBackColor = true;
            this.bbtcapnhat.Click += new System.EventHandler(this.bbtcapnhat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(669, 214);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(86, 35);
            this.btthoat.TabIndex = 9;
            this.btthoat.Text = "thoat";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quản Lý Vai Trò ";
            // 
            // VAITRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bbtcapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btghi);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtenvaitro);
            this.Controls.Add(this.txmavaitro);
            this.Name = "VAITRO";
            this.Text = "VAITRO";
            this.Load += new System.EventHandler(this.VAITRO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txmavaitro;
        private System.Windows.Forms.TextBox txtenvaitro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btghi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bbtcapnhat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label3;
    }
}
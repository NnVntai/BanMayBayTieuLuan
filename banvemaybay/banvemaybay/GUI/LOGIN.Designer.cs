
namespace banvemaybay.GUI
{
    partial class LOGIN
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
            this.txsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btdangky = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txsdt
            // 
            this.txsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txsdt.Location = new System.Drawing.Point(311, 150);
            this.txsdt.Name = "txsdt";
            this.txsdt.Size = new System.Drawing.Size(182, 26);
            this.txsdt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txmatkhau
            // 
            this.txmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txmatkhau.Location = new System.Drawing.Point(311, 208);
            this.txmatkhau.Name = "txmatkhau";
            this.txmatkhau.Size = new System.Drawing.Size(182, 26);
            this.txmatkhau.TabIndex = 3;
            this.txmatkhau.UseSystemPasswordChar = true;
            this.txmatkhau.TextChanged += new System.EventHandler(this.txmatkhau_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(221, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN Bán Vé Máy Bay ";
            // 
            // btdangky
            // 
            this.btdangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.Location = new System.Drawing.Point(90, 293);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(133, 34);
            this.btdangky.TabIndex = 5;
            this.btdangky.Text = "Đăng Ký";
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(582, 293);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(133, 34);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.Location = new System.Drawing.Point(341, 262);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(132, 36);
            this.btdangnhap.TabIndex = 7;
            this.btdangnhap.Text = "Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::banvemaybay.Properties.Resources._104_1041474_png_keys_locks_transparent_hnh_nh_ci_kha;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txsdt);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangnhap;
    }
}
using banvemaybay.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class LOGIN : Form
    {

        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = USERDAO.TT_DANGNHAP(txsdt.Text, txmatkhau.Text);


            if (dt.Rows.Count > 0)
            {
                string ten = dt.Rows[0][4].ToString();
                string mahk = dt.Rows[0][0].ToString();

                if (dt.Rows[0]["MAVAITRO"].ToString() == "VT001")
                {
                    GUIQUANLY F = new GUIQUANLY(ten);
                    F.Show();
                    this.Hide();



                }
                else
                {
                    GUIUSER F = new GUIUSER(ten, mahk, txsdt.Text);
                    F.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("NGUOI DUNG NHAP SAI MAT KHAU");
            }

        }


        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            DANGKY F = new DANGKY();
            F.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banvemaybay.DAO;
using banvemaybay.DTO;
using banvemaybay.BUS;



namespace banvemaybay.GUI
{
    public partial class QUYDINH : Form
    {
        public QUYDINH()
        {
            InitializeComponent();
        }
        public void tt_quydinh()
        {
            DataTable dt = new DataTable();

            dt = QUYDINHDAO.TT_QUYDINH();
            if (dt.Rows.Count > 0)
            {
                NUSLSANBAY.Value = Convert.ToInt32(dt.Rows[0]["SOLUONGSANBAY"].ToString());
                NUSLSANBAYTRUNGIAN.Value = Convert.ToInt32(dt.Rows[0]["SOSANBAYTOIDA"].ToString());
                TXBAYTOITHIEU.Text = dt.Rows[0]["THOIGIANBAYTOITHIEU"].ToString();
                TXDUNGTOITHIEU.Text = dt.Rows[0]["THOIGIANDUNGTOITHIEU"].ToString();
                TXDUNGTOIDA.Text = dt.Rows[0]["THOIGIANDUNGTOIDA"].ToString();
                TXCHAMDATVE.Text = dt.Rows[0]["THOIGIANCHAMNHATDATVE"].ToString();
                TXCHAMHUYVE.Text = dt.Rows[0]["THOIGIANCHAMNHATHUYVE"].ToString();
            }
        }
        private void QUYDINH_Load(object sender, EventArgs e)
        {
            tt_quydinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QUYDINHDTO qd = new QUYDINHDTO();
            qd.SOLUONGSANBAY = Convert.ToString(NUSLSANBAY.Value);
            qd.SOSANBAYTOIDA = Convert.ToString(NUSLSANBAYTRUNGIAN.Value);
            qd.THOIGIANBAYTOITHIEU = TXBAYTOITHIEU.Text;
            qd.THOIGIANCHAMNHATDATVE = TXCHAMDATVE.Text;
            qd.THOIGIANCHAMNHATHUYVE = TXCHAMHUYVE.Text;
            qd.THOIGIANDUNGTOIDA = TXDUNGTOIDA.Text;
            qd.THOIGIANDUNGTOITHIEU = TXDUNGTOITHIEU.Text;
            QUYDINHBUS.CapNhat_quyDinh(qd);
            tt_quydinh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

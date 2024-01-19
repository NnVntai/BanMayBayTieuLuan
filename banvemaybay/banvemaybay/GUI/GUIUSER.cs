using banvemaybay.DAO;
using banvemaybay.GUIRP;
using System;
using System.Data;
using System.Windows.Forms;
using banvemaybay.BUS;
using banvemaybay.DTO;
namespace banvemaybay.GUI
{
    public partial class GUIUSER : Form
    {
        string mmahk;
        string ssdt;
        public void XOATUDONG()
        {
            DataTable dt = new DataTable();
            DATCHODDTO dc = new DATCHODDTO();
            dt = DATVEDAO.tt_XOADAT_VE_QUYDINH(DateTime.Now.ToString());
            int soluong = dt.Rows.Count;
            string[] a=new string[soluong];
            if( soluong>0)
            { 
                MessageBox.Show("so phieu dat het han da huy "+soluong);
                for(int i=0;i<soluong;i++)
                {
                    a[i] = dt.Rows[i][0].ToString();
                }
                for(int i=0;i<soluong;i++)
                {
                    MessageBox.Show(dt.Rows[i][0].ToString());
                    dc.MaPhieuDatCho = a[i];
                    DATCHOBUS.Xoa_DATCHO(dc);
                }
               
            }
        }
        public GUIUSER(string ten, string mahk, string sdt)
        {


            InitializeComponent();
            label2.Text = ten;
            ssdt = sdt;
            mmahk = mahk;

        }
        public void tt_USERDATVE()
        {
            LOGIN F = new LOGIN();
            DataTable dt = new DataTable();
            dt = DATVEDAO.tt_HIEMTHIQUAUSER(mmahk);
            dataGridView1.DataSource = dt;

        }
        public void tt_USERmuave()
        {
            LOGIN F = new LOGIN();
            DataTable dt = new DataTable();
            dt = VECHUYENBAYDAO.tt_hiemthivemua(mmahk);
            dataGridView2.DataSource = dt;

        }

        private void GUIUSER_Load(object sender, EventArgs e)
        {
            LOGIN F = new LOGIN();
            tt_USERDATVE();
            tt_USERmuave();
            XOATUDONG();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LOGIN F = new LOGIN();
            F.Show();
            this.Hide();

        }

        private void dATVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATCHOCHUYENBAY F = new DATCHOCHUYENBAY(label2.Text, mmahk, ssdt);
            F.ShowDialog();
        }

        private void vECHUYENBAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MUAVECHUYENBAY F = new MUAVECHUYENBAY(label2.Text, mmahk, ssdt);
            F.ShowDialog();
        }

        private void qUANLYTHONGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THAYDOITHONGTIN F = new THAYDOITHONGTIN(ssdt, mmahk);
            F.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DATVERF F = new DATVERF(mmahk);
            F.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VECHUYENBAYRF f = new VECHUYENBAYRF(mmahk);
            f.ShowDialog();
        }

        private void dANHSACHCHUYENBAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DANHSACHCHUYENBAYRF DT = new DANHSACHCHUYENBAYRF();
            DT.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

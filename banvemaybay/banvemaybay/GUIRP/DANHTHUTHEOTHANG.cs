using banvemaybay.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUIRP
{
    public partial class DANHTHUTHEOTHANG : Form
    {
        int tthang;
        public DANHTHUTHEOTHANG(int thang)
        {
            InitializeComponent();
            tthang = thang;
        }

        private void DANHTHUTHEOTHANG_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.doanhthuthang(tthang);
            RF.DANHTHUTHANG CRY = new RF.DANHTHUTHANG();
            CRY.SetDataSource(dt);
            crystalReportViewer1.ReportSource = CRY;

        }
    }
}

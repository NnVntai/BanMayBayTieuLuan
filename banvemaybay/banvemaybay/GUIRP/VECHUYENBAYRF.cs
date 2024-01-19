using banvemaybay.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUIRP
{
    public partial class VECHUYENBAYRF : Form
    {
        string mkh;
        public VECHUYENBAYRF(string a)
        {
            InitializeComponent();
            mkh = a;
        }

        private void VECHUYENBAYRF_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = VECHUYENBAYDAO.TT_RP(mkh);
            RF.VECHUYENBAY cry = new RF.VECHUYENBAY();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;

        }
    }
}

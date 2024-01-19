using banvemaybay.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUIRP
{
    public partial class DANHSACHCHUYENBAYRF : Form
    {
        public DANHSACHCHUYENBAYRF()
        {
            InitializeComponent();
        }

        private void DANHSACHCHUYENBAYRF_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.TT_RF();
            RF.DANHSACHCHUYENBAY cry = new RF.DANHSACHCHUYENBAY();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}

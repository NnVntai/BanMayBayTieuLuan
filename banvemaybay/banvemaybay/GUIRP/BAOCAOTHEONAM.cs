using banvemaybay.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUIRP
{
    public partial class BAOCAOTHEONAM : Form
    {
        int nnam;
        public BAOCAOTHEONAM(int nam)
        {
            InitializeComponent();
            nnam = nam;
        }

        private void BAOCAOTHEONAM_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.doanhthuNAM(nnam);
            RF.BAOCAOTHEONAM cry = new RF.BAOCAOTHEONAM();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;


        }
    }
}

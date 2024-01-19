using banvemaybay.DAO;
using banvemaybay.RF;
using System;
using System.Data;
using System.Windows.Forms;
namespace banvemaybay.GUIRP
{
    public partial class DATVERF : Form
    {
        string makh;
        public DATVERF(string n)
        {
            InitializeComponent();
            makh = n;
        }

        private void DATVE_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = DATVEDAO.TT_RP(makh);
            DATVEMAYBAY cry = new DATVEMAYBAY();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}

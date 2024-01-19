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

namespace banvemaybay.GUI
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
           TimeSpan da = TimeSpan.Parse(dt.Rows[0]["THOIGIANCHAMNHATHUYVE"].ToString());
           DateTime b = DateTime.Parse(DateTime.Now.ToString());
            DateTime s = b - da;
            

                MessageBox.Show(s.ToString());
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class report : Form
    {
        Database db = null;
        string mkh;
        string maphong;
        float giadien = 1;
        float gianuoc = 1;
        public report(Database db, string mkh, string maphong)
        {
            InitializeComponent();
            this.db = db;
            this.mkh = mkh;
            this.maphong = maphong;
            var table0 = db.getData($"SELECT tenphong,giatienphong FROM phongtro WHERE maphong = '{maphong}' ");
            var table1 = db.getData($"SELECT tennguoithue FROM nguoithuetro WHERE manguoithue = '{mkh}' ");
            var table2 = db.getData($"SELECT chisodiencu,chisodienmoi,chisonuoccu,chisonuocmoi FROM sodiennuoc WHERE maphong = '{maphong}' ");


            this.rdlcBindingSource.DataSource = new rdlc()
            {
                manguoithuetro = mkh,
                maphong = maphong,
                tenphong = table0.Rows[0]["tenphong"].ToString(),
                tienphong = int.Parse(table0.Rows[0]["giatienphong"].ToString()),
                nguoithuetro = table1.Rows[0]["tennguoithue"].ToString(),
                thang_nam = DateTime.Today.ToString("MM-yyyy"),
                sodiencu = int.Parse(table2.Rows[0]["chisodiencu"].ToString()),
                sodienmoi = int.Parse(table2.Rows[0]["chisodienmoi"].ToString()),
                sonuoccu = int.Parse(table2.Rows[0]["chisonuoccu"].ToString()),
                sonuocmoi = int.Parse(table2.Rows[0]["chisonuocmoi"].ToString()),
                thanhtienDien = giadien * (int.Parse(table2.Rows[0]["chisodienmoi"].ToString()) - int.Parse(table2.Rows[0]["chisodiencu"].ToString())),
                thanhtienNuoc = gianuoc * (int.Parse(table2.Rows[0]["chisonuocmoi"].ToString()) - int.Parse(table2.Rows[0]["chisonuoccu"].ToString())),
                giadien = giadien,
                gianuoc = gianuoc,
            };
        }

        private void report_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}

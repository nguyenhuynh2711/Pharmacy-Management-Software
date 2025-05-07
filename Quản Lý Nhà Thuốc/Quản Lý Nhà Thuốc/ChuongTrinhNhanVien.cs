using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class ChuongTrinhNhanVien : Form
    {
        public ChuongTrinhNhanVien()
        {
            InitializeComponent();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            Thuoc frmThuoc = new Thuoc(panelChuongTrinhQuanLy);
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            DonThuoc frmThuoc = new DonThuoc(panelChuongTrinhQuanLy);
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }
    }
}

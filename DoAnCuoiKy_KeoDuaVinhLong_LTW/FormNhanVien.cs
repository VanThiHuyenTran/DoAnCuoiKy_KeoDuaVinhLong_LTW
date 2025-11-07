using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy_KeoDuaVinhLong_LTW
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangDataContext db = new QuanLyCuaHangDataContext();
            var dsNhanVien = from nv in db.NhanViens
                             select nv;
            BangNhanVien.DataSource = dsNhanVien.ToList();
        }

        private void nutTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void ThanhTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void nutThem_Click(object sender, EventArgs e)
        {

        }

        private void nutXoa_Click(object sender, EventArgs e)
        {

        }

        private void nutSua_Click(object sender, EventArgs e)
        {

        }
    }
}

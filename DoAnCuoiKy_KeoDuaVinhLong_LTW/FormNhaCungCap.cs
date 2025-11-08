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
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangDataContext db = new QuanLyCuaHangDataContext();
            var dsNhaCungCap = from ncc in db.NhaCungCaps
                               select ncc;
            BangNhaCungCap.DataSource = dsNhaCungCap.ToList();
        }
        private void BangNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

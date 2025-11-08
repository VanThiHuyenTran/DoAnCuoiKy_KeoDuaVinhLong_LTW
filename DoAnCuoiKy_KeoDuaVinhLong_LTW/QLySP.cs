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
    public partial class QLySP : Form
    {
        public QLySP()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLySP_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangDataContext db = new QuanLyCuaHangDataContext();
            var dsSanPham = from nv in db.SanPhams
                             select nv;
            BangSP.DataSource = dsSanPham.ToList();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void BangSP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

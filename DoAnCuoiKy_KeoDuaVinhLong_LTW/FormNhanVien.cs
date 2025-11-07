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
        private QuanLyThaoTac quanLy = new QuanLyThaoTac();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private QuanLyThaoTac NhanVien = new QuanLyThaoTac();
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
            if (BangNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo");
                return;
            }

            NhanVien selectedNhanVien = (NhanVien)BangNhanVien.CurrentRow.DataBoundItem;

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa '{selectedNhanVien.HoTen}'?",
                                               "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                bool result = quanLy.XoaNhanVien(selectedNhanVien.MaNhanVien);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    var currentList = (List<NhanVien>)BangNhanVien.DataSource;
                    currentList.Remove(selectedNhanVien);
                    //tai lai bang sau khi xoa
                    BangNhanVien.DataSource = null;
                    BangNhanVien.DataSource = currentList;
                }
            }
        }

        private void nutSua_Click(object sender, EventArgs e)
        {

        }
    }
}

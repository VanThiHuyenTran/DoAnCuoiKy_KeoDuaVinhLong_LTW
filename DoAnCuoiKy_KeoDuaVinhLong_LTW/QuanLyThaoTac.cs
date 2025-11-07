using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy_KeoDuaVinhLong_LTW
{
    public class QuanLyThaoTac
    {
        private QuanLyCuaHangDataContext db;

        public QuanLyThaoTac()
        {
            db = new QuanLyCuaHangDataContext();
        }
        public List<NhanVien> LoadNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public bool XoaNhanVien(string maNV)
        {
            try
            {
                NhanVien nv = db.NhanViens.SingleOrDefault(v => v.MaNhanVien == maNV);

                if (nv != null)
                {
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại! Lỗi: " + ex.Message, "Lỗi");
                return false;
            }
        }

        public bool SuaNhanVien(string maNV, string hoTen, string sdt, string diaChi, string tenDN, string maQuyen)
        {
            try
            {
                NhanVien nv = db.NhanViens.SingleOrDefault(v => v.MaNhanVien == maNV);
                if (nv != null)
                {
                    nv.HoTen = hoTen;
                    nv.SoDienThoai = sdt;
                    nv.DiaChi = diaChi;
                    nv.TenDangNhap = tenDN;
                    nv.MaQuyen = maQuyen;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại! Lỗi: " + ex.Message, "Lỗi");
                return false;
            }
        }
    }
}
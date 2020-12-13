using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QLBaiXe;
using System.Data;

namespace DAL_QLBaiXe
{
    public class DAL_NhanVien
    {
        DBConnect con = new DBConnect();
        public string kiemtra(string manv)
        {
            return con.loadLabel("SELECT COUNT(*) FROM NHANVIEN WHERE MaNV ='" + manv + "'");
        }
        public void themNV(BUS_QLBaiXe.BUS_NhanVien nv)
        {
            con.ExcuteNonQuery("INSERT INTO NHANVIEN VALUES ('"+ nv.maNV + "', '" + nv.matKhau + "',N'" + nv.hoTen 
                                                             + "', '" + nv.CMND + "',N'" + nv.diaChi + "', '" + nv.SDT + "')");
        }
        public void xoaNV(BUS_QLBaiXe.BUS_NhanVien nv)
        {
            con.ExcuteNonQuery("DELETE NHANVIEN WHERE MaNV = '" + nv.maNV + "'");
        }
        public void suaNV(BUS_QLBaiXe.BUS_NhanVien nv)
        {
            con.ExcuteNonQuery("UPDATE NHANVIEN set HoTen = N'" + nv.hoTen + "', CMND ='" + nv.CMND + "', DiaChi = '" + nv.diaChi
                                + "',SDT = '" + nv.SDT + "' where manv = '" + nv.maNV + "'" );
        }
        public void doiMK(BUS_QLBaiXe.BUS_NhanVien nv)
        {
            con.ExcuteNonQuery("update NHANVIEN set matkhau='" + nv.matKhau + "' where manv='" + nv.maNV + "'");
        }
        public DataTable data(string ID)
        {
            string query = @"SELECT MaNV, HoTen, CMND, DiaChi, Sdt FROM NHANVIEN";
            return con.createTable(query);
        }
    }
}

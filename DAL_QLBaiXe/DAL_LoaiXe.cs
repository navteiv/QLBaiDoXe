using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_QLBaiXe
{
    public class DAL_LoaiXe
    {
        DBConnect con = new DBConnect();
        public string kiemtra(string ma)
        {
            return con.loadLabel("Select count(*) from LOAIXE where maloai=N'" + ma + "'");
        }
        public void themmoiloaixe(BUS_QLBaiXe.BUS_LoaiXe lx)
        {
            con.ExcuteNonQuery("INSERT into LOAIXE values('" + lx.maLoai + "',N'" + lx.loaiXe + "','" + lx.giaTien + "')");
        }
        public void xoaloaixe(BUS_QLBaiXe.BUS_LoaiXe lx)
        {
            con.ExcuteNonQuery("DELETE LOAIXE where maloai='" + lx.maLoai + "'");
        }
        public void sualoaixe(BUS_QLBaiXe.BUS_LoaiXe lx)
        {
            con.ExcuteNonQuery("update LOAIXE set loaixe=N'" + lx.loaiXe + "',giatien='" + lx.giaTien + "' where maloai='" + lx.maLoai + "'");
        }
        public DataTable data()
        {
            return con.createTable("SELECT * FROM LOAIXE");
        }
    }
}

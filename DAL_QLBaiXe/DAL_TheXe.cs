using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_QLBaiXe
{
    public class DAL_TheXe
    {
        DBConnect connect = new DBConnect();
        public string kiemtra(string mathe)
        {
            return connect.loadLabel("SELECT COUNT(*) FROM THE WHERE SoThe = '" + mathe + "'");
        }
        public void themThe(BUS_QLBaiXe.BUS_The the)
        {
            connect.ExcuteNonQuery("INSERT INTO THE VALUES('" + the.soThe + "', '" + the.ngayDK + "', '" + the.ngayKT + "', N'" + the.tinhTrang + "')");
        }
        public void xoaThe(BUS_QLBaiXe.BUS_The the)
        {
            connect.ExcuteNonQuery("DELETE THE WHERE SoThe = '" + the.soThe + "'");
        }
        public void suaThe(BUS_QLBaiXe.BUS_The the)
        {
            connect.ExcuteNonQuery("UPDATE THE SET NgayDk = '" + the.ngayDK + "', NgayKT = '" + the.ngayKT + "', TinhTrang = N'" 
                                    + the.tinhTrang + "' WHERE SoThe = '" + the.soThe + "'");
        }
        public DataTable data()
        {
            string query = "SELECT * FROM THE";
            return connect.createTable(query);
        }
    }
}

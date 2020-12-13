using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QLBaiXe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBaiXe
{
    public class DAL_XeRaVao
    {
        DBConnect con = new DBConnect();

        SqlConnection _conSql = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public void XeVao (BUS_XeRaVao dt)
        {
            _conSql = con.getConnect();
            _conSql.Open();
            cmd = new SqlCommand("XeVao", _conSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayGioVao", SqlDbType.DateTime).Value = dt.ngayGioVao;
            cmd.Parameters.Add("@maloai", SqlDbType.VarChar).Value = dt.maLoai;
            cmd.Parameters.Add("@sothe", SqlDbType.VarChar).Value = dt.soThe;
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = dt.maNV;
            cmd.Parameters.Add("@biensoxe", SqlDbType.VarChar).Value = dt.bienSoXe;
            cmd.Parameters.Add("@AnhPhiaTruoc", SqlDbType.Image).Value = dt.anhTruoc;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit).Value = false;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            _conSql.Close();
        }
        public void XeRa(int ID, int GiaTien)
        {
            _conSql = con.getConnect();
            _conSql.Open();
            cmd = new SqlCommand("XeRa", _conSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit).Value = true;
            cmd.Parameters.Add("@NgayGioRa", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@GiaTien", SqlDbType.Int).Value = GiaTien;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            _conSql.Close();
        }
        public DataTable CheckXeRa(string ID)
        {
            _conSql = con.getConnect();
            _conSql.Open();
            var dt = new DataTable();
            var da = new SqlDataAdapter("GetCheckXeRa", _conSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@sothe", SqlDbType.VarChar).Value = ID;
            da.Fill(dt);
            return dt;
        }
    }
}

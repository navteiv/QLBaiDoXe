using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL_QLBaiXe
{
    public class DBConnect
    {
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataReader sdr;
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=localhost;Initial Catalog=QuanlyBaixe;Integrated Security=True");
        }
        public DataTable createTable(string sql)
        {
            connect = getConnect();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            return dt;
        }

        public void ExcuteNonQuery(string sql)
        {
            connect = getConnect();
            cmd = new SqlCommand(sql, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            connect.Dispose();
        }
        public string loadLabel(string sql)
        {
            string result = "";
            connect = getConnect();
            connect.Open();
            cmd = new SqlCommand(sql, connect);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {   
                result = sdr[0].ToString();
            }
            connect.Close();
            return result;
        }
        public void LoadCombobox(ComboBox cb, string SQL, string DisplayMember, string ValueMember)
        {
            connect = getConnect();
            connect.Open();
            cb.DataSource = createTable(SQL);
            cb.DisplayMember = DisplayMember;
            cb.ValueMember = ValueMember;
            connect.Close();
        }
        public string taomatudong(string truong, string table, string kieu)
        {
            string ma = "";
            DataSet ds = new DataSet();

            connect = getConnect();
            connect.Open();
            string str = "select right(" + truong + ",6) as ma  from " + table + 
            " where right(" + truong + ",6) >= All(select right(" + truong + ",6) as ma from " + table + ")";
            SqlCommand cm1 = new SqlCommand(str, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm1);

            da.Fill(ds, table);
            connect.Close();
            if (ds.Tables[table].Rows.Count == 0)
            {
                ma = kieu + "000001";
                return ma;
            }

            else
            {
                for (int i = 0; i < ds.Tables[table].Rows.Count; i++)
                {
                    // MessageBox.Show(ds.Tables["hdban"].Rows[i]["hoadon"].ToString());
                    double a = Convert.ToDouble(ds.Tables[table].Rows[i]["ma"].ToString());

                    if (a <= 10)
                    {
                        ma = kieu + "00000" + (a + 1);
                        return ma;
                    }
                    else
                    if (a < 100)
                    {
                        ma = kieu + "0000" + (a + 1);
                        return ma;
                    }
                    else if (a < 1000)
                    {
                        ma = kieu + "000" + (a + 1);
                        return ma;
                    }
                    else if (a < 10000)
                    {
                        ma = kieu + "00" + (a + 1);
                        return ma;
                    }
                    else if (a < 100000)
                    {
                        ma = kieu + "0" + (a + 1);
                        return ma;
                    }
                    else if (a < 1000000)
                    {
                        ma = kieu + (a + 1);
                        return ma;
                    }
                }
            } return ma;
        } // end taomatudong
    }
}

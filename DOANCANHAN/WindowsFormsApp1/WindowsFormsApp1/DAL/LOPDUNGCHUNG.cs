using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.connect
{
    internal class LOPDUNGCHUNG
    {
        string chuoikn = @"Data Source=-HUYSIEUCAP-\HARRISON;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoikn);
        }

        public int ThemXoaSua(string sql)   
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object ExcuteSclar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

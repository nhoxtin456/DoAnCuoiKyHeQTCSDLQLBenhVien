using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLBV.Models
{
    class connection
    {
        public static SqlConnection sqlcon = new SqlConnection(DoAnQLBV.Properties.Settings.Default.QuanLyBenhVienDoAnCuoiKiConnectionString);
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(DoAnQLBV.Properties.Settings.Default.QuanLyBenhVienDoAnCuoiKiConnectionString);
            return con;
        }

        public static void open()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Closed)
                    Getconnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public static void close()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Open)
                    Getconnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static DataSet FillDataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return ds;
        }
        public static DataSet FillDataSet(string sql, string table)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(ds, table);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return ds;
        }


        public static DataSet FillDataSet(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }

        public static DataSet FillDataSet(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];

                    cmd.Parameters.Add(sqlpara);
                }

                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(ds);
                sqlda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }

        public static DataSet DataSetReader(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];

                    cmd.Parameters.Add(sqlpara);
                }
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }

        public static SqlDataReader DataReader(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlDataReader dataReader;

            SqlConnection con = new SqlConnection();
            con = Getconnection();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQuery;
            cmd.CommandType = cmdtype;

            cmd.Connection = con;
            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            dataReader = cmd.ExecuteReader();

            return dataReader;
        }

        public static DataSet DataSetReader1(string strQuery, CommandType cmdtype)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }
        public static DataSet DataSetReader(string strQuery, CommandType cmdtype)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }
        public DataTable FillDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return dt;
        }
        public static int Excute_Sql(string sql)
        {
            int i = 0;
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return i;
        }
        public static int Excute_Sql(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            int efftectRecord = 0;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return efftectRecord;
        }

        public static int thucThiLenh(string sql)
        {
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra\r\n" + ex.Message);
                }
            }
            return count;
        }
        public static object docGiaTri(string sql)
        {
            object result = null;
            SqlConnection conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra\r\n" + ex.Message);
            }
            return result;
        }
        public static string ExcuteScalar(string stringSQL)
        {
            string giaTri = "";
            try
            {
                SqlConnection sqlconn = Getconnection();
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(stringSQL, sqlconn);
                giaTri = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return giaTri;
        }
        public static string ExcuteScalar(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            string efftectRecord = "";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return efftectRecord;
        }
        public static DataTable ExcuteScalar1(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            //string efftectRecord = "";
            SqlCommand sqlcmd = new SqlCommand();
            DataTable dt = new DataTable();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return dt;
        }
        public static DataSet ExcuteScalar2(string strSQL, CommandType ct)
        {
            SqlConnection conn = new SqlConnection();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn = Getconnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                //comm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                //da.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!!!!");
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public static string ExcuteScalar3(string strSQL, CommandType ct)
        {
            string Tong = "";
            SqlConnection conn = new SqlConnection();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn = Getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                Tong = comm.ExecuteScalar().ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!!!!");
            }
            finally
            {
                conn.Close();
            }
            return Tong;
        }
        public static DataSet ExcuteScalar4(string strSQL, CommandType ct)
        {
            SqlConnection conn = new SqlConnection();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn = Getconnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                //comm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                //da.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!!!!");
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
    }
}

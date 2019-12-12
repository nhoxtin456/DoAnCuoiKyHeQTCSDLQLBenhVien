using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLBV.Models
{
    class KetNoi
    {
        private static KetNoi instance;
        public static KetNoi Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoi();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private KetNoi() { }
        // trả ra một table
        public DataTable ExecuteQuery(string query = null, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(DoAnQLBV.Properties.Settings.Default.QuanLyBenhVienDoAnCuoiKiConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        // trả ra số dòng thành công
        public int ExecuteNonQuery(string query = null, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(DoAnQLBV.Properties.Settings.Default.QuanLyBenhVienDoAnCuoiKiConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        // trả ra số lượng
        public object ExecuteScalar(string query = null, object[] parameter = null)
        {
            object data = new DataTable();
            using (SqlConnection connection = new SqlConnection(DoAnQLBV.Properties.Settings.Default.QuanLyBenhVienDoAnCuoiKiConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}

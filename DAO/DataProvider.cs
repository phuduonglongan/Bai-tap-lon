using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAO
{
    public class DataProvider
    {
        private string cstr = @"Data Source=.;Initial Catalog= NhânViên ;Integrated Security=True";

        public DataTable ExcuteQuery( string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cn = new SqlConnection(cstr))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(query, cn);

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
                cn.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cn = new SqlConnection(cstr))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(query, cn);

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
                cn.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection cn = new SqlConnection(cstr))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(query, cn);

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
                cn.Close();
            }
            return data;
        }
    }
}

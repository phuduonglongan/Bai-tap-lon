using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string cstr = @"Data Source=.;Initial Catalog= NhânViên ;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cstr);

            string query = "SELECT * FROM dbo.Account";
            cn.Open();

            SqlCommand command = new SqlCommand(query, cn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            cn.Close();

            dtgvAccount.DataSource = data;
        }
      
    }
}

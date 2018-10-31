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
using demo.DAO;

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
            string query = "dbo.USP_GetAccountByUserName @userName ";
            DataProvider provider = new DataProvider();
            dtgvAccount.DataSource = provider.ExcuteQuery(query, new object[] {"duong"} );
        }
      
    }
}

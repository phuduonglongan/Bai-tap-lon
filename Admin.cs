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
        void LoadFoodList()
        {
            string query = "selec * from food ";
            dtgvFood.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void LoadAccountList()
        {
            string query = "dbo.USP_GetAccountByUserName @userName ";
            dtgvAccount.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] {"duong"} );
        }
      
    }
}

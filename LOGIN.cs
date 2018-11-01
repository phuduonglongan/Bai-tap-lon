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
    public partial class FormLogin : Form
    {
        FormManager fm = new FormManager();
        public FormLogin()
        {
            InitializeComponent();
        }
       
        private void btdangnhap_Click(object sender, EventArgs e)
        {

            string Username = txtUsername.Text;
            string Pass = txtPass.Text;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Bạn cần nhập đủ User và pass", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
               if (login(Username, Pass) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //may tao khong co csdl nha .nãy làm bên máy băng á.đường tạo sql bên máy đó
                    DialogResult result = MessageBox.Show("User hoặc Pass không đúng!!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        
                    }
                    else
                    {
                        txtPass.Text ="";
                        txtUsername.Focus();
                    }
                }
            }


        }

      private bool login(string Username, string Pass)
        {
            string cnstr = "Server= .; Database= NhânViên; Integrated Security=true";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string sql = "SELECT COUNT(Username) FROM Account WHERE UserName = '" + Username + "'AND PassWord = '" + Pass + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int count = (int)cmd.ExecuteScalar();
            cn.Close();
            if (count == 1)
                return true;
            else
                return false;


        }
        private void btThoat_Click_1(object sender, EventArgs e)
        {
            FormLogin fLg = new FormLogin();
            if (MessageBox.Show("Ban có thật sự muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo) == (DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                fLg.ShowDialog();
            }

        }
    }
}

    


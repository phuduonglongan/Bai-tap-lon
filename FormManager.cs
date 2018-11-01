using demo.DAO;
using demo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class FormManager : Form
    {
        private object TableDAO;

        public FormManager()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            List<Table> tableList = DAO.TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button bt = new Button()
                {
                    Width = DAO.TableDAO.TableWidth,
                    Height = DAO.TableDAO.TableHeight
                };
                bt.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Trống":
                        bt.BackColor = Color.Aqua;
                        break;
                    case "Có Người":
                        bt.BackColor = Color.Red;
                        break;

                }

                flTable.Controls.Add(bt);
            }
        }
        #endregion

        #region Events 
        private void FormManager_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = false;
            FormLogin f1 = new FormLogin();
            DialogResult result = f1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }



        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormManager fm = new FormManager();
            FormLogin f1 = new FormLogin();
            DialogResult result1 = MessageBox.Show("Bạn thật sự muốn đăng xuất ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Visible = false;
                this.ShowDialog();
                f1.ShowDialog();

            }

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTCN t = new TTCN();
            t.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin am = new Admin();
            am.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);

        }
        #endregion

    }
}


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
      
        public FormManager()
        {
            InitializeComponent();
        }

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


        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

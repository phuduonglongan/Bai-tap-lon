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
            Form1 f1 = new Form1();
            DialogResult result = f1.ShowDialog();
           if (result == DialogResult.OK)
           {
               this.Enabled = true;
          }


        }

    }
}

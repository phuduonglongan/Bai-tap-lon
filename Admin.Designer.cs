namespace demo
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.tabFoodCaterogy = new System.Windows.Forms.TabPage();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcAdmin.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tabBill);
            this.tcAdmin.Controls.Add(this.tabFood);
            this.tcAdmin.Controls.Add(this.tabFoodCaterogy);
            this.tcAdmin.Controls.Add(this.tabTable);
            this.tcAdmin.Controls.Add(this.tabAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(762, 550);
            this.tcAdmin.TabIndex = 0;
            // 
            // tabBill
            // 
            this.tabBill.Location = new System.Drawing.Point(4, 25);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(754, 521);
            this.tabBill.TabIndex = 0;
            this.tabBill.Text = "Doanh Thu";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // tabFood
            // 
            this.tabFood.Location = new System.Drawing.Point(4, 25);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(754, 521);
            this.tabFood.TabIndex = 1;
            this.tabFood.Text = "Thức Ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // tabFoodCaterogy
            // 
            this.tabFoodCaterogy.Location = new System.Drawing.Point(4, 25);
            this.tabFoodCaterogy.Name = "tabFoodCaterogy";
            this.tabFoodCaterogy.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoodCaterogy.Size = new System.Drawing.Size(754, 521);
            this.tabFoodCaterogy.TabIndex = 2;
            this.tabFoodCaterogy.Text = "Danh mục";
            this.tabFoodCaterogy.UseVisualStyleBackColor = true;
            // 
            // tabTable
            // 
            this.tabTable.Location = new System.Drawing.Point(4, 25);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(754, 521);
            this.tabTable.TabIndex = 3;
            this.tabTable.Text = "Bàn Ăn";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.panel2);
            this.tabAccount.Controls.Add(this.panel1);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(754, 521);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "Tài Khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 52);
            this.panel2.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 574);
            this.Controls.Add(this.tcAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.TabPage tabFoodCaterogy;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
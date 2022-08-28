namespace Shoprite_Inventory_Management_System
{
    partial class Admin_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.catDataGridView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.catAddButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).BeginInit();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 540);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 32);
            this.button6.TabIndex = 5;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.productButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.accountButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(4, 180);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(126, 38);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.catButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(139, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 105);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(773, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOPRITE INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboardpanel);
            this.panel2.Controls.Add(this.categoryPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.productPanel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.accountPanel);
            this.panel2.Location = new System.Drawing.Point(139, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 475);
            this.panel2.TabIndex = 3;
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.accountPanel.Controls.Add(this.accountDataGridView);
            this.accountPanel.Controls.Add(this.button1);
            this.accountPanel.Location = new System.Drawing.Point(2, 3);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(870, 448);
            this.accountPanel.TabIndex = 6;
            this.accountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountPanel_Paint);
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Location = new System.Drawing.Point(14, 47);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(854, 195);
            this.accountDataGridView.TabIndex = 5;
            this.accountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDataGridView_CellContentClick);
            this.accountDataGridView.Click += new System.EventHandler(this.form);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.accountbuttonClick);
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.Color.White;
            this.dashboardpanel.Location = new System.Drawing.Point(2, 0);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(870, 448);
            this.dashboardpanel.TabIndex = 7;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.categoryPanel.Controls.Add(this.catDataGridView);
            this.categoryPanel.Controls.Add(this.button8);
            this.categoryPanel.Location = new System.Drawing.Point(2, 3);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(870, 448);
            this.categoryPanel.TabIndex = 6;
            this.categoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.categoryPanel_Paint);
            // 
            // catDataGridView
            // 
            this.catDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataGridView.Location = new System.Drawing.Point(14, 47);
            this.catDataGridView.Name = "catDataGridView";
            this.catDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.catDataGridView.Size = new System.Drawing.Size(616, 205);
            this.catDataGridView.TabIndex = 5;
            this.catDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDataGridView_CellContentClick);
            this.catDataGridView.Click += new System.EventHandler(this.Form1_Load);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Add Category";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.catbuttonClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 448);
            this.panel4.TabIndex = 7;
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.productPanel.Controls.Add(this.productDataGridView);
            this.productPanel.Controls.Add(this.catAddButton);
            this.productPanel.Location = new System.Drawing.Point(0, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(870, 448);
            this.productPanel.TabIndex = 1;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(14, 47);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(858, 157);
            this.productDataGridView.TabIndex = 5;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            this.productDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productDataGridView_CellMouseClick);
            this.productDataGridView.Click += new System.EventHandler(this.FormLoad);
            this.productDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productDataGridView_CellContentClick);
            // 
            // catAddButton
            // 
            this.catAddButton.Location = new System.Drawing.Point(14, 14);
            this.catAddButton.Name = "catAddButton";
            this.catAddButton.Size = new System.Drawing.Size(137, 23);
            this.catAddButton.TabIndex = 4;
            this.catAddButton.Text = "Add Product";
            this.catAddButton.UseVisualStyleBackColor = true;
            this.catAddButton.Click += new System.EventHandler(this.productButton);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(1, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(871, 456);
            this.panel5.TabIndex = 6;
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // Admin_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noble";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.accountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).EndInit();
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button catAddButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.DataGridView catDataGridView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Panel dashboardpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}


namespace Shoprite_Inventory_Management_System
{
    partial class Attendant_Screen
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
            this.components = new System.ComponentModel.Container();
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
            this.productPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.catDataGridView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.userIdtextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tillTextBox = new System.Windows.Forms.TextBox();
            this.totaTtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saleProductdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.dashboardpanel.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button6);
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
            this.button7.Location = new System.Drawing.Point(6, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 32);
            this.button6.TabIndex = 5;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(198, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Start Session";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "End Session";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(4, 160);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(126, 38);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOPRITE INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productPanel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.accountPanel);
            this.panel2.Controls.Add(this.dashboardpanel);
            this.panel2.Controls.Add(this.categoryPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(139, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 475);
            this.panel2.TabIndex = 3;
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.productPanel.Controls.Add(this.startdateTimePicker);
            this.productPanel.Controls.Add(this.dateTimePicker);
            this.productPanel.Controls.Add(this.userIdtextBox);
            this.productPanel.Controls.Add(this.button5);
            this.productPanel.Location = new System.Drawing.Point(0, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(870, 448);
            this.productPanel.TabIndex = 1;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.barcodeTextBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.searchTextBox);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.saleProductdataGridView);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.totaTtextBox);
            this.panel5.Controls.Add(this.tillTextBox);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.closedateTimePicker);
            this.panel5.Location = new System.Drawing.Point(1, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(871, 456);
            this.panel5.TabIndex = 6;
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
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Location = new System.Drawing.Point(14, 47);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(854, 195);
            this.accountDataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.Color.White;
            this.dashboardpanel.Controls.Add(this.textBox1);
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
            // 
            // catDataGridView
            // 
            this.catDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataGridView.Location = new System.Drawing.Point(14, 47);
            this.catDataGridView.Name = "catDataGridView";
            this.catDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.catDataGridView.Size = new System.Drawing.Size(616, 205);
            this.catDataGridView.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Add Category";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 448);
            this.panel4.TabIndex = 7;
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // userIdtextBox
            // 
            this.userIdtextBox.Location = new System.Drawing.Point(71, 78);
            this.userIdtextBox.Multiline = true;
            this.userIdtextBox.Name = "userIdtextBox";
            this.userIdtextBox.Size = new System.Drawing.Size(142, 38);
            this.userIdtextBox.TabIndex = 2;
            this.userIdtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(245, 88);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startdateTimePicker.Location = new System.Drawing.Point(482, 88);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.startdateTimePicker.TabIndex = 7;
            // 
            // closedateTimePicker
            // 
            this.closedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.closedateTimePicker.Location = new System.Drawing.Point(347, 21);
            this.closedateTimePicker.Name = "closedateTimePicker";
            this.closedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.closedateTimePicker.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tillTextBox
            // 
            this.tillTextBox.Location = new System.Drawing.Point(15, 21);
            this.tillTextBox.Name = "tillTextBox";
            this.tillTextBox.Size = new System.Drawing.Size(100, 20);
            this.tillTextBox.TabIndex = 1;
            // 
            // totaTtextBox
            // 
            this.totaTtextBox.Location = new System.Drawing.Point(511, 387);
            this.totaTtextBox.Name = "totaTtextBox";
            this.totaTtextBox.Size = new System.Drawing.Size(100, 20);
            this.totaTtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // saleProductdataGridView
            // 
            this.saleProductdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleProductdataGridView.Location = new System.Drawing.Point(15, 95);
            this.saleProductdataGridView.Name = "saleProductdataGridView";
            this.saleProductdataGridView.Size = new System.Drawing.Size(460, 289);
            this.saleProductdataGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Sale Made";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(481, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "ADD SALES";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 65);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(161, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Till ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Closing Time";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(618, 20);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.barcodeTextBox.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(618, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Generate";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Barcode";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(482, 136);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 23);
            this.button11.TabIndex = 15;
            this.button11.Text = "DELETE SALES";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(482, 179);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "EDIT SALES";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Attendant_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Attendant_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noble";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.dashboardpanel.ResumeLayout(false);
            this.dashboardpanel.PerformLayout();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductdataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox userIdtextBox;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker closedateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tillTextBox;
        private System.Windows.Forms.TextBox totaTtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView saleProductdataGridView;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}
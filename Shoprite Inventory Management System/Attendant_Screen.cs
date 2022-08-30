using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BarcodeLib.BarcodeReader;

namespace Shoprite_Inventory_Management_System
{
    public partial class Attendant_Screen : Form
    {
        const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
        //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
        MySqlConnection sqlConnection = new MySqlConnection(connectionString);
        public Attendant_Screen()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fetchProductData()
        {
            string query = "select * from product ";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                sqlConnection.Open();
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                sqlConnection.Close();

                dv = ds.Tables[0].DefaultView;
                saleProductdataGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (userIdtextBox.Text !="" && dateTimePicker.Value.ToString() !="" && startdateTimePicker.Value.ToString() != "")
            {
                //sqlConnection.Open();
                MySqlCommand command = new MySqlCommand();
                try
                {
                    string countQuery = $"select count(*) from  user where User_ID = '" + int.Parse(userIdtextBox.Text) + "' ";
                    sqlConnection.Open();
                    command = new MySqlCommand(countQuery, sqlConnection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    sqlConnection.Close();
                    if (count > 0)
                    {
                        string query = $"INSERT INTO `Till` (`User_ID`, `TillDate`, `StartTime`)VALUES(' {int.Parse(userIdtextBox.Text)}','{dateTimePicker.Value}','{startdateTimePicker.Value}')";
                        sqlConnection.Open();
                        command = new MySqlCommand(@query, sqlConnection);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                        panel5.Enabled = true;
                        panel5.Visible = true;
                        panel5.BringToFront();
                        MessageBox.Show(userIdtextBox.Text + "' has started a till session");


                        //string sql = $"select * from Till where User_ID = '" + int.Parse(userIdtextBox.Text) + "' and TillDate = '" + dateTimePicker.Value + "' and StartTime = '" + startdateTimePicker.Value + "' ";
                        //sqlConnection.Open();
                        //command = new MySqlCommand(sql, sqlConnection);
                        //using (MySqlDataReader reader = command.ExecuteReader())
                        //{
                        //    if (reader.Read())
                        //    {
                        //       tillTextBox.Text = reader["Till_ID"].ToString();
                        //    }
                        //}
                        //sqlConnection.Close();

                        //this.Hide();
                        
                       

                    }
                    else
                    {
                        label2.Visible = true;
                        label2.Text = "User does not Exist";
                    }
                }
                catch (Exception ex)
                {
                    label2.Text = ex.Message;
                }

            }
            else
            {
                label2.Visible=true;
                label2.Text = "Please Enter text for all the fields";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //closedateTimePicker.Format = DateTimePickerFormat.Time;
            sqlConnection.Open();
            MySqlCommand command;

            string query = "UPDATE `Till` SET `EndTime` = '"+closedateTimePicker.Value+"' , `TotalMade` = '"+totaTtextBox.Text+"' , `tillStatus` = 'CLOSED' WHERE `till`.`Till_ID` = '"+tillTextBox.Text+"';";
            command = new MySqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully ended session");
            sqlConnection.Close();

            //this.Hide();
            //AttendantHome attend = new AttendantHome();
            //attend.Show();
            productPanel.Enabled = true;
            productPanel.Visible = true;
            productPanel.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productPanel.Enabled = true;
            productPanel.Visible = true;
            productPanel.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string[] BarcodeUPCA = BarcodeReader.read(@"C:\\Users\BrandedHustler\"+numeric+".png", BarcodeReader.UPCA);
        }
    }
}

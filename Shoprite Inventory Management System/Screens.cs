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
using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;

namespace Shoprite_Inventory_Management_System
{
    public partial class Screens : Form
    {
        Generators generator = new Generators();
        //string numeric = ""+generator.randomProductcode(12)+"";
        const string connectionString = "Server = localhost; Database=inventorysystem;User id=root;Password=Eselase12/.;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Screens()
        {
            InitializeComponent();
        }

        private void catCancelBut(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void cancelProductButton(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


        public void stress()
        {
            const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
            //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();
            string text = $"SELECT Product.*, Category.Category_Name FROM Product JOIN Category ON Category.Category_ID = Product.Category_ID;";
            string name = $"Select Category_ID, Category_Name FROM Category INNER JOIN Product ON Category.Category_ID = Product.Category_ID";
            string ID = $"SELECT Category_ID FROM Category WHERE Category_Name = '"+catComboBox.SelectedText+"'";
            MySqlCommand cm = new MySqlCommand(ID, sqlConnection);
            MySqlDataReader cr = cm.ExecuteReader();
            while (cr.Read())
            {
                string cn = cr.GetValue(0).ToString();
            }
        }


        public void productButtonClick(object sender, EventArgs e)
        {
           // Generators generator = new Generators();

           

            Barcode barcodelib = new Barcode();

            int imgageHeight = 110;
            int imageWidth = 250;

            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;

            //string alphaNumeric = string.Format("{0}",randomProductcode(10));
            string numeric = ""+generator.randomProductcode(12)+"";
            ///string numer = randomProductcode(11);
            //string numeric = "012345678901";

            Image barcodeImage = barcodelib.Encode(TYPE.UPCA, numeric, foreColor, backColor, imageWidth, imgageHeight);

            //barcodeImage.Save(@"C:\\Users\BrandedHustler\Barcode.png", ImageFormat.Png);
            //barcodeImage.Save(string.Format(@"C:\{}",alphaNumeric), ImageFormat.Png);
            barcodeImage.Save(@"C:\\Users\BrandedHustler\"+numeric+".png", ImageFormat.Png);


            
            //generator.randomProductcode(12);
            //generator.barcodeGenerator();
            string[] BarcodeUPCA = BarcodeReader.read(@"C:\\Users\BrandedHustler\"+numeric+".png", BarcodeReader.UPCA);
            MessageBox.Show(generator.ConvertStringArrayToString(BarcodeUPCA));
            //Admin_Screen admin = new Admin_Screen();
           

            try
            {
                const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
                //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
                MySqlConnection sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();
                string text = $"SELECT Product.*, Category.Category_Name FROM Product JOIN Category ON Category.Category_ID = Product.Category_ID;";
                string name = $"Select Category_ID, Category_Name FROM Category INNER JOIN Product ON Category.Category_ID = Product.Category_ID";
                string ID = $"SELECT Category_ID FROM Category WHERE Category_Name = '"+catComboBox.SelectedText+"'";
                MySqlCommand cm = new MySqlCommand(ID, sqlConnection);
                MySqlDataReader cr = cm.ExecuteReader();
                while (cr.Read())
                {
                    string cn = cr.GetValue(0).ToString();
                }
                MessageBox.Show(ID);
                string sqlStatement =
                    $"INSERT INTO `Product`(`Product_Name`, `Selling_Price`,`Product_Code`, `Cost_Price`, `Quantity`, `Category_ID`, `PTotal_Sell`, `PTotal_Cost`) VALUES ('{nametextBox.Text}', {pricetextBox.Text}, '{numeric}', {distextBox.Text},{quantityTextBox.Text}, {catComboBox.SelectedIndex + 1}, {(int.Parse(pricetextBox.Text)) * (int.Parse(quantityTextBox.Text))}, {(int.Parse(this.distextBox.Text)) * (int.Parse(quantityTextBox.Text))})";

                System.Console.WriteLine(sqlStatement);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show($"{this.nametextBox.Text} has been added successfully");
                nametextBox.Clear();
                pricetextBox.Clear();
                distextBox.Clear();
                quantityTextBox.Clear();
                Admin_Screen admin = new Admin_Screen();
                admin.productButton();



            }
            catch (Exception eb)
            {
                MessageBox.Show($"An error occured {eb.StackTrace}");
                throw;
            }
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void catComboBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.click();
            //catComboBox.Items.Clear();
        }
        private void catComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
            //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Category_ID, Category_Name FROM Category ORDER BY Category_ID";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            //catComboBox.Items.Clear();
            while (reader.Read())
            {
                
                //string name = reader.GetString(1);
                catComboBox.Items.Add(reader.GetValue(1).ToString());
                //catComboBox.Items.Add(name);
                
            }

        }

        public void click()
        {
            const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
            //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Category_ID, Category_Name FROM Category";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                catComboBox.Items.Add(name);
                reader.GetValue(1).ToString();
                catComboBox.Items.Add(reader.GetValue(1).ToString());
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

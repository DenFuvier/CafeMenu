using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenu.Windows
{
    public partial class SkinChanger : Form
    { 
        SqlConnector sql = new SqlConnector();
        public string SelectedTable { get; private set; }
        private int _id;
        private string _productName;
        private decimal _price;
        public SkinChanger(int ID,string ProductName,decimal Price)
        {
            InitializeComponent();
            _id = ID;
            _productName = ProductName;
            _price = Price;
            ID_Box.Text = _id.ToString();
            ProductNameBox.Text = _productName;
            PriceBox.Text = _price.ToString();
        }
        private void SendNewPrice(string tableName)
        {
            string cs = sql.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();

                    string price = PriceBox.Text;
                    string id = ID_Box.Text;

                    string query = $"UPDATE {tableName} SET Price = '{price}' WHERE ID = '{id}'";

                    var cmd = new MySqlCommand(query, con);
                    var reader = cmd.ExecuteReader();

                    MessageBox.Show("Price Changed!");

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (var selector = new TableSelectorForm())
            {
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    string table = selector.SelectedTable;
                    SendNewPrice(table);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePrice changePrice = new ChangePrice();  
            changePrice.ShowDialog();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
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
        private string _tableName;
        public SkinChanger(int ID,string ProductName,decimal Price, string TableName)
        {
            InitializeComponent();

            _id = ID;
            _productName = ProductName;
            _price = Price;
            _tableName = TableName;

            ProductNameBox.Text = _productName;
            PriceBox.Text = _price.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string cs = new SqlConnector().GetConnect();
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                string newName = ProductNameBox.Text;
                decimal newPrice = decimal.Parse(PriceBox.Text);
                string sql = $"UPDATE {_tableName} SET ProductName = @name, Price = @price WHERE Id = @_id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@price", newPrice);
                    cmd.Parameters.AddWithValue("@_id", _id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Данные обновлены.");
            this.Close();
            ChangePrice changePrice = new ChangePrice();
            changePrice.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePrice changePrice = new ChangePrice();  
            changePrice.ShowDialog();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeMenu.Windows
{
    public partial class ChangePrice : Form
    {
        SqlConnector sql = new SqlConnector();
        List<Snack> snakss = new List<Snack>();
        List<Drink> drinkss = new List<Drink>();
        List<Desserts> desserts = new List<Desserts>();
        List<Maindishes> maindishes = new List<Maindishes>();
        
        public ChangePrice()
        {
            InitializeComponent();
            LoadsnmaksVIEW();
            LoadDrinkView();
            LoadDessertsView();
            LoadMainDishes();
            snacksVIEW.DoubleClick += SnacksVIEW_DoubleClick;
            drinksVIEW.DoubleClick += DrinksVIEW_DoubleClick;
            dessertsVIEW.DoubleClick += DessertsVIEW_DoubleClick;
            maindishesVIEW.DoubleClick += MaindishesVIEW_DoubleClick;

        }

        private void MaindishesVIEW_DoubleClick(object sender, EventArgs e)
        {
            int number = maindishesVIEW.CurrentRow.Index;
            Maindishes X = maindishes[number];
            int ID = X.Id;
            string ProductName = X.ProductName;
            decimal Price = X.Price;
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price);
            changerForm.Show();
            this.Hide();    
        }

        private void DessertsVIEW_DoubleClick(object sender, EventArgs e)
        {
            int number = dessertsVIEW.CurrentRow.Index;
            Desserts X = desserts[number];
            int ID = X.Id;
            string ProductName = X.ProductName;
            decimal Price = X.Price;
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price);
            changerForm.Show();
            this.Hide();
        }

        private void DrinksVIEW_DoubleClick(object sender, EventArgs e)
        {
            int number = drinksVIEW.CurrentRow.Index;
            Drink X = drinkss[number];
            int ID = X.Id;
            string ProductName = X.ProductName;
            decimal Price = X.Price;
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price);
            changerForm.Show();
            this.Hide();
        }

        private void SnacksVIEW_DoubleClick(object sender, EventArgs e)
        {
            int number = snacksVIEW.CurrentRow.Index;
            Snack X = snakss[number];
            int ID = X.Id;
            string ProductName = X.ProductName;
            decimal Price = X.Price;
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price);
            changerForm.Show();
            this.Hide();
        }

        private void LoadMainDishes()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM maindishes";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                maindishesVIEW.Refresh();
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string ProductName = reader.GetString(1);
                    int Price = reader.GetInt32(2);
                    Maindishes Maimmmm = new Maindishes
                    {
                        Id = ID,
                        ProductName = ProductName,
                        Price = Price
                    };
                    maindishes.Add(Maimmmm);
                    maindishesVIEW.DataSource = maindishes;
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDessertsView()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM desserts";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                dessertsVIEW.Refresh();
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string ProductName = reader.GetString(1);
                    int Price = reader.GetInt32(2);
                    Desserts dessertss = new Desserts
                    {
                        Id = ID,
                        ProductName = ProductName,
                        Price = Price
                    };
                    desserts.Add(dessertss);
                    dessertsVIEW.DataSource = desserts;
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDrinkView()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM drinks";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                drinksVIEW.Refresh();
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string ProductName = reader.GetString(1);
                    int Price = reader.GetInt32(2);
                    Drink Drosel = new Drink
                    {
                        Id = ID,
                        ProductName = ProductName,
                        Price = Price
                    };
                    drinkss.Add(Drosel);
                    drinksVIEW.DataSource = drinkss;
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadsnmaksVIEW()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM snacks";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                snacksVIEW.Refresh();
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string ProductName = reader.GetString(1);
                    int Price = reader.GetInt32(2);
                    Snack SNikers = new Snack
                    {
                        Id = ID,
                        ProductName = ProductName,
                        Price = Price
                    };
                    snakss.Add(SNikers);
                    snacksVIEW.DataSource = snakss;
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void snacksVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            snacksVIEW.CellMouseEnter += SnacksVIEW_CellContentClick;
            drinksVIEW.CellMouseEnter += DrinksVIEW_CellContentClick;
            dessertsVIEW.CellMouseEnter += DessertsVIEW_CellContentClick;
            maindishesVIEW.CellMouseEnter += MaindishesVIEW_CellContentClick;
            snacksVIEW.CellMouseLeave += SnacksVIEW_CellMouseLeavek;
            drinksVIEW.CellMouseLeave += DrinksVIEW_CellMouseLeave;
            dessertsVIEW.CellMouseLeave += DessertsVIEW_CellMouseLeave;
            maindishesVIEW.CellMouseLeave += MaindishesVIEW_CellMouseLeave;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            drinksVIEW.TabStop = false;
            dessertsVIEW.TabStop = false;
            maindishesVIEW.TabStop = false;
            this.Shown += (s, e) =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    snacksVIEW.ClearSelection();
                    snacksVIEW.CurrentCell = null;
                    drinksVIEW.ClearSelection();
                    drinksVIEW.CurrentCell = null;
                    dessertsVIEW.ClearSelection();
                    dessertsVIEW.CurrentCell = null;
                    maindishesVIEW.ClearSelection();
                    maindishesVIEW.CurrentCell = null;
                }));
            };
        }
        private void MaindishesVIEW_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                maindishesVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White; // Reset to default color
            }
        }

        private void DessertsVIEW_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dessertsVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White; // Reset to default color
            }
        }

        private void DrinksVIEW_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                drinksVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White; // Reset to default color
            }
        }

        private void SnacksVIEW_CellMouseLeavek(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                snacksVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White; // Reset to default color
            }
        }

        private void MaindishesVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                maindishesVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#FFB6C1"); // Light Pink color
            }
            
        }

        private void DessertsVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            { 
                dessertsVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#FFB6C1"); // Light Pink color
            }
        }

        private void DrinksVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                drinksVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#FFB6C1"); // Light Pink color
            }
        }

        private void SnacksVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                snacksVIEW.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#FFB6C1"); // Light Pink color
            }
        }

        private void MaindishesVIEW_DoubleClick(object sender, EventArgs e)
        {
            int number = maindishesVIEW.CurrentRow.Index;
            Maindishes X = maindishes[number];
            int ID = X.Id;
            string ProductName = X.ProductName;
            decimal Price = X.Price;
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price, "maindishes");
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
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price, "desserts");
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
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price, "drinks");
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
            SkinChanger changerForm = new SkinChanger(ID, ProductName, Price, "snacks");
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
                    snacksVIEW.CurrentCell = null;
                    snacksVIEW.ClearSelection();
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
            snacksVIEW.SelectionMode = DataGridViewSelectionMode.CellSelect;
            snacksVIEW.DefaultCellStyle.SelectionBackColor = snacksVIEW.DefaultCellStyle.BackColor;
            snacksVIEW.DefaultCellStyle.SelectionForeColor = snacksVIEW.DefaultCellStyle.ForeColor;
            snacksVIEW.EnableHeadersVisualStyles = false;

            drinksVIEW.SelectionMode = DataGridViewSelectionMode.CellSelect;
            drinksVIEW.DefaultCellStyle.SelectionBackColor = drinksVIEW.DefaultCellStyle.BackColor;
            drinksVIEW.DefaultCellStyle.SelectionForeColor = drinksVIEW.DefaultCellStyle.ForeColor;
            drinksVIEW.EnableHeadersVisualStyles = false;

            dessertsVIEW.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dessertsVIEW.DefaultCellStyle.SelectionBackColor = dessertsVIEW.DefaultCellStyle.BackColor;
            dessertsVIEW.DefaultCellStyle.SelectionForeColor = dessertsVIEW.DefaultCellStyle.ForeColor;
            dessertsVIEW.EnableHeadersVisualStyles = false;

            maindishesVIEW.SelectionMode = DataGridViewSelectionMode.CellSelect;
            maindishesVIEW.DefaultCellStyle.SelectionBackColor = maindishesVIEW.DefaultCellStyle.BackColor;
            maindishesVIEW.DefaultCellStyle.SelectionForeColor = maindishesVIEW.DefaultCellStyle.ForeColor;
            maindishesVIEW.EnableHeadersVisualStyles = false;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Drawing;
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
        private ChangePrice _parent;
        public SkinChanger(int ID,string ProductName,decimal Price, string TableName,ChangePrice parent)
        {
            InitializeComponent();

            _id = ID;
            _productName = ProductName;
            _price = Price;
            _tableName = TableName;
            StyleAllTextBoxes(this);
            ProductNameBox.Text = _productName;
            PriceBox.Text = _price.ToString();
            _parent = parent;
        }
        private void StyleAllTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                    StyleTextBox(tb);

                if (ctrl.HasChildren)
                    StyleAllTextBoxes(ctrl);
            }
        }
        private void StyleTextBox(TextBox tb)
        {
            tb.BackColor = Color.White;
            tb.ForeColor = ColorTranslator.FromHtml("#4c3d2d");
            tb.BorderStyle = BorderStyle.FixedSingle;
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
            if (Application.OpenForms["Start_Form"] is Start_Form form)
            {
                form.FillMainDishesTextBoxes();
                form.FillSnacksTextBoxes();
                form.FillDrinksTextBoxes();
                form.FillDessertsTextBoxes();
            }

            MessageBox.Show("Данные обновлены.");
            _parent?.ReloadAllTables();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SkinChanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

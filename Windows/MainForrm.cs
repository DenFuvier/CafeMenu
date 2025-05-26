using CafeMenu.General;
using CafeMenu.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CafeMenu
{
    public partial class Start_Form : Form
    {
        SqlConnector SQL = new SqlConnector();
        private bool isInitializing = true;
        private bool isPasswordChecked = false;
        public Start_Form()
        {
            InitializeComponent();
            CentreMethod();
            ZeroEnable();
            SellB.Items.AddRange(new string[] { "0%", "5%", "10%", "15%", "20%" });
            SellB.SelectedIndex = 0;
            SellB.SelectedIndexChanged += SellB_SelectedIndexChanged;
            H24.ReadOnly = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Load += Start_Form_Load;

            isInitializing = false;
        }
        public static int GetDiscountPercent()
        {
            if (Application.OpenForms["Start_Form"] is Start_Form form && form.SellB.SelectedItem != null)
            {
                string text = form.SellB.SelectedItem.ToString().Replace("%", "");
                if (int.TryParse(text, out int percent))
                    return percent;
            }
            return 0;
        }
        private void DiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void Start_Form_Load(object sender, EventArgs e)
        {
            FillMainDishesTextBoxes();
            FillSnacksTextBoxes();
            FillDrinksTextBoxes();
            FillDessertsTextBoxes();
        }
       
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти?",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        public void CentreMethod()
        {
            H1.TextAlign = HorizontalAlignment.Center;
            H2.TextAlign = HorizontalAlignment.Center;
            H3.TextAlign = HorizontalAlignment.Center;
            H4.TextAlign = HorizontalAlignment.Center;
            H5.TextAlign = HorizontalAlignment.Center;
            H6.TextAlign = HorizontalAlignment.Center;
            H7.TextAlign = HorizontalAlignment.Center;
            H8.TextAlign = HorizontalAlignment.Center;
            H9.TextAlign = HorizontalAlignment.Center;
            H10.TextAlign = HorizontalAlignment.Center;
            H11.TextAlign = HorizontalAlignment.Center;
            H12.TextAlign = HorizontalAlignment.Center;
            H13.TextAlign = HorizontalAlignment.Center;
            H14.TextAlign = HorizontalAlignment.Center;
            H15.TextAlign = HorizontalAlignment.Center;
            H16.TextAlign = HorizontalAlignment.Center;
            H17.TextAlign = HorizontalAlignment.Center;
            H18.TextAlign = HorizontalAlignment.Center;
            H19.TextAlign = HorizontalAlignment.Center;
            H20.TextAlign = HorizontalAlignment.Center;
            H21.TextAlign = HorizontalAlignment.Center;
            H22.TextAlign = HorizontalAlignment.Center;
            H23.TextAlign = HorizontalAlignment.Center;
            H24.TextAlign = HorizontalAlignment.Center;
        }
        public void ZeroEnable()
        {
            H1.Enabled = false;
            H1.Text = "0";

            H2.Enabled = false;
            H2.Text = "0";

            H3.Enabled = false;
            H3.Text = "0";

            H4.Enabled = false;
            H4.Text = "0";

            H5.Enabled = false;
            H5.Text = "0";

            H6.Enabled = false;
            H6.Text = "0";

            H7.Enabled = false;
            H7.Text = "0";

            H8.Enabled = false;
            H8.Text = "0";

            H9.Enabled = false;
            H9.Text = "0";

            H10.Enabled = false;
            H10.Text = "0";

            H11.Enabled = false;
            H11.Text = "0";

            H12.Enabled = false;
            H12.Text = "0";

            H13.Enabled = false;
            H13.Text = "0";

            H14.Enabled = false;
            H14.Text = "0";

            H15.Enabled = false;
            H15.Text = "0";

            H16.Enabled = false;
            H16.Text = "0";

            H17.Enabled = false;
            H17.Text = "0";

            H18.Enabled = false;
            H18.Text = "0";

            H19.Enabled = false;
            H19.Text = "0";

            H20.Enabled = false;
            H20.Text = "0";

            H21.Enabled = false;
            H21.Text = "0";

            H22.Enabled = false;
            H22.Text = "0";

            H23.Enabled = false;
            H23.Text = "0";
        }
        private void R1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (R1.Checked == true)
            {
                H1.Text = "";
                H1.Focus();
                H1.Enabled = true;
            }
            else
            {
                H1.Enabled = false;
                H1.Text = "0";

            }
        }
        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2.Checked == true)
            {
                H2.Text = "";
                H2.Focus();
                H2.Enabled = true;
            }
            else
            {
                H2.Enabled = false;
                H2.Text = "0";

            }
        }

        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            if (R3.Checked == true)
            {
                H3.Text = "";
                H3.Focus();
                H3.Enabled = true;
            }
            else
            {
                H3.Enabled = false;
                H3.Text = "0";
            }
        }

        private void R4_CheckedChanged(object sender, EventArgs e)
        {
            if (R4.Checked == true)
            {
                H4.Text = "";
                H4.Focus();
                H4.Enabled = true;
            }
            else
            {
                H4.Enabled = false;
                H4.Text = "0";
            }
        }

        private void R5_CheckedChanged(object sender, EventArgs e)
        {
            if (R5.Checked == true)
            {
                H5.Text = "";
                H5.Focus();
                H5.Enabled = true;
            }
            else
            {
                H5.Enabled = false;
                H5.Text = "0";
            }
        }

        private void R6_CheckedChanged(object sender, EventArgs e)
        {
            if (R6.Checked == true)
            {
                H6.Text = "";
                H6.Focus();
                H6.Enabled = true;
            }
            else
            {
                H6.Enabled = false;
                H6.Text = "0";
            }
        }

        private void R7_CheckedChanged(object sender, EventArgs e)
        {
            if (R7.Checked == true)
            {
                H7.Text = "";
                H7.Focus();
                H7.Enabled = true;
            }
            else
            {
                H7.Enabled = false;
                H7.Text = "0";
            }
        }

        private void R8_CheckedChanged(object sender, EventArgs e)
        {
            if (R8.Checked == true)
            {
                H8.Text = "";
                H8.Focus();
                H8.Enabled = true;
            }
            else
            {
                H8.Enabled = false;
                H8.Text = "0";
            }
        }

        private void R9_CheckedChanged(object sender, EventArgs e)
        {
            if (R9.Checked == true)
            {
                H9.Text = "";
                H9.Focus();
                H9.Enabled = true;
            }
            else
            {
                H9.Enabled = false;
                H9.Text = "0";
            }
        }

        private void R10_CheckedChanged(object sender, EventArgs e)
        {
            if (R10.Checked == true)
            {
                H10.Text = "";
                H10.Focus();
                H10.Enabled = true;
            }
            else
            {
                H10.Enabled = false;
                H10.Text = "0";
            }
        }

        private void R11_CheckedChanged(object sender, EventArgs e)
        {
            if (R11.Checked == true)
            {
                H11.Text = "";
                H11.Focus();
                H11.Enabled = true;
            }
            else
            {
                H11.Enabled = false;
                H11.Text = "0";
            }
        }

        private void R12_CheckedChanged(object sender, EventArgs e)
        {
            if (R12.Checked == true)
            {
                H12.Text = "";
                H12.Focus();
                H12.Enabled = true;
            }
            else
            {
                H12.Enabled = false;
                H12.Text = "0";
            }
        }

        private void R13_CheckedChanged(object sender, EventArgs e)
        {
            if (R13.Checked == true)
            {
                H13.Text = "";
                H13.Focus();
                H13.Enabled = true;
            }
            else
            {
                H13.Enabled = false;
                H13.Text = "0";
            }
        }

        private void R14_CheckedChanged(object sender, EventArgs e)
        {
            if (R14.Checked == true)
            {
                H14.Text = "";
                H14.Focus();
                H14.Enabled = true;
            }
            else
            {
                H14.Enabled = false;
                H14.Text = "0";
            }
        }

        private void R15_CheckedChanged(object sender, EventArgs e)
        {
            if (R15.Checked == true)
            {
                H15.Text = "";
                H15.Focus();
                H15.Enabled = true;
            }
            else
            {
                H15.Enabled = false;
                H15.Text = "0";
            }
        }

        private void R16_CheckedChanged(object sender, EventArgs e)
        {
            if (R16.Checked == true)
            {
                H16.Text = "";
                H16.Focus();
                H16.Enabled = true;
            }
            else
            {
                H16.Enabled = false;
                H16.Text = "0";
            }
        }

        private void R17_CheckedChanged(object sender, EventArgs e)
        {
            if (R17.Checked == true)
            {
                H17.Text = "";
                H17.Focus();
                H17.Enabled = true;
            }
            else
            {
                H17.Enabled = false;
                H17.Text = "0";
            }
        }

        private void R18_CheckedChanged(object sender, EventArgs e)
        {
            if (R18.Checked == true)
            {
                H18.Text = "";
                H18.Focus();
                H18.Enabled = true;
            }
            else
            {
                H18.Enabled = false;
                H18.Text = "0";
            }
        }

        private void R19_CheckedChanged(object sender, EventArgs e)
        {
            if (R19.Checked == true)
            {
                H19.Text = "";
                H19.Focus();
                H19.Enabled = true;
            }
            else
            {
                H19.Enabled = false;
                H19.Text = "0";
            }
        }

        private void R20_CheckedChanged(object sender, EventArgs e)
        {
            if (R20.Checked == true)
            {
                H20.Text = "";
                H20.Focus();
                H20.Enabled = true;
            }
            else
            {
                H20.Enabled = false;
                H20.Text = "0";
            }
        }

        private void R21_CheckedChanged(object sender, EventArgs e)
        {
            if (R21.Checked == true)
            {
                H21.Text = "";
                H21.Focus();
                H21.Enabled = true;
            }
            else
            {
                H21.Enabled = false;
                H21.Text = "0";
            }
        }

        private void R22_CheckedChanged(object sender, EventArgs e)
        {
            if (R22.Checked == true)
            {
                H22.Text = "";
                H22.Focus();
                H22.Enabled = true;
            }
            else
            {
                H22.Enabled = false;
                H22.Text = "0";
            }
        }

        private void R23_CheckedChanged(object sender, EventArgs e)
        {
            if (R23.Checked == true)
            {
                H23.Text = "";
                H23.Focus();
                H23.Enabled = true;
            }
            else
            {
                H23.Enabled = false;
                H23.Text = "0";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            H1.Enabled = false;
            H1.Text = "0";

            H2.Enabled = false;
            H2.Text = "0";

            H3.Enabled = false;
            H3.Text = "0";

            H4.Enabled = false;
            H4.Text = "0";

            H5.Enabled = false;
            H5.Text = "0";

            H6.Enabled = false;
            H6.Text = "0";

            H7.Enabled = false;
            H7.Text = "0";

            H8.Enabled = false;
            H8.Text = "0";

            H9.Enabled = false;
            H9.Text = "0";

            H10.Enabled = false;
            H10.Text = "0";

            H11.Enabled = false;
            H11.Text = "0";

            H12.Enabled = false;
            H12.Text = "0";

            H13.Enabled = false;
            H13.Text = "0";

            H14.Enabled = false;
            H14.Text = "0";

            H15.Enabled = false;
            H15.Text = "0";

            H16.Enabled = false;
            H16.Text = "0";

            H17.Enabled = false;
            H17.Text = "0";

            H18.Enabled = false;
            H18.Text = "0";

            H19.Enabled = false;
            H19.Text = "0";

            H20.Enabled = false;
            H20.Text = "0";

            H21.Enabled = false;
            H21.Text = "0";

            H22.Enabled = false;
            H22.Text = "0";

            H23.Enabled = false;
            H23.Text = "0";
            R1.Checked = false;
            R2.Checked = false;
            R3.Checked = false;
            R4.Checked = false;
            R5.Checked = false;
            R6.Checked = false;
            R7.Checked = false;
            R8.Checked = false;
            R9.Checked = false;
            R10.Checked = false;
            R11.Checked = false;
            R12.Checked = false;
            R13.Checked = false;
            R14.Checked = false;
            R15.Checked = false;
            R16.Checked = false;
            R17.Checked = false;
            R18.Checked = false;
            R19.Checked = false;
            R20.Checked = false;
            R21.Checked = false;
            R22.Checked = false;
            R23.Checked = false;
            FillMainDishesTextBoxes();
            FillSnacksTextBoxes();
            FillDrinksTextBoxes();
            FillDessertsTextBoxes();

            H24.Text = "0";

        }
      ///  private bool isPasswordCheckInProgress = false;
        private void SellB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; 

           
            if (SellB.SelectedIndex > 0 && !isPasswordChecked)
            {
                using (PasswordForm passwordForm = new PasswordForm())
                {
                    if (passwordForm.ShowDialog() == DialogResult.OK && passwordForm.IsPasswordCorrect)
                    {
                        MessageBox.Show("Верно...", "Доступ разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isPasswordChecked = true; 
                    }
                    else
                    {
                        SellB.SelectedIndex = 0; 
                        return; 
                    }
                }
            }

         
            CalculateTotal();
        }

        private List<Maindishes> GetMainDishes()
        {
            List<Maindishes> mainDishesList = new List<Maindishes>();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT ID, ProductName, Price FROM maindishes";
                    var cmd = new MySqlCommand(stm, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Maindishes mainDish = new Maindishes
                            {
                                Id = reader.GetInt32("ID"),
                                ProductName = reader.GetString("ProductName"),
                                Price = reader.GetDecimal("Price")
                            };
                            mainDishesList.Add(mainDish);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            return mainDishesList;
        }

        private List<Snack> GetSnacks()
        {
            List<Snack> snacksList = new List<Snack>();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT ID, ProductName, Price FROM snacks";
                    var cmd = new MySqlCommand(stm, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Snack snack = new Snack
                            {
                                Id = reader.GetInt32("ID"),
                                ProductName = reader.GetString("ProductName"),
                                Price = reader.GetDecimal("Price")
                            };
                            snacksList.Add(snack);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            return snacksList;
        }

        private List<Drink> GetDrinks()
        {
            List<Drink> drinksList = new List<Drink>();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT ID, ProductName, Price FROM drinks";
                    var cmd = new MySqlCommand(stm, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Drink drink = new Drink
                            {
                                Id = reader.GetInt32("ID"),
                                ProductName = reader.GetString("ProductName"),
                                Price = reader.GetDecimal("Price")
                            };
                            drinksList.Add(drink);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            return drinksList;
        }

        private List<Desserts> GetDesserts()
        {
            List<Desserts> dessertsList = new List<Desserts>();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT ID, ProductName, Price FROM desserts";
                    var cmd = new MySqlCommand(stm, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Desserts dessert = new Desserts
                            {
                                Id = reader.GetInt32("ID"),
                                ProductName = reader.GetString("ProductName"),
                                Price = reader.GetDecimal("Price")
                            };
                            dessertsList.Add(dessert);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            return dessertsList;
        }
        private void FillMainDishesTextBoxes()
        {
            var mainDishes = GetMainDishes();

            if (mainDishes.Count >= 1) H1.Text = mainDishes[0].Price.ToString();
            if (mainDishes.Count >= 2) H2.Text = mainDishes[1].Price.ToString();
            if (mainDishes.Count >= 3) H3.Text = mainDishes[2].Price.ToString();
            if (mainDishes.Count >= 4) H4.Text = mainDishes[3].Price.ToString();
            if (mainDishes.Count >= 5) H5.Text = mainDishes[4].Price.ToString();
            if (mainDishes.Count >= 6) H6.Text = mainDishes[5].Price.ToString();
            if (mainDishes.Count >= 7) H7.Text = mainDishes[6].Price.ToString();
            if (mainDishes.Count >= 8) H8.Text = mainDishes[7].Price.ToString();
            if (mainDishes.Count >= 9) H9.Text = mainDishes[8].Price.ToString();
            if (mainDishes.Count >= 10) H10.Text = mainDishes[9].Price.ToString();
        }

        private void FillSnacksTextBoxes()
        {
            var snacks = GetSnacks();

            if (snacks.Count >= 1) H11.Text = snacks[0].Price.ToString();
            if (snacks.Count >= 2) H12.Text = snacks[1].Price.ToString();
            if (snacks.Count >= 3) H13.Text = snacks[2].Price.ToString();
            if (snacks.Count >= 4) H14.Text = snacks[3].Price.ToString();
        }

        private void FillDrinksTextBoxes()
        {
            var drinks = GetDrinks();

            if (drinks.Count >= 1) H15.Text = drinks[0].Price.ToString();
            if (drinks.Count >= 2) H16.Text = drinks[1].Price.ToString();
            if (drinks.Count >= 3) H17.Text = drinks[2].Price.ToString();
            if (drinks.Count >= 4) H18.Text = drinks[3].Price.ToString();
        }

        private void FillDessertsTextBoxes()
        {
            var desserts = GetDesserts();

            if (desserts.Count >= 1) H19.Text = desserts[0].Price.ToString();
            if (desserts.Count >= 2) H20.Text = desserts[1].Price.ToString();
            if (desserts.Count >= 3) H21.Text = desserts[2].Price.ToString();
            if (desserts.Count >= 4) H22.Text = desserts[3].Price.ToString();
            if (desserts.Count >= 5) H23.Text = desserts[4].Price.ToString();
        }

        private decimal GetAmount(CheckBox checkBox, TextBox quantityBox, string productName)
        {
            int quantity = 0;
            decimal price = GetPriceFromDatabase(productName);

            if (checkBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(quantityBox.Text))
                {
                    int.TryParse(quantityBox.Text, out quantity);
                }

                return quantity * price;
            }
            return 0;
        }

        private decimal GetPriceFromDatabase(string productName)
        {
            decimal price = 0;
            string query = "SELECT Price FROM maindishes WHERE ProductName = @ProductName " +
                           "UNION ALL SELECT Price FROM snacks WHERE ProductName = @ProductName " +
                           "UNION ALL SELECT Price FROM drinks WHERE ProductName = @ProductName " +
                           "UNION ALL SELECT Price FROM desserts WHERE ProductName = @ProductName";

            using (MySqlConnection conn = new MySqlConnection(SQL.GetConnect()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        decimal.TryParse(result.ToString(), out price);
                    }
                }
            }
            return price;
        }
        private void CalculateTotal()
        {
            decimal total = 0;

            total += GetAmount(R1, H1, "Салат \"Гомер\"");
            total += GetAmount(R2, H2, "Суп \"Римская охота\"");
            total += GetAmount(R3, H3, "Куриные рулетики с сыром");
            total += GetAmount(R4, H4, "Салат \"Виноградная гроздь\" с курицей");
            total += GetAmount(R5, H5, "Дукка по-египетски");
            total += GetAmount(R6, H6, "Паста с соусом песто и курицей");
            total += GetAmount(R7, H7, "Фисташковый стейк с грибным соусом");
            total += GetAmount(R8, H8, "Лосось в медово-горчичном соусе");
            total += GetAmount(R9, H9, "Овощное рагу с пряными травами");
            total += GetAmount(R10, H10, "Говядина по-азиатски с рисом");

            total += GetAmount(R11, H11, "Чипсы из батата");
            total += GetAmount(R12, H12, "Фисташковые гренки с сырным соусом");
            total += GetAmount(R13, H13, "Мини-лепёшки с хумусом");
            total += GetAmount(R14, H14, "Куриные наггетсы с ореховой панировкой");

            total += GetAmount(R15, H15, "Фисташковый латте");
            total += GetAmount(R16, H16, "Малиновый лимонад");
            total += GetAmount(R17, H17, "Облепиховый чай с мёдом");
            total += GetAmount(R18, H18, "Какао с маршмеллоу");

            total += GetAmount(R19, H19, "Шоколадный мусс с фисташками");
            total += GetAmount(R20, H20, "Фисташковый чизкейк");
            total += GetAmount(R21, H21, "Ягодный торт");
            total += GetAmount(R22, H22, "Эклеры с ванильным кремом");
            total += GetAmount(R23, H23, "Брауни с карамелью");

            decimal totalWithDiscount = ApplyDiscount(total);

            H24.Text = totalWithDiscount.ToString("0.00");
        }
        private void PayMoment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PayMoment.SelectedItem?.ToString() == "QR-код")
            {
                LoadQRCodeImage("qrcode.jpg");
            }
            else
            {
                pictureBoxQRCode.Image = null;
            }
        }
        private decimal ApplyDiscount(decimal total)
        {
            string discountText = SellB.SelectedItem.ToString();
            discountText = discountText.Replace("%", "");

            if (decimal.TryParse(discountText, out decimal discount))
            {
                decimal discountAmount = total * (discount / 100);
                return total - discountAmount;
            }
            return total;
        }
        private void LoadQRCodeImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBoxQRCode.Image = Image.FromFile(imagePath);

                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Файл QR-кода не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ssell_Click(object sender, EventArgs e)
        {
            CalculateTotal();
            if (PayMoment.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите метод оплаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем дальнейшее выполнение, пока не будет выбран метод
            }
            if (MessageBox.Show("Оплата прошла успешно?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string paymentMethod = PayMoment.SelectedItem?.ToString();
                string tableNumber = Prompt.ShowDialog("Введите номер столика:", "Столик");

                var orderedItems = GetOrderedItems();

                if (orderedItems.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали ни одного блюда!");
                    return;
                }
                int discountPercent = GetDiscountPercent();
                ReceiptGenerator.GenerateClientReceipt(orderedItems, paymentMethod, tableNumber, discountPercent);

                var kitchenItems = orderedItems.Select(i => (i.Name, i.Quantity)).ToList();
                KitchenOrderGenerator.GenerateKitchenOrder(kitchenItems, tableNumber);
                MessageBox.Show("Чеки успешно созданы на рабочем столе!");
            }

        }
        private List<(string Name, int Quantity, decimal Price)> GetOrderedItems()
        {
            var items = new List<(string, int, decimal)>();

            void AddIfChecked(CheckBox checkBox, TextBox quantityBox, string productName)
            {
                if (checkBox.Checked && int.TryParse(quantityBox.Text, out int qty) && qty > 0)
                {
                    decimal price = GetPriceFromDatabase(productName);
                    items.Add((productName, qty, price));
                }
            }

            AddIfChecked(R1, H1, "Салат \"Гомер\"");
            AddIfChecked(R2, H2, "Суп \"Римская охота\"");
            AddIfChecked(R3, H3, "Куриные рулетики с сыром");
            AddIfChecked(R4, H4, "Салат \"Виноградная гроздь\" с курицей");
            AddIfChecked(R5, H5, "Дукка по-египетски");
            AddIfChecked(R6, H6, "Паста с соусом песто и курицей");
            AddIfChecked(R7, H7, "Фисташковый стейк с грибным соусом");
            AddIfChecked(R8, H8, "Лосось в медово-горчичном соусе");
            AddIfChecked(R9, H9, "Овощное рагу с пряными травами");
            AddIfChecked(R10, H10, "Говядина по-азиатски с рисом");

            AddIfChecked(R11, H11, "Чипсы из батата");
            AddIfChecked(R12, H12, "Фисташковые гренки с сырным соусом");
            AddIfChecked(R13, H13, "Мини-лепёшки с хумусом");
            AddIfChecked(R14, H14, "Куриные наггетсы с ореховой панировкой");

            AddIfChecked(R15, H15, "Фисташковый латте");
            AddIfChecked(R16, H16, "Малиновый лимонад");
            AddIfChecked(R17, H17, "Облепиховый чай с мёдом");
            AddIfChecked(R18, H18, "Какао с маршмеллоу");

            AddIfChecked(R19, H19, "Шоколадный мусс с фисташками");
            AddIfChecked(R20, H20, "Фисташковый чизкейк");
            AddIfChecked(R21, H21, "Ягодный торт");
            AddIfChecked(R22, H22, "Эклеры с ванильным кремом");
            AddIfChecked(R23, H23, "Брауни с карамелью");

            return items;
        }

        private void Start_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void измнеитьЦенуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePrice changePrice = new ChangePrice();
            changePrice.Show();
        }

        private void ИзменитьпараметрыSQLсоединенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSQL changeSQL = new ChangeSQL(); 
            changeSQL.Show();
        }

        private void изменитьПарольДляСкидкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswd changePasswd = new ChangePasswd(); 
            changePasswd.Show();
        }
    }
}

using CafeMenu;
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

namespace CafeMenu
{
    public partial class PasswordForm : Form
    {
        public bool IsPasswordCorrect { get; private set; } = false;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string inputPassword = txtPassword.Text;
            string cs = new SqlConnector().GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Pass FROM Pass WHERE Id = 1";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && inputPassword == result.ToString())
                        {
                            IsPasswordCorrect = true;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

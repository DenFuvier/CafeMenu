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
    public partial class ChangePasswd : Form
    { 
        SqlConnector sqlConnector = new SqlConnector();

        public ChangePasswd()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string cs = sqlConnector.GetConnect();
            string newPassword = PassworfBox.Text;

            try
            {
                var con = new MySqlConnection(cs);
                con.Open();

                string query = $"UPDATE pass SET Pass = '{newPassword}' WHERE Id = 1";
                var cmd = new MySqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Пароль обновлён!");
                }
                else
                {
                    MessageBox.Show("Пароль не был обновлён.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}

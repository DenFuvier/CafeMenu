using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeMenu.Windows
{
    public partial class ChangePasswd : Form
    { 
        SqlConnector sqlConnector = new SqlConnector();

        public ChangePasswd()
        {
            InitializeComponent();
            StyleAllTextBoxes(this);
            Save.MouseEnter += Save_MouseEnter;
            Save.MouseLeave += Save_MouseLeave;
            Save.BackColor = ColorTranslator.FromHtml("#f0efe7");
        }

        private void Save_MouseLeave(object sender, EventArgs e)
        {
            Save.BackColor = ColorTranslator.FromHtml("#f0efe7");
        }

        private void Save_MouseEnter(object sender, EventArgs e)
        {
            Save.BackColor = ColorTranslator.FromHtml("#d4c8b5");
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

        private void ChangePasswd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

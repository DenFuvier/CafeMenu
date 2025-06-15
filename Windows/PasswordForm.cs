using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeMenu
{
    public partial class PasswordForm : Form
    {
        public bool IsPasswordCorrect { get; private set; } = false;

        public PasswordForm()
        {
            InitializeComponent();
            StyleAllTextBoxes(this);
           this.FormClosed += PasswordForm_FormClosed;
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

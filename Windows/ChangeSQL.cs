using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeMenu.Windows
{
    public partial class ChangeSQL : Form
    {
        public ChangeSQL()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            StyleAllTextBoxes(this);
            ExitButton.MouseEnter += ExitButton_MouseEnter;
            ExitButton.MouseLeave += ExitButton_MouseLeave;
            ExitButton.BackColor = ColorTranslator.FromHtml("#f0efe7");
            SaveButton.BackColor = ColorTranslator.FromHtml("#f0efe7");
            SaveButton.MouseEnter += SaveButton_MouseEnter;
            SaveButton.MouseLeave += SaveButton_MouseLeave;
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.BackColor = ColorTranslator.FromHtml("#f0efe7");
        }

        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            SaveButton.BackColor = ColorTranslator.FromHtml("#d4c8b5");
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = ColorTranslator.FromHtml("#f0efe7");
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = ColorTranslator.FromHtml("#d4c8b5");
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
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("config.txt");
            streamWriter.WriteLine(ServerBox.Text);
            streamWriter.WriteLine(LoginBox.Text);
            streamWriter.WriteLine(PasswdBox.Text);
            streamWriter.WriteLine(NameBaseBox.Text);
            streamWriter.Close();     
            Application.Restart();
        }

        private void ChangeSQL_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("config.txt");
            ServerBox.Text = streamReader.ReadLine();
            LoginBox.Text = streamReader.ReadLine();
            PasswdBox.Text = streamReader.ReadLine();
            NameBaseBox.Text = streamReader.ReadLine();
            streamReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChangeSQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

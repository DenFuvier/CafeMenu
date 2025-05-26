using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using System;
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

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
    }
}

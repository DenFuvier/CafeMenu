using System.Windows.Forms;

namespace ArictSKOOLA.Windows
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://t.me/JWOQQ",
                UseShellExecute = true
            });
            this.Close();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://signal.me/#eu/ftUbhiYBMZH-48Dbadgqpvc4UNnlVe4DLh1oheWXPJ5NE_plBmFEa4YtaUJ0eur-",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormContact formContact = new FormContact();
            formContact.Show();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
    
}

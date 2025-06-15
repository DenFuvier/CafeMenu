using System.Windows.Forms;

namespace ArictSKOOLA.Windows
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void linkLabelMailRu_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://e.mail.ru/compose/?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelGmail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.google.com/mail/u/0/?view=cm&fs=1&to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelYandex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.yandex.ru/compose?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelProtonMail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.proton.me/u/0/compose?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }



        private void linkLabelVKMail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.vk.com/",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelRamblerMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.rambler.ru/m/compose?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelYahooMail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://compose.mail.yahoo.com/?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void FormContact_Load(object sender, System.EventArgs e)
        {

        }

        private void linkLabelOutlook_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://outlook.live.com/mail/0/deeplink/compose?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelVivaldiMail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://webmail.vivaldi.net/?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void linkLabelTutaMail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.tutanota.com/mail?to=Findalone@protonmail.com",
                UseShellExecute = true
            });
            this.Close();
        }

        private void FormContact_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

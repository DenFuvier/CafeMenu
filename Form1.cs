using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeMenu
{
    public partial class Start_Form : Form
    {

        public Start_Form()
        {
            InitializeComponent();
            CentreMethod();
            ZeroEnable();
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
        

        }

        private void SellB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

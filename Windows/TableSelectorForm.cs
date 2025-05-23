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
    public partial class TableSelectorForm : Form
    {
        public string SelectedTable { get; private set; }
        public TableSelectorForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            SelectedTable = "maindishes";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TableSelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSoups_Click_1(object sender, EventArgs e)
        {
            SelectedTable = "snacks";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDrinks_Click_1(object sender, EventArgs e)
        {
            SelectedTable = "drinks";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDesserts_Click_1(object sender, EventArgs e)
        {
            SelectedTable = "desserts";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

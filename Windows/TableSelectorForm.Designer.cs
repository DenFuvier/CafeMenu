namespace CafeMenu.Windows
{
    partial class TableSelectorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSoups = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Куда сохранить цену?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(22, 32);
            this.btnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(105, 26);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Основные блюда";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(142, 32);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(105, 26);
            this.btnDrinks.TabIndex = 2;
            this.btnDrinks.Text = "Напитки";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click_1);
            // 
            // btnSoups
            // 
            this.btnSoups.Location = new System.Drawing.Point(22, 65);
            this.btnSoups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoups.Name = "btnSoups";
            this.btnSoups.Size = new System.Drawing.Size(105, 26);
            this.btnSoups.TabIndex = 3;
            this.btnSoups.Text = "Снеки";
            this.btnSoups.UseVisualStyleBackColor = true;
            this.btnSoups.Click += new System.EventHandler(this.btnSoups_Click_1);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(142, 65);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(105, 26);
            this.btnDesserts.TabIndex = 4;
            this.btnDesserts.Text = "Десерты";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click_1);
            // 
            // TableSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 105);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnSoups);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор таблицы";
            this.Load += new System.EventHandler(this.TableSelectorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSoups;
        private System.Windows.Forms.Button btnDesserts;
    }
}

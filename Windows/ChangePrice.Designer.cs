namespace CafeMenu.Windows
{
    partial class ChangePrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dessertsVIEW = new System.Windows.Forms.DataGridView();
            this.drinksVIEW = new System.Windows.Forms.DataGridView();
            this.maindishesVIEW = new System.Windows.Forms.DataGridView();
            this.snacksVIEW = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindishesVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacksVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // dessertsVIEW
            // 
            this.dessertsVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertsVIEW.Location = new System.Drawing.Point(8, 418);
            this.dessertsVIEW.Name = "dessertsVIEW";
            this.dessertsVIEW.ReadOnly = true;
            this.dessertsVIEW.Size = new System.Drawing.Size(330, 91);
            this.dessertsVIEW.TabIndex = 0;
            // 
            // drinksVIEW
            // 
            this.drinksVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinksVIEW.Location = new System.Drawing.Point(7, 286);
            this.drinksVIEW.Name = "drinksVIEW";
            this.drinksVIEW.ReadOnly = true;
            this.drinksVIEW.Size = new System.Drawing.Size(330, 102);
            this.drinksVIEW.TabIndex = 1;
            // 
            // maindishesVIEW
            // 
            this.maindishesVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindishesVIEW.Location = new System.Drawing.Point(7, 161);
            this.maindishesVIEW.Name = "maindishesVIEW";
            this.maindishesVIEW.ReadOnly = true;
            this.maindishesVIEW.Size = new System.Drawing.Size(330, 95);
            this.maindishesVIEW.TabIndex = 2;
            // 
            // snacksVIEW
            // 
            this.snacksVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snacksVIEW.Location = new System.Drawing.Point(7, 36);
            this.snacksVIEW.Name = "snacksVIEW";
            this.snacksVIEW.ReadOnly = true;
            this.snacksVIEW.Size = new System.Drawing.Size(330, 95);
            this.snacksVIEW.TabIndex = 3;
            this.snacksVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.snacksVIEW_CellContentClick);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(263, 515);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Закрыть";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(61)))), ((int)(((byte)(45)))));
            this.lable1.Location = new System.Drawing.Point(4, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(65, 24);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Снеки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(61)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(4, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Основные блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(61)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(4, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Напитки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(61)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(4, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Десерты";
            // 
            // ChangePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(350, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.snacksVIEW);
            this.Controls.Add(this.maindishesVIEW);
            this.Controls.Add(this.drinksVIEW);
            this.Controls.Add(this.dessertsVIEW);
            this.Name = "ChangePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор : ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePrice_FormClosed);
            this.Load += new System.EventHandler(this.ChangePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dessertsVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindishesVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacksVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dessertsVIEW;
        private System.Windows.Forms.DataGridView drinksVIEW;
        private System.Windows.Forms.DataGridView maindishesVIEW;
        private System.Windows.Forms.DataGridView snacksVIEW;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
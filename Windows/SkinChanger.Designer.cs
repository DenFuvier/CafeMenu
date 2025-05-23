namespace CafeMenu.Windows
{
    partial class SkinChanger
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
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(179, 13);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(153, 20);
            this.ID_Box.TabIndex = 0;
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(179, 45);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(153, 20);
            this.ProductNameBox.TabIndex = 1;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(179, 76);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(153, 20);
            this.PriceBox.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(17, 121);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(98, 121);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование блюда :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ваша цена:";
            // 
            // SkinChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.ID_Box);
            this.Name = "SkinChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkinChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
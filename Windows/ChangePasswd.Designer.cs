namespace CafeMenu.Windows
{
    partial class ChangePasswd
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
            this.Save = new System.Windows.Forms.Button();
            this.PassworfBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(214, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(90, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PassworfBox
            // 
            this.PassworfBox.Location = new System.Drawing.Point(12, 12);
            this.PassworfBox.Name = "PassworfBox";
            this.PassworfBox.Size = new System.Drawing.Size(178, 20);
            this.PassworfBox.TabIndex = 1;
            // 
            // ChangePasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 53);
            this.Controls.Add(this.PassworfBox);
            this.Controls.Add(this.Save);
            this.Name = "ChangePasswd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox PassworfBox;
    }
}
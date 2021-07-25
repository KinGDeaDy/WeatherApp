namespace WeatherApp
{
    partial class EnterForm
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
            this.CityLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EnterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityLine
            // 
            this.CityLine.Depth = 0;
            this.CityLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.CityLine.Hint = "Введите город";
            this.CityLine.Location = new System.Drawing.Point(18, 260);
            this.CityLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.CityLine.Name = "CityLine";
            this.CityLine.PasswordChar = '\0';
            this.CityLine.SelectedText = "";
            this.CityLine.SelectionLength = 0;
            this.CityLine.SelectionStart = 0;
            this.CityLine.Size = new System.Drawing.Size(649, 32);
            this.CityLine.TabIndex = 0;
            this.CityLine.UseSystemPasswordChar = false;
            // 
            // EnterButton
            // 
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Depth = 0;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.EnterButton.Location = new System.Drawing.Point(13, 377);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Primary = true;
            this.EnterButton.Size = new System.Drawing.Size(455, 109);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Приложение погода";
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CityLine);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Enter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField CityLine;
        private MaterialSkin.Controls.MaterialRaisedButton EnterButton;
        private System.Windows.Forms.Label label1;
    }
}
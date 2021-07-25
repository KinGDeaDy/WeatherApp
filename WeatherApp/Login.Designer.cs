namespace WeatherApp
{
    partial class Login
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
            this.wrongDataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.passwordFilled = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginFilled = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // wrongDataLabel
            // 
            this.wrongDataLabel.AutoSize = true;
            this.wrongDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongDataLabel.Depth = 0;
            this.wrongDataLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongDataLabel.Location = new System.Drawing.Point(34, 286);
            this.wrongDataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongDataLabel.Name = "wrongDataLabel";
            this.wrongDataLabel.Size = new System.Drawing.Size(361, 27);
            this.wrongDataLabel.TabIndex = 13;
            this.wrongDataLabel.Text = "Неправильный логин или пароль";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(342, 510);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(145, 27);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Регистрация";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 510);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(160, 27);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Нет аккаунта?";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(39, 421);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(448, 2);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(345, 335);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(142, 52);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordFilled
            // 
            this.passwordFilled.Depth = 0;
            this.passwordFilled.Hint = "Пароль";
            this.passwordFilled.Location = new System.Drawing.Point(39, 238);
            this.passwordFilled.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordFilled.Name = "passwordFilled";
            this.passwordFilled.PasswordChar = '*';
            this.passwordFilled.SelectedText = "";
            this.passwordFilled.SelectionLength = 0;
            this.passwordFilled.SelectionStart = 0;
            this.passwordFilled.Size = new System.Drawing.Size(701, 32);
            this.passwordFilled.TabIndex = 8;
            this.passwordFilled.UseSystemPasswordChar = false;
            // 
            // loginFilled
            // 
            this.loginFilled.Depth = 0;
            this.loginFilled.Hint = "Логин";
            this.loginFilled.Location = new System.Drawing.Point(39, 173);
            this.loginFilled.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginFilled.Name = "loginFilled";
            this.loginFilled.PasswordChar = '\0';
            this.loginFilled.SelectedText = "";
            this.loginFilled.SelectionLength = 0;
            this.loginFilled.SelectionStart = 0;
            this.loginFilled.Size = new System.Drawing.Size(701, 32);
            this.loginFilled.TabIndex = 7;
            this.loginFilled.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 588);
            this.Controls.Add(this.wrongDataLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordFilled);
            this.Controls.Add(this.loginFilled);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel wrongDataLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordFilled;
        public MaterialSkin.Controls.MaterialSingleLineTextField loginFilled;
    }
}
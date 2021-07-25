namespace WeatherApp
{
    partial class RegisterForm
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
            this.enterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.registerButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.registerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailLabel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.registerPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.registerLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterLabel.Depth = 0;
            this.enterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.enterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enterLabel.Location = new System.Drawing.Point(455, 550);
            this.enterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(76, 27);
            this.enterLabel.TabIndex = 18;
            this.enterLabel.Text = "Войти";
            this.enterLabel.Click += new System.EventHandler(this.enterLabel_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 550);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(267, 27);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Уже зарегистрированы?";
            // 
            // registerButton
            // 
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Depth = 0;
            this.registerButton.Location = new System.Drawing.Point(12, 408);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Primary = true;
            this.registerButton.Size = new System.Drawing.Size(549, 115);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerName
            // 
            this.registerName.Depth = 0;
            this.registerName.Hint = "Имя";
            this.registerName.Location = new System.Drawing.Point(12, 327);
            this.registerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerName.Name = "registerName";
            this.registerName.PasswordChar = '\0';
            this.registerName.SelectedText = "";
            this.registerName.SelectionLength = 0;
            this.registerName.SelectionStart = 0;
            this.registerName.Size = new System.Drawing.Size(824, 32);
            this.registerName.TabIndex = 15;
            this.registerName.UseSystemPasswordChar = false;
            // 
            // emailLabel
            // 
            this.emailLabel.Depth = 0;
            this.emailLabel.Hint = "Ваш email";
            this.emailLabel.Location = new System.Drawing.Point(12, 262);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.PasswordChar = '\0';
            this.emailLabel.SelectedText = "";
            this.emailLabel.SelectionLength = 0;
            this.emailLabel.SelectionStart = 0;
            this.emailLabel.Size = new System.Drawing.Size(824, 32);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.UseSystemPasswordChar = false;
            // 
            // registerPassword
            // 
            this.registerPassword.Depth = 0;
            this.registerPassword.Hint = "Пароль";
            this.registerPassword.Location = new System.Drawing.Point(12, 191);
            this.registerPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '\0';
            this.registerPassword.SelectedText = "";
            this.registerPassword.SelectionLength = 0;
            this.registerPassword.SelectionStart = 0;
            this.registerPassword.Size = new System.Drawing.Size(824, 32);
            this.registerPassword.TabIndex = 11;
            this.registerPassword.UseSystemPasswordChar = false;
            // 
            // registerLogin
            // 
            this.registerLogin.Depth = 0;
            this.registerLogin.Hint = "Логин";
            this.registerLogin.Location = new System.Drawing.Point(12, 122);
            this.registerLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerLogin.Name = "registerLogin";
            this.registerLogin.PasswordChar = '\0';
            this.registerLogin.SelectedText = "";
            this.registerLogin.SelectionLength = 0;
            this.registerLogin.SelectionStart = 0;
            this.registerLogin.Size = new System.Drawing.Size(824, 32);
            this.registerLogin.TabIndex = 10;
            this.registerLogin.UseSystemPasswordChar = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 619);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerName);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerLogin);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel enterLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton registerButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField registerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField registerPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField registerLogin;
    }
}
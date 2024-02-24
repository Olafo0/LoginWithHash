namespace LoginWithHash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            LoginPanel = new Panel();
            button1 = new Button();
            label3 = new Label();
            LoginPassword = new TextBox();
            label2 = new Label();
            LoginUsername = new TextBox();
            signUpLabel = new Label();
            SignUpPanel = new Panel();
            AccountCreatedNotice = new Label();
            registerButton = new Button();
            label4 = new Label();
            PasswordTextbox = new TextBox();
            label5 = new Label();
            UsernameTextbox = new TextBox();
            loginLabel = new Label();
            PasswordChecker = new Button();
            LoginPanel.SuspendLayout();
            SignUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 11);
            label1.Name = "label1";
            label1.Size = new Size(209, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome to {x}";
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(button1);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(LoginPassword);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(LoginUsername);
            LoginPanel.Controls.Add(signUpLabel);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(47, 12);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(376, 383);
            LoginPanel.TabIndex = 1;
            LoginPanel.Visible = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(147, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(114, 192);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(146, 23);
            LoginPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 110);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // LoginUsername
            // 
            LoginUsername.Location = new Point(114, 127);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(146, 23);
            LoginUsername.TabIndex = 2;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Cursor = Cursors.Hand;
            signUpLabel.ForeColor = Color.MidnightBlue;
            signUpLabel.Location = new Point(104, 293);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(174, 15);
            signUpLabel.TabIndex = 1;
            signUpLabel.Text = "Don't have an account? &Sign up";
            signUpLabel.Click += signUpLabel_Click;
            // 
            // SignUpPanel
            // 
            SignUpPanel.Controls.Add(AccountCreatedNotice);
            SignUpPanel.Controls.Add(registerButton);
            SignUpPanel.Controls.Add(label4);
            SignUpPanel.Controls.Add(PasswordTextbox);
            SignUpPanel.Controls.Add(label5);
            SignUpPanel.Controls.Add(UsernameTextbox);
            SignUpPanel.Controls.Add(loginLabel);
            SignUpPanel.Location = new Point(47, 12);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(376, 383);
            SignUpPanel.TabIndex = 2;
            // 
            // AccountCreatedNotice
            // 
            AccountCreatedNotice.AutoSize = true;
            AccountCreatedNotice.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountCreatedNotice.ForeColor = Color.ForestGreen;
            AccountCreatedNotice.Location = new Point(91, 14);
            AccountCreatedNotice.Name = "AccountCreatedNotice";
            AccountCreatedNotice.Size = new Size(190, 21);
            AccountCreatedNotice.TabIndex = 13;
            AccountCreatedNotice.Text = "You've created an account";
            // 
            // registerButton
            // 
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(144, 219);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 12;
            registerButton.Text = "Sign up";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 157);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 11;
            label4.Text = "Create a Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(111, 174);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(146, 23);
            PasswordTextbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 92);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 9;
            label5.Text = "Create a Username";
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(111, 109);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(146, 23);
            UsernameTextbox.TabIndex = 8;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.ForeColor = Color.MidnightBlue;
            loginLabel.Location = new Point(125, 275);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(123, 15);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Go back to login page";
            loginLabel.Click += loginLabel_Click;
            // 
            // PasswordChecker
            // 
            PasswordChecker.Location = new Point(12, 405);
            PasswordChecker.Name = "PasswordChecker";
            PasswordChecker.Size = new Size(163, 33);
            PasswordChecker.TabIndex = 3;
            PasswordChecker.Text = "Check Passwords";
            PasswordChecker.UseVisualStyleBackColor = true;
            PasswordChecker.Click += PasswordChecker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(PasswordChecker);
            Controls.Add(LoginPanel);
            Controls.Add(SignUpPanel);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            SignUpPanel.ResumeLayout(false);
            SignUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel LoginPanel;
        private Label signUpLabel;
        private Label label2;
        private TextBox LoginUsername;
        private Button button1;
        private Label label3;
        private TextBox LoginPassword;
        private Panel SignUpPanel;
        private Button registerButton;
        private Label label4;
        private TextBox PasswordTextbox;
        private Label label5;
        private TextBox UsernameTextbox;
        private Label loginLabel;
        private Label AccountCreatedNotice;
        private Button PasswordChecker;
    }
}
using System.Security.Cryptography;
using System.Text;

namespace LoginWithHash
{
    public partial class Form1 : Form
    {

        List<Account> currentAccounts = new List<Account>();


        public Form1()
        {
            InitializeComponent();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            SignUpPanel.Visible = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string inputtedUsername = UsernameTextbox.Text;
            string inputtedPassword = PasswordTextbox.Text;

            string hashedPassword = HashPassword(inputtedPassword);

            Account newAccount = new Account(inputtedUsername, hashedPassword);
            currentAccounts.Add(newAccount);

            AccountCreatedNotice.Visible = true;
        }



        private string HashPassword(string inputtedPassword)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                // converts the provided string into bytes and stores the results hashed
                byte[] hashedBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(inputtedPassword));

                StringBuilder builder = new StringBuilder();

                // iterate through each byte
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    /* because of the x2 it converts the byte to a hexadecimal string with two characters. this is done 
                    because it makes it more readable and more suitable for storage and transmission
                    */
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string inputtedLoginPassword, string savedLoginPassword)
        {
            // Hashes the password 
            string hashedInputePassword = HashPassword(inputtedLoginPassword);
            return hashedInputePassword == savedLoginPassword;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = false;
            LoginPanel.Visible = true;
            AccountCreatedNotice.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var account in currentAccounts)
            {
                if (account.UserName == LoginUsername.Text)
                {
                    if (VerifyPassword(LoginPassword.Text, account.HashedPassword) == true)
                    {
                        MessageBox.Show("Logged in");
                        break;
                    }
                }
            }
        }

        private void PasswordChecker_Click(object sender, EventArgs e)
        {
            int postionYPasswordLabel = 0;

            Form tempform = new Form();

            tempform.Size = new Size(200, 400);
            tempform.FormBorderStyle = FormBorderStyle.FixedSingle;
            tempform.AutoScroll = true;
            foreach (var account in currentAccounts)
            {
                Label passwordLabel = new Label();
                Label userLabel = new Label();
                userLabel.Text = $"U:{account.UserName}";
                userLabel.Width = 70;
                userLabel.AutoSize = false;
                userLabel.AutoEllipsis = true;
                userLabel.Location = new Point(0, postionYPasswordLabel);
                passwordLabel.Text = $"P:{account.HashedPassword}";
                passwordLabel.Location = new Point(70, postionYPasswordLabel);
                postionYPasswordLabel += 20;
                tempform.Controls.Add(userLabel);
                tempform.Controls.Add(passwordLabel);
            }
            tempform.ShowDialog();

        }
    }
}
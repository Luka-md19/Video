using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string adminFilePath = "admin.csv";
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (CheckAdminCredentials(adminFilePath, username, password))
            {
                new Form2().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckAdminCredentials(string adminFilePath, string username, string password)
        {
            foreach (var record in File.ReadAllLines(adminFilePath))
            {
                var fields = record.Split('|');
                if (fields[0] == username && fields[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

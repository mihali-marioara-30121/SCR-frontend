using System;
using System.Windows.Forms;

namespace SCD_Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            String username = username_textBox.Text.ToString();
            String password = password_textBox.Text.ToString();
            LoginService loginService = new LoginService();
            String authResponse = loginService.SendAuthenticatedRequest(username, password);
            Console.WriteLine(authResponse);
        }
    }
}

using SCD_Frontend.services;
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
            String role = null;
            string securityKey = "404E635266556A586E3272357538782F413F4428472B4B6250645367566B5970";
            if (authResponse != "Authentication failed") {
                 role = JwtDecoderService.GetRoleFromJwt(authResponse);
            }

            if (authResponse == "Authentication failed" || role != "ADMIN")
            {
                MessageBox.Show("Authentication failed");
            } else
            {
                MessageBox.Show("Authentication sucessfull");
            }

        }
    }
}

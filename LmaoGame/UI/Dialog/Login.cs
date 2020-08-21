using DarkUI.Forms;
using LmaoGame.Properties;
using ProjectPRN_DAOTesting.DAL;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class Login : DarkForm
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Login(int x, int y) : this()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Load += (o, e) =>
            {
                this.SetDesktopLocation(x, y);
            };
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Point desktopLocation = this.DesktopLocation;
            new Register(desktopLocation.X, desktopLocation.Y).Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;

            // TODO: Verify Account
            AccountDAO accountDAO = new AccountDAO();
            Account account = accountDAO.Login(username, password);
            if (account == null)
            {
                DarkMessageBox.ShowError("Your account is incorrect, please try again!", "bruh");
                return;
            }
            UserControl.User = account;
            this.Dispose();
        }
    }
}

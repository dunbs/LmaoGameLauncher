using DarkUI.Controls;
using DarkUI.Forms;
using ProjectPRN_DAOTesting.DAL;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class Register : DarkForm
    {
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Register(int x, int y) : this()
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
            new Login(desktopLocation.X, desktopLocation.Y).Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbUsername.Text;
            string password = tbPassword.Text;
            string cfPassword = tbCfPassword.Text;
            string email = tbEmail.Text;
            string nickname = tbNickName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                DarkMessageBox.ShowError("You forgot to fill your username?\nWhat a loser!", "Bruh");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                DarkMessageBox.ShowError("You forgot to fill your password?\nWhat a loser!", "Bruh");
                return;
            }

            if (!string.Equals(cfPassword, password))
            {
                DarkMessageBox.ShowError("Check your password.\nPassword and Confirm password does not match!", "Bruh");
                return;
            }

            try
            {
                _ = new MailAddress(email);
            }
            catch (Exception)
            {
                DarkMessageBox.ShowError("Are you sure that's an email?\n We don't think so!", "Bruh");
                return;
            }

            if (string.IsNullOrWhiteSpace(nickname))
            {
                if (DarkMessageBox.ShowInformation("You haven't entered your nickname!\nWould you like to use your username as your nickname?",
                    "Attention please!", DarkDialogButton.YesNo)
                    != DialogResult.Yes) return;
            }

            AccountDAO accountDAO = new AccountDAO();
            if (accountDAO.GetAccount(name) != null)
            {
                DarkMessageBox.ShowError("Username has been used!", "Sorry");
                return;
            }

            Account account = new Account
            {
                Name = nickname,
                Email = email,
                Password = password,
                Image = pbAva.Image,
                Username = name
            };

            accountDAO.Register(name, password, nickname, email, pbAva.Image);
            UserControl.User = accountDAO.GetAccount(name);
            this.Dispose();
        }

        private void btnAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbAva.Image = new Bitmap(open.FileName);
            }
        }
    }
}

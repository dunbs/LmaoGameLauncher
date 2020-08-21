using DarkUI.Forms;
using LmaoGame.UI.Dialog;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class Profile : DarkForm
    {
        public Profile()
        {
            InitializeComponent();
            this.tbNickName.BackColor = this.BackColor;
            this.tbEmail.BackColor = this.BackColor;
            this.tbPassword.BackColor = this.BackColor;
            this.tbUsername.BackColor = this.BackColor;
        }

        private void darkTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Done"))
            {
                // Finish Edit
                // Validate
                string name = tbUsername.Text;
                string password = tbPassword.Text;
                string cfPassword = tbConfirmPassword.Text;
                string email = tbEmail.Text;
                string nickname = tbNickName.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    DarkMessageBox.ShowError("You forget to fill your username?\nWhat a loser!", "Bruh");
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    DarkMessageBox.ShowError("You forget to fill your password?\nWhat a loser!", "Bruh");
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
                        != DialogResult.Yes)
                    {
                        this.tbNickName.Text = nickname;
                        return;
                    }
                }

                // TODO: Update user's info

                AccountDAO accountDAO = new AccountDAO();
                Account account = new Account()
                {
                    Email = this.tbEmail.Text,
                    Id = UserControl.User.Id,
                    Image = this.pbAva.Image,
                    Name = this.tbNickName.Text,
                    Password = this.tbPassword.Text,
                    Username = UserControl.User.Username
                };
                accountDAO.EditProfile(account);
                UserControl.User = account;

                this.tbNickName.BackColor = this.BackColor;
                this.tbEmail.BackColor = this.BackColor;
                this.tbPassword.BackColor = this.BackColor;
                this.tbUsername.BackColor = this.BackColor;
                this.tbNickName.ReadOnly = true;
                this.tbEmail.ReadOnly = true;
                this.tbPassword.ReadOnly = true;
                this.tbUsername.ReadOnly = true;
                this.tbNickName.BorderStyle = BorderStyle.None;
                this.tbEmail.BorderStyle = BorderStyle.None;
                this.tbPassword.BorderStyle = BorderStyle.None;
                this.tbUsername.BorderStyle = BorderStyle.None;
                this.lbConfirmPassword.Visible = false;
                this.tbConfirmPassword.Visible = false;
                this.btnNewAva.Visible = false;
                this.btnEdit.Text = "Edit";
                this.linkCancel.Visible = false;
            }
            else
            {
                // Begin Edit
                // Check for password
                btnEdit.Enabled = false;
                string cfPassword = Input.GetInput();
                btnEdit.Enabled = true;
                if (cfPassword == null)
                {
                    return;
                }

                if (!cfPassword.Equals(UserControl.User.Password))
                {
                    DarkMessageBox.ShowError("Wrong Password!", "Alert");
                    return;
                }

                // Setting view
                this.tbNickName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
                this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
                this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
                //this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
                this.tbNickName.ReadOnly = false;
                this.tbEmail.ReadOnly = false;
                this.tbPassword.ReadOnly = false;
                //this.tbUsername.ReadOnly = false;
                this.tbNickName.BorderStyle = BorderStyle.FixedSingle;
                this.tbEmail.BorderStyle = BorderStyle.FixedSingle;
                this.tbPassword.BorderStyle = BorderStyle.FixedSingle;
                //this.tbUsername.BorderStyle = BorderStyle.FixedSingle;
                this.lbConfirmPassword.Visible = true;
                this.btnNewAva.Visible = true;
                this.tbConfirmPassword.Visible = true;
                this.btnEdit.Text = "Done";
                this.linkCancel.Visible = true;
            }
        }

        private void btnNewAva_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbAva.Image = new Bitmap(open.FileName);
            }
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tbNickName.BackColor = this.BackColor;
            this.tbEmail.BackColor = this.BackColor;
            this.tbPassword.BackColor = this.BackColor;
            this.tbUsername.BackColor = this.BackColor;
            this.tbNickName.ReadOnly = true;
            this.tbEmail.ReadOnly = true;
            this.tbPassword.ReadOnly = true;
            this.tbUsername.ReadOnly = true;
            this.tbNickName.BorderStyle = BorderStyle.None;
            this.tbEmail.BorderStyle = BorderStyle.None;
            this.tbPassword.BorderStyle = BorderStyle.None;
            this.tbUsername.BorderStyle = BorderStyle.None;
            this.lbConfirmPassword.Visible = false;
            this.tbConfirmPassword.Visible = false;
            this.btnNewAva.Visible = false;
            this.btnEdit.Text = "Edit";
            Profile_Load(null, null);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Account account = UserControl.User;
            this.tbEmail.Text = account.Email;
            this.tbNickName.Text = account.Name;
            this.tbPassword.Text = account.Password;
            this.tbUsername.Text = account.Username;
            this.tbConfirmPassword.Text = account.Password;
            this.pbAva.Image = account.Image;
        }
    }
}

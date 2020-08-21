using DarkUI.Forms;
using LmaoGame.Common;
using LmaoGame.UI;
using LmaoGame.UI.LmaoEvent;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame
{
    public partial class MainScreen : DarkForm
    {
        string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainScreen()
        {
            InitializeComponent();
            AddForm(new WelcomeScreen());
            this.FormBorderStyle = FormBorderStyle.None;
            SetLoggedOutState();
            UserControl.LoginStateChanged += UserStateHandler;
        }

        private void UserStateHandler(object sender, LoginStateChanged_EventArgs e)
        {
            if (e.IsLoggedIn)
            {
                this.SetLoggedInState();
                return;
            }
            this.SetLoggedOutState();
        }

        private void SetLoggedOutState()
        {
            this.avatar.Image = null;
            this.btnProfile.Text = "Login Now";
            this.btnLibrary.Visible = false;
            this.btnLogout.Visible = false;
            this.panel1.Controls.Clear();
            AddForm(new WelcomeScreen());
        }

        private void SetLoggedInState()
        {
            Account account = UserControl.User;
            this.avatar.Image = account.Image;
            this.btnProfile.Text = account.Name;
            this.btnLibrary.Visible = true;
            this.btnLogout.Visible = true;
        }


        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 90, 93, 95));
            e.Graphics.DrawLine(pen, 270, 32, 270, this.Size.Height - 25);
        }

        private void AddForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(f);
        }

        private void RequestChangeView_EventHandler(object sender, RequestChangeView_EventArgs e)
        {
            AddForm(e.RequestedForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!UserControl.IsLoggedIn)
            {
                Login login = new Login();
                login.Show();
                return;
            }



            Profile f = new Profile();
            AddForm(f);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.RequestChangeView += RequestChangeView_EventHandler;
            AddForm(library);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            btnStore.BackColor = Color.Green;
            Store store = new Store();
            store.RequestChangeView += RequestChangeView_EventHandler;
            AddForm(store);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserControl.RequestLogout();
        }


        /* Title move */
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0);

        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void darkTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!darkTextBox1.Text.Equals(LmaoConstant.SPECIAL_CODE)) return;

        }
    }
}

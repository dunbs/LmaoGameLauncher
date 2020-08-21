using DarkUI.Forms;
using LmaoGame.EpicGameLancherDataSetTableAdapters;
using LmaoGame.Properties;
using LmaoGame.UI.LmaoEvent;
using ProjectPRN_DAOTesting.DAL;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class GameInfomation : DarkForm
    {
        public event EventHandler<RequestChangeView_EventArgs> RequestChangeView;
        protected bool isOwned;
        protected Game game;
        private readonly List<Label> stars;

        public GameInfomation()
        {
            InitializeComponent();
        }

        public GameInfomation(bool isOwned, Game game)
        {
            InitializeComponent();
            this.game = game;
            this.gameAction_btn.Text = this.game.IsOwned ? "Play Now" : "Buy Now";
            this.isOwned = isOwned;
            stars = new List<Label>()
            {
                this.lbStar1,
                this.lbStar2,
                this.lbStar3,
                this.lbStar4,
                this.lbStar5
            };
            UserControl.LoginStateChanged += (o, e) =>
            {
                if (!e.IsLoggedIn)
                {
                    this.game.IsOwned = false;
                    return;
                }
                GameDAO gameDAO = new GameDAO();
                this.game = gameDAO.GetGameByID(this.game.Id, UserControl.User.Id);
                SetInfo();
            };
            SetInfo();

        }

        protected virtual void UpdateInfo() { }

        private void SetInfo()
        {
            this.lbGameName.Text = game.Name;
            this.pbImage.Image = game.Image;
            this.pbImage.BackgroundImage = game.Image == null ? Resources.image_not_found : game.Image;
            this.gameAction_btn.Text = this.game.IsOwned ? "Play Now" : "Buy Now";
            this.SetUserRating();
            UpdateInfo();
        }

        private void GameAction_btn_Click(object sender, EventArgs e)
        {
            if (this.game.IsOwned) PlayGame();
            else BuyGame();
        }

        private void BuyGame()
        {
            // User must login to buy game
            if (!UserControl.IsLoggedIn)
            {
                UserControl.RequestLogin();
                return;
            }

            // TODO: Call DAL to insert new game into DB
            GameDAO gameDAO = new GameDAO();
            gameDAO.BuyGame(UserControl.User.Id, this.game.Id);

            MessageBox.Show("Enjoy your game ^^!".ToUpper());

            this.game.IsOwned = true;
            SetInfo();

        }

        private void TakeReview(object sender, MouseEventArgs e)
        {
            if (!UserControl.IsLoggedIn)
            {
                UserControl.RequestLogin();
                return;
            }

            if (!this.game.IsOwned)
            {
                DarkMessageBox.ShowError("You have to buy the game to rate it!", "Bruh");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you are not misclicking?", "Taking Review", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            // TODO: Call DAL to insert review into DB


            bool checkedStarReached = false;
            int ratingStar = 0;
            foreach (Label item in this.stars)
            {
                item.ForeColor = checkedStarReached ? Color.Gainsboro : Color.Yellow;
                if (!checkedStarReached) ++ratingStar;
                if (sender as Label == item) checkedStarReached = true;
            }

            GameDAO ratingDAO = new GameDAO();

            if (!ratingDAO.Rating(UserControl.User.Id, this.game.Id, ratingStar))
            {
                ratingDAO.EditRating(UserControl.User.Id, this.game.Id, ratingStar);
            }

            GameDAO gameDAO = new GameDAO();
            this.game = gameDAO.GetGameByID(this.game.Id, UserControl.User.Id);
            SetInfo();

        }

        private void SetUserRating()
        {
            GameDAO gameDAO = new GameDAO();
            int? rating = gameDAO.GetRatingByUser(UserControl.User?.Id, this.game.Id);
            for (int i = 0; i < stars.Count; i++)
            {
                Label item = this.stars[i];
                item.ForeColor = i + 1 > rating ? Color.Gainsboro : Color.Yellow;
            }
        }

        static readonly Random random = new Random();

        private void PlayGame()
        {
            int num = random.Next(2);
            byte[] myResBytes;
            if (num == 0)
            {
                myResBytes = Resources.PuzzleGame;
            }
            else
            {
                myResBytes = Resources.DemoFlappyBird;
            }

            if (File.Exists("bruh.jar"))
            {
                try
                {
                    File.Delete("bruh.jar");
                }
                catch
                {
                }
            }
            try
            {
                using (FileStream fsDst = new FileStream("bruh.jar", FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = myResBytes;
                    fsDst.Write(bytes, 0, bytes.Length);
                    fsDst.Close();
                    fsDst.Dispose();
                }
            }
            catch
            {
            }

            if (num == 1)
            {
                try
                {
                    if (File.Exists("lib/AbsoluteLayout.jar"))
                    {
                        File.Delete("lib/AbsoluteLayout.jar");
                    };
                    if (File.Exists("lib/flatlaf-core-0.9.jar"))
                    {
                        File.Delete("lib/flatlaf-core-0.9.jar");
                    };
                    if (File.Exists("lib/flatlaf-swingx-0.28.jar"))
                    {
                        File.Delete("lib/flatlaf-swingx-0.28.jar");
                    };

                    Directory.CreateDirectory(Path.GetDirectoryName("lib/"));

                    using (FileStream fsDst = new FileStream("lib/AbsoluteLayout.jar", FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] bytes = Resources.AbsoluteLayout;
                        fsDst.Write(bytes, 0, bytes.Length);
                        fsDst.Close();
                        fsDst.Dispose();
                    };
                    using (FileStream fsDst = new FileStream("lib/flatlaf-core-0.9.jar", FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] bytes = Resources.flatlaf_core_0_9;
                        fsDst.Write(bytes, 0, bytes.Length);
                        fsDst.Close();
                        fsDst.Dispose();
                    };
                    using (FileStream fsDst = new FileStream("lib/flatlaf-swingx-0.28.jar", FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] bytes = Resources.flatlaf_swingx_0_28;
                        fsDst.Write(bytes, 0, bytes.Length);
                        fsDst.Close();
                        fsDst.Dispose();
                    };
                }
                catch
                {

                    throw;
                }
            }

            System.Diagnostics.Process.Start("bruh.jar");

            GameDAO gameDAO = new GameDAO();
            gameDAO.AddAccess(this.game.Id);
            this.game.Access++;
            SetInfo();
        }

        protected void RequestChangeView_Handler(object sender, RequestChangeView_EventArgs e)
        {
            RequestChangeView?.Invoke(sender, e);
        }
    }
}

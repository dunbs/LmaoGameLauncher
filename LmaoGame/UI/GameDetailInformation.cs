using DarkUI.Controls;
using DarkUI.Forms;
using LmaoGame.UI.LmaoEvent;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class GameDetailInformation : GameInfomation
    {
        public GameDetailInformation(bool isOwned, Game game) : base(isOwned, game)
        {
            InitializeComponent();
        }

        private void btnDLC_Click(object sender, EventArgs e)
        {
            GameDLCInformation requestedForm = new GameDLCInformation(this.isOwned, this.game);
            base.RequestChangeView_Handler(sender, new RequestChangeView_EventArgs(requestedForm));
        }

        protected override void UpdateInfo()
        {
            if (this.lbDeveloper == null) return;
            this.lbDeveloper.Text = "Ubisoft";
            this.lbGenre.Text = game.Gerne.Name;
            this.lbReleaseDate.Text = game.ReleaseDate.ToString("MMM dd, yyyy");
            this.tbDescription.Text = game.Description;
            this.lbAccess.Text = game.Access.ToString();
            this.tbRating.Text = game.ReviewScore == -1 ? "Be the first to review" : game.ReviewScore.ToString();
        }

        private void GameDetailInformation_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }

}

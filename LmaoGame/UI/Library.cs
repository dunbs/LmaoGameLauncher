using DarkUI.Forms;
using LmaoGame.Common;
using LmaoGame.UI.LmaoEvent;
using LmaoGame.UI.Model;
using ProjectPRN_DAOTesting.DAL;
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
    public partial class Library : BrowseGames
    {
        public Library()
        {
            InitializeComponent();
            base.TotalPage = 1;
        }

        protected override void DisplayGames(int currentPage)
        {
            //GameDAO gameDAO = new GameDAO();
            //List<Game> games = gameDAO.GetLibrary(LmaoConstant.PAGE_SIZE, currentPage, UserControl.User.Id);
            //base.AddGames(games);
        }

        protected override void DisplayGames(int userid, int size, int page, String gameName, Dictionary<String, bool> attributes, List<int> gernes)
        {
            GameDAO gameDAO = new GameDAO();
            base.AddGames(gameDAO.GetGamePage(userid, size, page, gameName, attributes, true, gernes));
        }

        protected override void ViewGame(int id)
        {
            //throw new NotImplementedException();
        }

        public override void game_Click(object sender, EventArgs e)
        {
            GameDetailInformation gameInfoForm = new GameDetailInformation(true, (sender as GameComponent).Game);
            base.RequestChangeViewInvoke(this, new RequestChangeView_EventArgs(gameInfoForm));

            // Navigate between DLC and Detail view of the game
            gameInfoForm.RequestChangeView += RequestChangeView_Handler;
        }

        private void RequestChangeView_Handler(object o, RequestChangeView_EventArgs r)
        {
            base.RequestChangeViewInvoke(o, r);
            (r.RequestedForm as GameInfomation).RequestChangeView += RequestChangeView_Handler;
        }
    }


}

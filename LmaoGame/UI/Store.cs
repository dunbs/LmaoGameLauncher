using DarkUI.Forms;
using LmaoGame.Common;
using LmaoGame.UI.LmaoEvent;
using LmaoGame.UI.Model;
using ProjectPRN_DAOTesting.DAL;
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
    public partial class Store : BrowseGames
    {
        public Store()
        {
            InitializeComponent();
            this.Title("STORE");
            UserControl.LoginStateChanged += (o, e) =>
            {
                Search(null, null);
            };
        }

        protected override void DisplayGames(int currentPage)
        {
            //throw new NotImplementedException();
        }

        protected override void DisplayGames(int userid, int size, int page, String gameName, Dictionary<String, bool> attributes, List<int> gernes)
        {
            GameDAO gameDAO = new GameDAO();
            if (page == 1)
            {
                int totalGames = gameDAO.getMaxPage(userid, gameName, false, gernes);
                int totalPage = totalGames / LmaoConstant.PAGE_SIZE;

                this.TotalPage = totalGames % LmaoConstant.PAGE_SIZE == 0 ? totalPage : totalPage + 1;
            }

            base.AddGames(gameDAO.GetGamePage(userid, size, page, gameName, attributes, false, gernes));
        }


        public override void game_Click(object sender, EventArgs e)
        {
            GameDetailInformation gameInfoForm = new GameDetailInformation(false, (sender as GameComponent).Game);
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

using DarkUI.Forms;
using LmaoGame.UI.LmaoEvent;
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
    public partial class GameDLCInformation : GameInfomation
    {

        public GameDLCInformation()
        {
            InitializeComponent();
        }

        protected override void UpdateInfo()
        {
            GameDLCInformation_Load(null, null);
        }

        public GameDLCInformation(bool isOwned, Game game) : base(isOwned, game)
        {
            InitializeComponent();
            //this.dlc_dataGridView.ColumnHeadersVisible = false;
            this.isOwned = isOwned;
        }

        private void DLC_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(dlc_dataGridView.Rows[e.RowIndex].Selected.ToString());

        }

        private void GameDLCInformation_Load(object sender, EventArgs e)
        {
            if (dlc_dataGridView == null) return;
            DLCDAO dlcDAO = new DLCDAO();
            this.dlc_dataGridView.AutoGenerateColumns = false;
            this.dlc_dataGridView.DataSource = dlcDAO.GetDLCbyGameid(this.game.Id);
            this.dlc_dataGridView.ReadOnly = true;
            this.dlc_dataGridView.ClearSelection();

        }

        private void dlc_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dlc_dataGridView.Rows[e.RowIndex].Selected = false;
        }

        private void btnBuyDLC_Click(object sender, EventArgs e)
        {
            if (!UserControl.IsLoggedIn)
            {
                UserControl.RequestLogin();
                return;
            }

            if (!this.game.IsOwned)
            {
                DarkMessageBox.ShowInformation("You have to buy the game before buying DLCs!", "Bruh");
                return;
            }

            if (dlc_dataGridView.SelectedRows.Count == 0)
            {
                DarkMessageBox.ShowInformation("You haven't chosen any DLCs!", "Bruh");
                return;
            }

            bool isNotOwnedExist = false;
            DLCDAO dlcDAO = new DLCDAO();
            foreach (DataGridViewRow item in dlc_dataGridView.SelectedRows)
            {
                if ((string)item.Cells[6].Value != "") return;
                isNotOwnedExist = true;
                int dlcId = (int)item.Cells[0].Value;
                dlcDAO.AddDLC(dlcId, UserControl.User.Id);
            }

            if (!isNotOwnedExist)
            {
                DarkMessageBox.ShowError("You have owned all those DLCs!", "Bruh");
                return;
            }

            DarkMessageBox.ShowInformation("Enjoy your new game mechanic ^^!", "Hi");
            GameDLCInformation_Load(null, null);

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            GameDetailInformation requestedForm = new GameDetailInformation(this.isOwned, this.game);
            base.RequestChangeView_Handler(sender, new RequestChangeView_EventArgs(requestedForm));
        }

        private void dlc_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

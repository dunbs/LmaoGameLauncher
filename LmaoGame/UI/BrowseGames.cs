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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class BrowseGames : DarkForm
    {
        static readonly int TIME_APPEAR = 20;
        static readonly int TIME_FADE = 30;
        private int currentPage;
        private int totalPage;
        private int totalGenre;

        protected int TotalPage
        {
            get => totalPage; set
            {
                totalPage = value;
                lbTotalPageIdx.Text = value.ToString();
                SetButtonState();
            }
        }
        public int CurrentPage
        {
            get => currentPage; set
            {
                currentPage = value;
                btnPageIndex.Text = value.ToString();
                SetButtonState();
            }
        }

        public event EventHandler<RequestChangeView_EventArgs> RequestChangeView;

        public BrowseGames()
        {
            InitializeComponent();
            CurrentPage = 1;
        }

        protected void Title(string name)
        {
        }


        protected virtual void DisplayGames(int currentPage) { }

        protected virtual void DisplayGames(int userid, int size, int page, String gameName, Dictionary<String, bool> attributes, List<int> gernes)
        { }

        protected void Search(object sender, EventArgs e)
        {
            this.tbl.Controls.Clear();

            // Search key word
            List<int> genre = new List<int>();
            foreach (DataRowView item in clbGenre.CheckedItems)
            {
                genre.Add((int)item.Row.ItemArray[0]);
            }

            Dictionary<String, bool> attributes = new Dictionary<string, bool>();
            if (lbSortName.Font.Bold)
            {
                attributes.Add(LmaoConstant.NAME, this.sortName.Text == "↓");
            };
            if (lbSortPrice.Font.Bold)
            {
                attributes.Add(LmaoConstant.PRICE, this.sortPrice.Text != "↓");
            };
            if (lbSortReleaseDate.Font.Bold)
            {
                attributes.Add(LmaoConstant.REALEASE_DATE, this.sortReleaseDate.Text == "↓");
            };
            if (lbSortReview.Font.Bold)
            {
                attributes.Add(LmaoConstant.REVIEW, this.sortReview.Text == "↓");
            };

            if (attributes.Count == 0) attributes.Add(LmaoConstant.REALEASE_DATE, true);

            DisplayGames(UserControl.User == null ? -1 : UserControl.User.Id,
                LmaoConstant.PAGE_SIZE,
                currentPage,
                this.tbSearchName.Text == "Search for games..." ? "" : this.tbSearchName.Text,
                attributes,
                genre);
        }

        protected virtual void ViewGame(int id) { }

        protected void DisplayGenre()
        {
            ListBox listBox = this.clbGenre;
            GerneDAO gerneDAO = new GerneDAO();
            DataTable genreDataTables = gerneDAO.getAll();
            totalGenre = genreDataTables.Rows.Count;
            listBox.DataSource = genreDataTables;
            listBox.ValueMember = "id";
            listBox.DisplayMember = "name";
        }

        protected void AddGame(Game game)
        {
            GameComponent panel = new GameComponent(game);
            panel.Game_Click += this.game_Click;
            panel.Game_MouseEnter += this.pictureBox1_MouseEnter;
            panel.Game_MouseLeave += this.pictureBox1_MouseLeave;
            this.tbl.Controls.Add(panel);
        }

        protected void AddGames(List<Game> games)
        {
            this.tbl.Visible = false;
            foreach (var game in games)
            {
                AddGame(game);
            }
            this.tbl.Visible = true;
        }

        private void tbSearchName_Enter(object sender, EventArgs e)
        {
            if (this.tbSearchName.Text == "Search for games...")
            {
                //tbSearchName.Text = "";
                tbSearchName.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }

        private void tbSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchName.Text))
            {
                tbSearchName.ForeColor = Color.FromArgb(150, 150, 150);
                //tbSearchName.Text = "Search for games...";
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    if (pictureBox.BackgroundImage == null) return;

                    pictureBox.Image = global::LmaoGame.Properties.Resources._1;
                    System.Threading.Thread.Sleep(TIME_APPEAR);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._2;
                    System.Threading.Thread.Sleep(TIME_APPEAR);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._3;
                    System.Threading.Thread.Sleep(TIME_APPEAR);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._4;
                    System.Threading.Thread.Sleep(TIME_APPEAR);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._5;
                    pictureBox.Refresh();
                }
                catch (Exception)
                {
                    // Do nothing
                }

            })).Start();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    if (pictureBox.BackgroundImage == null) return;
                    pictureBox.Image = global::LmaoGame.Properties.Resources._4;
                    System.Threading.Thread.Sleep(TIME_FADE);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._3;
                    System.Threading.Thread.Sleep(TIME_FADE);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._2;
                    System.Threading.Thread.Sleep(TIME_FADE);
                    pictureBox.Refresh();
                    pictureBox.Image = global::LmaoGame.Properties.Resources._1;
                    System.Threading.Thread.Sleep(TIME_FADE);
                    pictureBox.Refresh();
                    pictureBox.Image = null;
                    pictureBox.Refresh();
                }
                catch (Exception)
                {
                    // Do nothing
                }

            })).Start();

        }

        private void BrowseGames_Load(object sender, EventArgs e)
        {
            DisplayGenre();
            Search(null, null);
        }

        public virtual void game_Click(object sender, EventArgs e) { }

        protected virtual void RequestChangeViewInvoke(object sender, RequestChangeView_EventArgs e)
        {
            this.RequestChangeView?.Invoke(this, e);
        }

        private void clbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbGenre.Items.Count < totalGenre) return;
            Search(null, null);
        }

        private void SetButtonState()
        {

            if (currentPage == totalPage)
            {
                this.btnNext.Enabled = false;
                this.toolTip.SetToolTip(this.btnNext, "Yes, you reached the end.");
            }

            if (currentPage == totalPage - 1)
            {
                this.btnNext.Enabled = true;
                this.toolTip.SetToolTip(this.btnNext, "");
            }

            if (currentPage == 2)
            {
                this.btnBack.Enabled = true;
                this.toolTip.SetToolTip(this.btnBack, "");
            }

            if (currentPage == 1)
            {
                this.btnBack.Enabled = false;
                this.toolTip.SetToolTip(this.btnBack, "Yes, you reached the first page.");
            }
        }

        private void SortCheck(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, label.Font.Bold ? FontStyle.Regular : FontStyle.Bold);
            sortName.Enabled = lbSortName.Font.Bold;
            sortPrice.Enabled = lbSortPrice.Font.Bold;
            sortReleaseDate.Enabled = lbSortReleaseDate.Font.Bold;
            sortReview.Enabled = lbSortReview.Font.Bold;
            Search(null, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++CurrentPage;
            Search(null, null);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = (sender as Button).Text == "↓" ? "↑" : "↓";
            CurrentPage = 1;
            Search(null, null);
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            CurrentPage = 1;
            Search(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            --CurrentPage;
            Search(null, null);
        }
    }
}

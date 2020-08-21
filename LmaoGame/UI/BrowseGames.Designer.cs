namespace LmaoGame.UI
{
    partial class BrowseGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.tbSearchName = new DarkUI.Controls.DarkTextBox();
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new DarkUI.Controls.DarkButton();
            this.btnPageIndex = new DarkUI.Controls.DarkButton();
            this.btnNext = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.lbTotalPageIdx = new DarkUI.Controls.DarkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.genreTableAdapter = new LmaoGame.EpicGameLancherDataSetTableAdapters.GenreTableAdapter();
            this.epicGameLancherDataSet = new LmaoGame.EpicGameLancherDataSet();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.lbSortName = new DarkUI.Controls.DarkLabel();
            this.sortName = new DarkUI.Controls.DarkButton();
            this.sortPrice = new DarkUI.Controls.DarkButton();
            this.lbSortPrice = new DarkUI.Controls.DarkLabel();
            this.sortReleaseDate = new DarkUI.Controls.DarkButton();
            this.lbSortReleaseDate = new DarkUI.Controls.DarkLabel();
            this.sortReview = new DarkUI.Controls.DarkButton();
            this.lbSortReview = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epicGameLancherDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clbGenre
            // 
            this.clbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.clbGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbGenre.CheckOnClick = true;
            this.clbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGenre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.clbGenre.Items.AddRange(new object[] {
            "Lmao",
            "Hit",
            "Your Ass"});
            this.clbGenre.Location = new System.Drawing.Point(890, 266);
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(202, 442);
            this.clbGenre.TabIndex = 0;
            this.clbGenre.TabStop = false;
            this.clbGenre.SelectedIndexChanged += new System.EventHandler(this.clbGenre_SelectedIndexChanged);
            // 
            // tbSearchName
            // 
            this.tbSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tbSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tbSearchName.Location = new System.Drawing.Point(890, 167);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(202, 26);
            this.tbSearchName.TabIndex = 1;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            this.tbSearchName.Enter += new System.EventHandler(this.tbSearchName_Enter);
            this.tbSearchName.Leave += new System.EventHandler(this.tbSearchName_Leave);
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 4;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl.Location = new System.Drawing.Point(12, 22);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 3;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl.Size = new System.Drawing.Size(861, 695);
            this.tbl.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(939, 95);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(5);
            this.btnBack.Size = new System.Drawing.Size(25, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPageIndex
            // 
            this.btnPageIndex.Location = new System.Drawing.Point(979, 95);
            this.btnPageIndex.Name = "btnPageIndex";
            this.btnPageIndex.Padding = new System.Windows.Forms.Padding(5);
            this.btnPageIndex.Size = new System.Drawing.Size(25, 23);
            this.btnPageIndex.TabIndex = 4;
            this.btnPageIndex.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1020, 95);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(5);
            this.btnNext.Size = new System.Drawing.Size(25, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.toolTip.SetToolTip(this.btnNext, "aaaaaaaaaaa");
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(954, 134);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(72, 13);
            this.darkLabel1.TabIndex = 6;
            this.darkLabel1.Text = "Total page(s):";
            // 
            // lbTotalPageIdx
            // 
            this.lbTotalPageIdx.AutoSize = true;
            this.lbTotalPageIdx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbTotalPageIdx.Location = new System.Drawing.Point(1027, 134);
            this.lbTotalPageIdx.Name = "lbTotalPageIdx";
            this.lbTotalPageIdx.Size = new System.Drawing.Size(13, 13);
            this.lbTotalPageIdx.TabIndex = 7;
            this.lbTotalPageIdx.Text = "1";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Bruh";
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // epicGameLancherDataSet
            // 
            this.epicGameLancherDataSet.DataSetName = "EpicGameLancherDataSet";
            this.epicGameLancherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(887, 206);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(0, 16);
            this.darkLabel2.TabIndex = 8;
            // 
            // lbSortName
            // 
            this.lbSortName.AutoSize = true;
            this.lbSortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbSortName.Location = new System.Drawing.Point(916, 208);
            this.lbSortName.Name = "lbSortName";
            this.lbSortName.Size = new System.Drawing.Size(35, 13);
            this.lbSortName.TabIndex = 9;
            this.lbSortName.Text = "Name";
            this.lbSortName.Click += new System.EventHandler(this.SortCheck);
            // 
            // sortName
            // 
            this.sortName.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.sortName.Enabled = false;
            this.sortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortName.Location = new System.Drawing.Point(893, 203);
            this.sortName.Name = "sortName";
            this.sortName.Padding = new System.Windows.Forms.Padding(5);
            this.sortName.Size = new System.Drawing.Size(20, 23);
            this.sortName.TabIndex = 10;
            this.sortName.Text = "↓";
            this.sortName.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // sortPrice
            // 
            this.sortPrice.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.sortPrice.Enabled = false;
            this.sortPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPrice.Location = new System.Drawing.Point(1021, 203);
            this.sortPrice.Name = "sortPrice";
            this.sortPrice.Padding = new System.Windows.Forms.Padding(5);
            this.sortPrice.Size = new System.Drawing.Size(20, 23);
            this.sortPrice.TabIndex = 12;
            this.sortPrice.Text = "↓";
            this.sortPrice.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbSortPrice
            // 
            this.lbSortPrice.AutoSize = true;
            this.lbSortPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbSortPrice.Location = new System.Drawing.Point(1044, 208);
            this.lbSortPrice.Name = "lbSortPrice";
            this.lbSortPrice.Size = new System.Drawing.Size(31, 13);
            this.lbSortPrice.TabIndex = 11;
            this.lbSortPrice.Text = "Price";
            this.lbSortPrice.Click += new System.EventHandler(this.SortCheck);
            // 
            // sortReleaseDate
            // 
            this.sortReleaseDate.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.sortReleaseDate.Enabled = false;
            this.sortReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortReleaseDate.Location = new System.Drawing.Point(893, 233);
            this.sortReleaseDate.Name = "sortReleaseDate";
            this.sortReleaseDate.Padding = new System.Windows.Forms.Padding(5);
            this.sortReleaseDate.Size = new System.Drawing.Size(20, 23);
            this.sortReleaseDate.TabIndex = 14;
            this.sortReleaseDate.Text = "↓";
            this.sortReleaseDate.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbSortReleaseDate
            // 
            this.lbSortReleaseDate.AutoSize = true;
            this.lbSortReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbSortReleaseDate.Location = new System.Drawing.Point(916, 238);
            this.lbSortReleaseDate.Name = "lbSortReleaseDate";
            this.lbSortReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lbSortReleaseDate.TabIndex = 13;
            this.lbSortReleaseDate.Text = "Release Date";
            this.lbSortReleaseDate.Click += new System.EventHandler(this.SortCheck);
            // 
            // sortReview
            // 
            this.sortReview.ButtonStyle = DarkUI.Controls.DarkButtonStyle.Flat;
            this.sortReview.Enabled = false;
            this.sortReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortReview.Location = new System.Drawing.Point(1021, 233);
            this.sortReview.Name = "sortReview";
            this.sortReview.Padding = new System.Windows.Forms.Padding(5);
            this.sortReview.Size = new System.Drawing.Size(20, 23);
            this.sortReview.TabIndex = 16;
            this.sortReview.Text = "↓";
            this.sortReview.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbSortReview
            // 
            this.lbSortReview.AutoSize = true;
            this.lbSortReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbSortReview.Location = new System.Drawing.Point(1044, 238);
            this.lbSortReview.Name = "lbSortReview";
            this.lbSortReview.Size = new System.Drawing.Size(43, 13);
            this.lbSortReview.TabIndex = 15;
            this.lbSortReview.Text = "Review";
            this.lbSortReview.Click += new System.EventHandler(this.SortCheck);
            // 
            // BrowseGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1104, 761);
            this.Controls.Add(this.sortReview);
            this.Controls.Add(this.lbSortReview);
            this.Controls.Add(this.sortReleaseDate);
            this.Controls.Add(this.lbSortReleaseDate);
            this.Controls.Add(this.sortPrice);
            this.Controls.Add(this.lbSortPrice);
            this.Controls.Add(this.sortName);
            this.Controls.Add(this.lbSortName);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.lbTotalPageIdx);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPageIndex);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.clbGenre);
            this.Name = "BrowseGames";
            this.Text = "BrowseGames";
            this.Load += new System.EventHandler(this.BrowseGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epicGameLancherDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbGenre;
        private DarkUI.Controls.DarkTextBox tbSearchName;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private DarkUI.Controls.DarkButton btnBack;
        private DarkUI.Controls.DarkButton btnPageIndex;
        private DarkUI.Controls.DarkButton btnNext;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel lbTotalPageIdx;
        private System.Windows.Forms.ToolTip toolTip;
        private LmaoGame.EpicGameLancherDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private EpicGameLancherDataSet epicGameLancherDataSet;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel lbSortName;
        private DarkUI.Controls.DarkButton sortName;
        private DarkUI.Controls.DarkButton sortPrice;
        private DarkUI.Controls.DarkLabel lbSortPrice;
        private DarkUI.Controls.DarkButton sortReleaseDate;
        private DarkUI.Controls.DarkLabel lbSortReleaseDate;
        private DarkUI.Controls.DarkButton sortReview;
        private DarkUI.Controls.DarkLabel lbSortReview;
    }
}
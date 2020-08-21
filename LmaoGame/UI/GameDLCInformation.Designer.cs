using System.Windows.Forms;

namespace LmaoGame.UI
{
    partial class GameDLCInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.btnDetail = new DarkUI.Controls.DarkButton();
            this.btnBuyDLC = new DarkUI.Controls.DarkButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dlc_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dlc_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // darkLabel1
            // 
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(0, 0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(100, 23);
            this.darkLabel1.TabIndex = 29;
            // 
            // darkLabel7
            // 
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(0, 0);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(100, 23);
            this.darkLabel7.TabIndex = 23;
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(874, 366);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new System.Windows.Forms.Padding(5);
            this.btnDetail.Size = new System.Drawing.Size(114, 33);
            this.btnDetail.TabIndex = 19;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnBuyDLC
            // 
            this.btnBuyDLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyDLC.Location = new System.Drawing.Point(638, 366);
            this.btnBuyDLC.Name = "btnBuyDLC";
            this.btnBuyDLC.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuyDLC.Size = new System.Drawing.Size(216, 33);
            this.btnBuyDLC.TabIndex = 21;
            this.btnBuyDLC.Text = "Buy DLCs";
            this.btnBuyDLC.Click += new System.EventHandler(this.btnBuyDLC_Click);
            // 
            // dlc_dataGridView
            // 
            dlc_dataGridView.AllowUserToAddRows = false;
            dlc_dataGridView.AllowUserToDeleteRows = false;
            dlc_dataGridView.AllowUserToResizeColumns = false;
            dlc_dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dlc_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dlc_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dlc_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dlc_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dlc_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dlc_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dlc,
            this.Detail,
            this.releaseDate,
            this.Sales,
            this.Price,
            this.Owned});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dlc_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dlc_dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            dlc_dataGridView.Location = new System.Drawing.Point(91, 468);
            dlc_dataGridView.Name = "dlc_dataGridView";
            dlc_dataGridView.ReadOnly = true;
            dlc_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dlc_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dlc_dataGridView.RowHeadersVisible = false;
            dlc_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dlc_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            dlc_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dlc_dataGridView.Size = new System.Drawing.Size(911, 197);
            dlc_dataGridView.TabIndex = 20;
            dlc_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DLC_dataGridView_CellClick);
            dlc_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlc_dataGridView_CellContentClick);
            dlc_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlc_dataGridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 5;
            this.id.DataPropertyName = "id";
            // 
            // dlc
            // 
            this.dlc.DataPropertyName = "name";
            this.dlc.HeaderText = "DLC";
            this.dlc.Name = "dlc";
            this.dlc.ReadOnly = true;
            this.dlc.Width = 200;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.Detail.DataPropertyName = "detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // releaseDate
            // 
            this.releaseDate.DataPropertyName = "releaseDate";
            this.releaseDate.HeaderText = "ReleaseDate";
            this.releaseDate.MinimumWidth = 40;
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.ReadOnly = true;
            this.releaseDate.Width = 95;
            this.releaseDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            // 
            // Sales
            // 
            this.Sales.DataPropertyName = "sales";
            this.Sales.HeaderText = "Sales";
            this.Sales.Name = "Sales";
            this.Sales.ReadOnly = true;
            this.Sales.Width = 45;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price2";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 40;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
            // 
            // Owned
            // 
            this.Owned.DataPropertyName = "IsOwned";
            this.Owned.HeaderText = "Owned";
            this.Owned.Name = "Owned";
            this.Owned.ReadOnly = true;
            this.Owned.Width = 50;
            // 
            // GameDLCInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 719);
            this.Controls.Add(this.btnBuyDLC);
            this.Controls.Add(dlc_dataGridView);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.darkLabel7);
            this.Controls.Add(this.darkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameDLCInformation";
            this.Load += new System.EventHandler(this.GameDLCInformation_Load);
            this.Controls.SetChildIndex(this.darkLabel1, 0);
            this.Controls.SetChildIndex(this.darkLabel7, 0);
            this.Controls.SetChildIndex(this.btnDetail, 0);
            this.Controls.SetChildIndex(dlc_dataGridView, 0);
            this.Controls.SetChildIndex(this.btnBuyDLC, 0);
            ((System.ComponentModel.ISupportInitialize)(dlc_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.Windows.Forms.DataGridView dlc_dataGridView;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkButton btnDetail;
        private DarkUI.Controls.DarkButton btnBuyDLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owned;
    }
}
namespace LmaoGame.UI
{
    partial class GameInfomation
    {/// <summary>
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
            this.lbGameName = new DarkUI.Controls.DarkLabel();
            this.lbStar1 = new DarkUI.Controls.DarkLabel();
            this.lbStar2 = new DarkUI.Controls.DarkLabel();
            this.lbStar4 = new DarkUI.Controls.DarkLabel();
            this.lbStar3 = new DarkUI.Controls.DarkLabel();
            this.lbStar5 = new DarkUI.Controls.DarkLabel();
            this.gameAction_btn = new DarkUI.Controls.DarkButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Verdana", 24F);
            this.lbGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbGameName.Location = new System.Drawing.Point(84, 314);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(412, 38);
            this.lbGameName.TabIndex = 1;
            this.lbGameName.Text = "Assassin\'s Creed Vahalla";
            // 
            // lbStar1
            // 
            this.lbStar1.AutoSize = true;
            this.lbStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStar1.Location = new System.Drawing.Point(556, 317);
            this.lbStar1.Name = "lbStar1";
            this.lbStar1.Size = new System.Drawing.Size(32, 31);
            this.lbStar1.TabIndex = 2;
            this.lbStar1.Text = "✭";
            this.lbStar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeReview);
            // 
            // lbStar2
            // 
            this.lbStar2.AutoSize = true;
            this.lbStar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStar2.Location = new System.Drawing.Point(588, 317);
            this.lbStar2.Name = "lbStar2";
            this.lbStar2.Size = new System.Drawing.Size(32, 31);
            this.lbStar2.TabIndex = 3;
            this.lbStar2.Text = "✭";
            this.lbStar2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeReview);
            // 
            // lbStar4
            // 
            this.lbStar4.AutoSize = true;
            this.lbStar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar4.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStar4.Location = new System.Drawing.Point(652, 317);
            this.lbStar4.Name = "lbStar4";
            this.lbStar4.Size = new System.Drawing.Size(32, 31);
            this.lbStar4.TabIndex = 5;
            this.lbStar4.Text = "✭";
            this.lbStar4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeReview);
            // 
            // lbStar3
            // 
            this.lbStar3.AutoSize = true;
            this.lbStar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStar3.Location = new System.Drawing.Point(620, 317);
            this.lbStar3.Name = "lbStar3";
            this.lbStar3.Size = new System.Drawing.Size(32, 31);
            this.lbStar3.TabIndex = 4;
            this.lbStar3.Text = "✭";
            this.lbStar3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeReview);
            // 
            // lbStar5
            // 
            this.lbStar5.AutoSize = true;
            this.lbStar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar5.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStar5.Location = new System.Drawing.Point(684, 317);
            this.lbStar5.Name = "lbStar5";
            this.lbStar5.Size = new System.Drawing.Size(32, 31);
            this.lbStar5.TabIndex = 6;
            this.lbStar5.Text = "✭";
            this.lbStar5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeReview);
            // 
            // gameAction_btn
            // 
            this.gameAction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameAction_btn.Location = new System.Drawing.Point(91, 366);
            this.gameAction_btn.Name = "gameAction_btn";
            this.gameAction_btn.Padding = new System.Windows.Forms.Padding(5);
            this.gameAction_btn.Size = new System.Drawing.Size(114, 33);
            this.gameAction_btn.TabIndex = 9;
            this.gameAction_btn.Text = "Buy now";
            this.gameAction_btn.Click += new System.EventHandler(this.GameAction_btn_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::LmaoGame.Properties.Resources.bigImageExample;
            this.pbImage.Image = global::LmaoGame.Properties.Resources.bigImageExample;
            this.pbImage.Location = new System.Drawing.Point(84, 36);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(918, 254);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // GameInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 719);
            this.Controls.Add(this.gameAction_btn);
            this.Controls.Add(this.lbStar5);
            this.Controls.Add(this.lbStar4);
            this.Controls.Add(this.lbStar3);
            this.Controls.Add(this.lbStar2);
            this.Controls.Add(this.lbStar1);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.pbImage);
            this.Name = "GameInfomation";
            this.Text = "GameInformation";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel lbGameName;
        private DarkUI.Controls.DarkLabel lbStar1;
        private DarkUI.Controls.DarkLabel lbStar2;
        private DarkUI.Controls.DarkLabel lbStar4;
        private DarkUI.Controls.DarkLabel lbStar3;
        private DarkUI.Controls.DarkLabel lbStar5;
        private DarkUI.Controls.DarkButton gameAction_btn;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
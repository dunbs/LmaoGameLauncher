using LmaoGame.Properties;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI.Model
{
    class GameComponent : Panel
    {
        public event EventHandler Game_Click;
        public event EventHandler Game_MouseEnter;
        public event EventHandler Game_MouseLeave;


        public GameComponent(Game game)
        {
            PictureBox pictureBox = new PictureBox();
            Label name = new Label();
            Label price = new Label();
            // 
            // panel
            // 
            this.Controls.Add(price);
            this.Controls.Add(name);
            this.Controls.Add(pictureBox);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(195, 211);
            this.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = game.Image == null ? Resources.image_not_found : game.Image;
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.BackColor = Color.Red;
            pictureBox.Location = new System.Drawing.Point(19, 0);
            pictureBox.Name = "123";
            pictureBox.Size = new System.Drawing.Size(158, 184);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Click += GameClick_EventHandler;
            pictureBox.MouseEnter += GameMouseEnter_EventHandler;
            pictureBox.MouseLeave += GameMouseLeave_EventHandler;
            // 
            // name
            // 
            name.AutoEllipsis = true;
            name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name.ForeColor = System.Drawing.SystemColors.ControlLight;
            name.Location = new System.Drawing.Point(0, 187);
            name.Name = "123";
            name.Size = new System.Drawing.Size(195, 24);
            name.TabIndex = 0;
            name.Text = game.Name;
            name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            name.Click += GameClick_EventHandler;
            // 
            // price
            // 
            price.BackColor = System.Drawing.Color.Green;
            price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            price.Location = new System.Drawing.Point(110, 139);
            price.Name = "darkLabel2";
            price.Size = new System.Drawing.Size(90, 36);
            price.TabIndex = 0;
            price.Text = game.Price > 0 ? game.Price.ToString("C") : "FREE";
            price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            price.Click += GameClick_EventHandler;

            if (game.IsOwned)
            {
                price.BackColor = System.Drawing.Color.BlueViolet;
                price.Text = "Owned";
            }


            Game = game;
        }

        public Game Game { get; }

        public void GameClick_EventHandler(object sender, EventArgs e)
        {
            Game_Click?.Invoke(this, e);
        }

        public void GameMouseEnter_EventHandler(object sender, EventArgs e)
        {
            Game_MouseEnter?.Invoke(sender, e);
        }

        public void GameMouseLeave_EventHandler(object sender, EventArgs e)
        {
            Game_MouseLeave?.Invoke(sender, e);
        }
    }
}

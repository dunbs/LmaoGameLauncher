using DarkUI.Forms;
using LmaoGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI
{
    public partial class WelcomeScreen : DarkForm
    {
        static readonly List<Image> images = new List<Image>()
        {
            Resources.Welcome,
            Resources.Welcome2,
            Resources.Welcome3
        };

        static readonly Random random = new Random();

        public WelcomeScreen()
        {
            InitializeComponent();
            this.pictureBox1.Image = images[random.Next(3)];
        }
    }
}

using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI.Dialog
{
    public partial class Input : DarkForm
    {
        private bool isConfirmed;

        public Input()
        {
            InitializeComponent();
            isConfirmed = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetInput()
        {
            Input input = new Input();
            input.ShowDialog();
            return input.isConfirmed ? input.tbPassword.Text : null;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            isConfirmed = true;
            this.Close();
        }
    }
}

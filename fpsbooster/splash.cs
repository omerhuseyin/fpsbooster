using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fpsbooster
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private int val;

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            val = splashProgressBar.Value / 10;
            splashProgressBar.Text = $"{val}";
            FormMainMenu main = new FormMainMenu();
            splashProgressBar.Value += 1;
            if (splashProgressBar.Value == 100)
            {
                splashTimer.Stop();
                this.Hide();
                main.Show();
            }
        }
    }
}
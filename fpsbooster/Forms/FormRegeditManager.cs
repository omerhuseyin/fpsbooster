using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace fpsbooster.Forms
{
    public partial class FormRegeditManager : Form
    {
        public FormRegeditManager()
        {
            InitializeComponent();
        }

        private int DelayReducation, dvrOne, dvrTwo, GameOptimization, CloseDefender, LowSystemFix, FullscreenFix, WindowsOptimization;

        private void btnDelayReducation_Click(object sender, EventArgs e)
        {
            DelayReducation = DelayReducation + 1;
            if (DelayReducation % 2 == 0)
            {
                Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile").SetValue("SystemResponsiveness", 16);

                btnDelayReducation.Text = "Closed";
                btnDelayReducation.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile").SetValue("SystemResponsiveness", 0);

                btnDelayReducation.Text = "Open";
                btnDelayReducation.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btndvr1off_Click(object sender, EventArgs e)
        {
            dvrOne = dvrOne + 1;
            if (dvrOne % 2 == 0)
            {
                btndvr1off.Text = "Closed";
                btndvr1off.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btndvr1off.Text = "Open";
                btndvr1off.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btndvr2off_Click(object sender, EventArgs e)
        {
            dvrTwo = dvrTwo + 1;
            if (dvrTwo % 2 == 0)
            {
                btndvr2off.Text = "Closed";
                btndvr2off.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btndvr2off.Text = "Open";
                btndvr2off.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnGameOptimization_Click(object sender, EventArgs e)
        {
            GameOptimization = GameOptimization + 1;
            if (GameOptimization % 2 == 0)
            {
                btnGameOptimization.Text = "Closed";
                btnGameOptimization.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btnGameOptimization.Text = "Open";
                btnGameOptimization.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnCloseDefender_Click(object sender, EventArgs e)
        {
            CloseDefender = CloseDefender + 1;
            if (CloseDefender % 2 == 0)
            {
                btnCloseDefender.Text = "Closed";
                btnCloseDefender.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btnCloseDefender.Text = "Open";
                btnCloseDefender.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnLowSystemFix_Click(object sender, EventArgs e)
        {
            LowSystemFix = LowSystemFix + 1;
            if (LowSystemFix % 2 == 0)
            {
                btnLowSystemFix.Text = "Closed";
                btnLowSystemFix.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btnLowSystemFix.Text = "Open";
                btnLowSystemFix.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnFullscreenFix_Click(object sender, EventArgs e)
        {
            FullscreenFix = FullscreenFix + 1;
            if (FullscreenFix % 2 == 0)
            {
                btnFullscreenFix.Text = "Closed";
                btnFullscreenFix.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btnFullscreenFix.Text = "Open";
                btnFullscreenFix.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnWindowsOptimization_Click(object sender, EventArgs e)
        {
            WindowsOptimization = WindowsOptimization + 1;
            if (WindowsOptimization % 2 == 0)
            {
                btnWindowsOptimization.Text = "Closed";
                btnWindowsOptimization.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                btnWindowsOptimization.Text = "Open";
                btnWindowsOptimization.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void FormRegeditManager_Load(object sender, EventArgs e)
        {
            Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile").SetValue("SystemResponsiveness", 16);

        }
    }
}
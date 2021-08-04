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
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                    RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", true);

            DelayReducation = DelayReducation + 1;
            if (DelayReducation % 2 == 0)
            {
                registryKey.SetValue("SystemResponsiveness", 16, RegistryValueKind.DWord);
                registryKey.Close();

                btnDelayReducation.Text = "Closed";
                btnDelayReducation.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("SystemResponsiveness", 0, RegistryValueKind.DWord);
                registryKey.Close();

                btnDelayReducation.Text = "Open";
                btnDelayReducation.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btndvr1off_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.CurrentUser, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "System\\GameConfigStore", true);

            dvrOne = dvrOne + 1;
            if (dvrOne % 2 == 0)
            {
                registryKey.SetValue("GameDVR_Enabled", 1, RegistryValueKind.DWord);
                registryKey.Close();

                btndvr1off.Text = "Closed";
                btndvr1off.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("GameDVR_Enabled", 0, RegistryValueKind.DWord);
                registryKey.Close();
                btndvr1off.Text = "Open";
                btndvr1off.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btndvr2off_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR", true);

            dvrTwo = dvrTwo + 1;
            if (dvrTwo % 2 == 0)
            {
                registryKey.SetValue("value", 1, RegistryValueKind.DWord);
                registryKey.Close();

                btndvr2off.Text = "Closed";
                btndvr2off.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("value", 0, RegistryValueKind.DWord);
                registryKey.Close();
                btndvr2off.Text = "Open";
                btndvr2off.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnGameOptimization_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true);

            GameOptimization = GameOptimization + 1;
            if (GameOptimization % 2 == 0)
            {
                registryKey.SetValue("GPU Priority", 8, RegistryValueKind.DWord);
                registryKey.SetValue("Priority", 2, RegistryValueKind.DWord);
                registryKey.SetValue("Scheduling Category", "Medium", RegistryValueKind.String);
                registryKey.SetValue("SFIO Priority", "Normal", RegistryValueKind.String);

                registryKey.Close();

                btnGameOptimization.Text = "Closed";
                btnGameOptimization.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("GPU Priority", 8, RegistryValueKind.DWord);
                registryKey.SetValue("Priority", 6, RegistryValueKind.DWord);
                registryKey.SetValue("Scheduling Category", "High", RegistryValueKind.String);
                registryKey.SetValue("SFIO Priority", "High", RegistryValueKind.String);
                registryKey.Close();

                btnGameOptimization.Text = "Open";
                btnGameOptimization.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnCloseDefender_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Policies\\Microsoft\\Windows Defender", true);

            CloseDefender = CloseDefender + 1;
            if (CloseDefender % 2 == 0)
            {
                registryKey.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
                //        registryKey.Close();

                btnCloseDefender.Text = "Closed";
                btnCloseDefender.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("DisableAntiSpyware", 0, RegistryValueKind.DWord);
                //      registryKey.Close();

                btnCloseDefender.Text = "Open";
                btnCloseDefender.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnLowSystemFix_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", true);

            LowSystemFix = LowSystemFix + 1;
            if (LowSystemFix % 2 == 0)
            {
                registryKey.SetValue("SystemResponsiveness", 16, RegistryValueKind.DWord);
                registryKey.Close();

                btnLowSystemFix.Text = "Closed";
                btnLowSystemFix.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("SystemResponsiveness", 16, RegistryValueKind.DWord);
                registryKey.Close();

                btnLowSystemFix.Text = "Open";
                btnLowSystemFix.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnFullscreenFix_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.CurrentUser, RegistryView.Registry64);

            RegistryKey registryKey = regKeySpecific.OpenSubKey(
                "System\\GameConfigStore", true);

            FullscreenFix = FullscreenFix + 1;
            if (FullscreenFix % 2 == 0)
            {
                registryKey.SetValue("GameDVR_FSEBehaviorMode", 2, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_HonorUserFSEBehaviorMod", 0, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_FSEBehavior", 0, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 0, RegistryValueKind.DWord);
                registryKey.Close();

                btnFullscreenFix.Text = "Closed";
                btnFullscreenFix.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKey.SetValue("GameDVR_FSEBehaviorMode", 2, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_HonorUserFSEBehaviorMod", 1, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_FSEBehavior", 2, RegistryValueKind.DWord);
                registryKey.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 1, RegistryValueKind.DWord);
                registryKey.Close();

                btnFullscreenFix.Text = "Open";
                btnFullscreenFix.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }

        private void btnWindowsOptimization_Click(object sender, EventArgs e)
        {
            RegistryKey regKeySpecific = RegistryKey.OpenBaseKey(
                                   RegistryHive.LocalMachine, RegistryView.Registry64);

            RegistryKey registryKeyMemory = regKeySpecific.OpenSubKey(
                "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
            RegistryKey registryKeyGraphics = regKeySpecific.OpenSubKey(
                "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", true);
            RegistryKey registryKeyKernel = regKeySpecific.OpenSubKey(
                "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", true);
            RegistryKey registryKeyDefender = regKeySpecific.OpenSubKey(
                "SOFTWARE\\Policies\\Microsoft\\Windows Defender", true);

            WindowsOptimization = WindowsOptimization + 1;
            if (WindowsOptimization % 2 == 0)
            {
                registryKeyMemory.SetValue("FeatureSettings", 1, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("FeatureSettingsOverride", 3, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("FeatureSettingsOverrideMask", 3, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("EnableCfg", 0, RegistryValueKind.DWord);
                registryKeyMemory.Close();

                registryKeyGraphics.SetValue("DpiMapIommuContiguous", 1, RegistryValueKind.DWord);
                registryKeyGraphics.Close();

                registryKeyKernel.SetValue("DisableExceptionChainValidation", 1, RegistryValueKind.DWord);
                registryKeyKernel.SetValue("KernelSEHOPEnabled", 0, RegistryValueKind.DWord);
                registryKeyKernel.Close();

                registryKeyDefender.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
                registryKeyDefender.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
                registryKeyDefender.SetValue("ServiceKeepAlive", 0, RegistryValueKind.DWord);
                registryKeyDefender.Close();

                btnWindowsOptimization.Text = "Closed";
                btnWindowsOptimization.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else
            {
                registryKeyMemory.SetValue("FeatureSettings", 1, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("FeatureSettingsOverride", 3, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("FeatureSettingsOverrideMask", 3, RegistryValueKind.DWord);
                registryKeyMemory.SetValue("EnableCfg", 0, RegistryValueKind.DWord);
                registryKeyMemory.Close();

                registryKeyGraphics.SetValue("DpiMapIommuContiguous", 1, RegistryValueKind.DWord);
                registryKeyGraphics.Close();

                registryKeyKernel.SetValue("DisableExceptionChainValidation", 1, RegistryValueKind.DWord);
                registryKeyKernel.SetValue("KernelSEHOPEnabled", 0, RegistryValueKind.DWord);
                registryKeyKernel.Close();

                registryKeyDefender.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
                registryKeyDefender.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
                registryKeyDefender.SetValue("ServiceKeepAlive", 0, RegistryValueKind.DWord);
                registryKeyDefender.Close();

                btnWindowsOptimization.Text = "Open";
                btnWindowsOptimization.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fpsbooster.Forms
{
    public partial class FormFileManager : Form
    {
        public FormFileManager()
        {
            InitializeComponent();
        }

        private void FormFileManager_Load(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void controller_Tick(object sender, EventArgs e)
        {
            foreach (DriveInfo disk in DriveInfo.GetDrives())
            {
                lblDisk.Text = disk.Name;
                if (disk.IsReady)
                {
                    lblTotalSpace.Text = (disk.TotalSize / (1024 * 1024)).ToString() + "GB";
                }
            }
        }
    }
}
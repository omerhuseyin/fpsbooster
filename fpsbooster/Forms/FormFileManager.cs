using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            float disk = perfHD.NextValue();
            progressHD.Value = (int)disk;
        }
    }
}
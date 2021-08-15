using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fpsbooster.Forms
{
    public partial class FormWindowsManager : Form
    {
        public FormWindowsManager()
        {
            InitializeComponent();
        }

        private void FormWindowsManager_Load(object sender, EventArgs e)
        {
            //192, 0, 192
            //MediumVioletRed
            //DodgerBlue
            //Purple

            lblMode.AutoSize = false;
            lblMode.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (bunifuHSlider1.Value < 50)
            {
                lblMode.Text = "Maksimum Kalite";
                lblModeDesc.Text = (@"Maksimum Görüntü Kalite Modu; Bilgisayarınız da
Görüntü Kaliteleştirme İşlemlerini Açarak,
Bilgisayarınıza Gözle Görülür Kalite Artışı
Sağlar. Ancak Performans Düşüşlerine Yol Açabilir.
");
                panel.GradientBottomLeft = Color.FromArgb(192, 0, 192);
                panel.GradientBottomRight = Color.MediumVioletRed;
                panel.GradientTopLeft = Color.DodgerBlue;
                panel.GradientTopRight = Color.Purple;
            }
            else if (bunifuHSlider1.Value > 50)
            {
                lblMode.Text = "Maksimum Performans";
                lblModeDesc.Text = (@"Maksimum Performans Modu; Bilgisayarınız da
Görüntü Kaliteleştirme İşlemlerini Kısıtlayarak,
Bilgisayarınıza Gözle Görülür Performans Artışı
Sağlar
");
                panel.GradientBottomLeft = Color.Red;
                panel.GradientBottomRight = Color.PaleVioletRed;
                panel.GradientTopLeft = Color.Violet;
                panel.GradientTopRight = Color.Indigo;
            }
        }
    }
}
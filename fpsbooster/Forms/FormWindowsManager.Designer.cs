
namespace fpsbooster.Forms
{
    partial class FormWindowsManager
    {
        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindowsManager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblModeDesc = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Performance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(495, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Windows Görüntü Servisi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fpsbooster.Properties.Resources.fpsbooster;
            this.pictureBox1.Location = new System.Drawing.Point(272, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderRadius = 50;
            this.panel.Controls.Add(this.bunifuSeparator1);
            this.panel.Controls.Add(this.lblModeDesc);
            this.panel.Controls.Add(this.lblMode);
            this.panel.GradientBottomLeft = System.Drawing.Color.Red;
            this.panel.GradientBottomRight = System.Drawing.Color.PaleVioletRed;
            this.panel.GradientTopLeft = System.Drawing.Color.Violet;
            this.panel.GradientTopRight = System.Drawing.Color.Indigo;
            this.panel.Location = new System.Drawing.Point(218, 256);
            this.panel.Name = "panel";
            this.panel.Quality = 10;
            this.panel.Size = new System.Drawing.Size(326, 152);
            this.panel.TabIndex = 3;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(90, 48);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(145, 10);
            this.bunifuSeparator1.TabIndex = 5;
            // 
            // lblModeDesc
            // 
            this.lblModeDesc.AutoSize = true;
            this.lblModeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModeDesc.Location = new System.Drawing.Point(30, 70);
            this.lblModeDesc.Name = "lblModeDesc";
            this.lblModeDesc.Size = new System.Drawing.Size(266, 60);
            this.lblModeDesc.TabIndex = 4;
            this.lblModeDesc.Text = "Maksimum Performans Modu; Bilgisayarınız da\r\nGörüntü Kaliteleştirme İşlemlerini K" +
    "ısıtlayarak,\r\nBilgisayarınıza Gözle Görülür Performans Artışı\r\nSağlar\r\n";
            this.lblModeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMode.Location = new System.Drawing.Point(96, 23);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(136, 15);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Maksimum Performans";
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(275, 164);
            this.bunifuHSlider1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 36);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(200, 36);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 6;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 19;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 0;
            this.bunifuHSlider1.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            // 
            // FormWindowsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.Controls.Add(this.bunifuHSlider1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWindowsManager";
            this.Text = "Windows Ayarları";
            this.Load += new System.EventHandler(this.FormWindowsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuGradientPanel panel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblModeDesc;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
    }
}
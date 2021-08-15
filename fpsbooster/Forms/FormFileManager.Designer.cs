
namespace fpsbooster.Forms
{
    partial class FormFileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileManager));
            this.perfHD = new System.Diagnostics.PerformanceCounter();
            this.progressHD = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.controller = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblDisk = new System.Windows.Forms.Label();
            this.lblTotalSpace = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfHD)).BeginInit();
            this.SuspendLayout();
            // 
            // perfHD
            // 
            this.perfHD.CategoryName = "LogicalDisk";
            this.perfHD.CounterName = "% Free Space";
            this.perfHD.InstanceName = "_Total";
            // 
            // progressHD
            // 
            this.progressHD.Animated = false;
            this.progressHD.AnimationInterval = 1;
            this.progressHD.AnimationSpeed = 1;
            this.progressHD.BackColor = System.Drawing.Color.Transparent;
            this.progressHD.CircleMargin = 10;
            this.progressHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.progressHD.ForeColor = System.Drawing.Color.White;
            this.progressHD.IsPercentage = false;
            this.progressHD.LineProgressThickness = 10;
            this.progressHD.LineThickness = 10;
            this.progressHD.Location = new System.Drawing.Point(288, 113);
            this.progressHD.Name = "progressHD";
            this.progressHD.ProgressAnimationSpeed = 200;
            this.progressHD.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressHD.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.progressHD.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progressHD.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressHD.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressHD.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressHD.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progressHD.Size = new System.Drawing.Size(147, 147);
            this.progressHD.SubScriptColor = System.Drawing.Color.White;
            this.progressHD.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progressHD.SubScriptText = "GB";
            this.progressHD.SuperScriptColor = System.Drawing.Color.White;
            this.progressHD.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progressHD.SuperScriptText = "%";
            this.progressHD.TabIndex = 16;
            this.progressHD.Text = "30";
            this.progressHD.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressHD.Value = 30;
            this.progressHD.ValueByTransition = 30;
            this.progressHD.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Disk Management";
            // 
            // controller
            // 
            this.controller.Interval = 10;
            this.controller.Tick += new System.EventHandler(this.controller_Tick);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(217, 104);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(300, 14);
            this.bunifuSeparator1.TabIndex = 18;
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisk.ForeColor = System.Drawing.Color.White;
            this.lblDisk.Location = new System.Drawing.Point(310, 275);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(100, 17);
            this.lblDisk.TabIndex = 19;
            this.lblDisk.Text = "Disk : undefined";
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.AutoSize = true;
            this.lblTotalSpace.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalSpace.ForeColor = System.Drawing.Color.White;
            this.lblTotalSpace.Location = new System.Drawing.Point(310, 301);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.Size = new System.Drawing.Size(115, 17);
            this.lblTotalSpace.TabIndex = 19;
            this.lblTotalSpace.Text = "Total Space : 0 GB";
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFreeSpace.ForeColor = System.Drawing.Color.White;
            this.lblFreeSpace.Location = new System.Drawing.Point(310, 328);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(112, 17);
            this.lblFreeSpace.TabIndex = 19;
            this.lblFreeSpace.Text = "Free Space : 0 GB";
            // 
            // FormFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.lblTotalSpace);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressHD);
            this.Name = "FormFileManager";
            this.Text = "Dosya Yönetimi";
            this.Load += new System.EventHandler(this.FormFileManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfHD;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer controller;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Label lblTotalSpace;
        private System.Windows.Forms.Label lblFreeSpace;
    }
}
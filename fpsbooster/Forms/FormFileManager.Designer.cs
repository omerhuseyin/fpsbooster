
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
            this.perfHD = new System.Diagnostics.PerformanceCounter();
            this.progressHD = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.controller = new System.Windows.Forms.Timer(this.components);
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
            this.progressHD.Location = new System.Drawing.Point(297, 139);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DISK C:\\";
            // 
            // controller
            // 
            this.controller.Interval = 10;
            this.controller.Tick += new System.EventHandler(this.controller_Tick);
            // 
            // FormFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(731, 443);
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
    }
}
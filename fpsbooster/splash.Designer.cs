
namespace fpsbooster
{
    partial class splash
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
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.splashProgressBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 50;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 25;
            this.elipseForm.TargetControl = this;
            // 
            // splashProgressBar
            // 
            this.splashProgressBar.Animated = false;
            this.splashProgressBar.AnimationInterval = 1;
            this.splashProgressBar.AnimationSpeed = 1;
            this.splashProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.splashProgressBar.CircleMargin = 10;
            this.splashProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.splashProgressBar.ForeColor = System.Drawing.Color.White;
            this.splashProgressBar.IsPercentage = false;
            this.splashProgressBar.LineProgressThickness = 10;
            this.splashProgressBar.LineThickness = 10;
            this.splashProgressBar.Location = new System.Drawing.Point(68, 88);
            this.splashProgressBar.Name = "splashProgressBar";
            this.splashProgressBar.ProgressAnimationSpeed = 200;
            this.splashProgressBar.ProgressBackColor = System.Drawing.Color.White;
            this.splashProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.splashProgressBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.splashProgressBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.splashProgressBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.splashProgressBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.splashProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.splashProgressBar.Size = new System.Drawing.Size(147, 147);
            this.splashProgressBar.Step = 1;
            this.splashProgressBar.SubScriptColor = System.Drawing.Color.White;
            this.splashProgressBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.splashProgressBar.SubScriptText = "";
            this.splashProgressBar.SuperScriptColor = System.Drawing.Color.White;
            this.splashProgressBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.splashProgressBar.SuperScriptText = "%";
            this.splashProgressBar.TabIndex = 16;
            this.splashProgressBar.Text = "0";
            this.splashProgressBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.splashProgressBar.ValueByTransition = 0;
            this.splashProgressBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fpsbooster.Properties.Resources.fpsbooster;
            this.pictureBox1.Location = new System.Drawing.Point(68, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "© fpsbooster 2021 | Her Hakkı Saklıdır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "coded by laweis | 2021 - v0.1 BETA";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(273, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splashProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer splashTimer;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.UI.WinForms.BunifuCircleProgress splashProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


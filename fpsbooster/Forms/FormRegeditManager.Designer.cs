
namespace fpsbooster.Forms
{
    partial class FormRegeditManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegeditManager));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnDelayReducation = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btndvr1off = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel3 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btndvr2off = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel4 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnGameOptimization = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 50;
            this.bunifuGradientPanel1.Controls.Add(this.btnDelayReducation);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(43, 57);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(143, 132);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnDelayReducation
            // 
            this.btnDelayReducation.FlatAppearance.BorderSize = 0;
            this.btnDelayReducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelayReducation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelayReducation.ForeColor = System.Drawing.Color.White;
            this.btnDelayReducation.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnDelayReducation.IconColor = System.Drawing.Color.White;
            this.btnDelayReducation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelayReducation.IconSize = 25;
            this.btnDelayReducation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelayReducation.Location = new System.Drawing.Point(27, 89);
            this.btnDelayReducation.Name = "btnDelayReducation";
            this.btnDelayReducation.Size = new System.Drawing.Size(89, 32);
            this.btnDelayReducation.TabIndex = 2;
            this.btnDelayReducation.Text = "Closed";
            this.btnDelayReducation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelayReducation.UseVisualStyleBackColor = true;
            this.btnDelayReducation.Click += new System.EventHandler(this.btnDelayReducation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay Reduction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fpsbooster.Properties.Resources.regedit;
            this.pictureBox1.Location = new System.Drawing.Point(51, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 50;
            this.bunifuGradientPanel2.Controls.Add(this.btndvr1off);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(213, 57);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(143, 132);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // btndvr1off
            // 
            this.btndvr1off.FlatAppearance.BorderSize = 0;
            this.btndvr1off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndvr1off.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndvr1off.ForeColor = System.Drawing.Color.White;
            this.btndvr1off.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btndvr1off.IconColor = System.Drawing.Color.White;
            this.btndvr1off.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndvr1off.IconSize = 25;
            this.btndvr1off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndvr1off.Location = new System.Drawing.Point(27, 89);
            this.btndvr1off.Name = "btndvr1off";
            this.btndvr1off.Size = new System.Drawing.Size(89, 32);
            this.btndvr1off.TabIndex = 2;
            this.btndvr1off.Text = "Closed";
            this.btndvr1off.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndvr1off.UseVisualStyleBackColor = true;
            this.btndvr1off.Click += new System.EventHandler(this.btndvr1off_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DVR 1 OFF";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::fpsbooster.Properties.Resources.regedit;
            this.pictureBox2.Location = new System.Drawing.Point(51, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderRadius = 50;
            this.bunifuGradientPanel3.Controls.Add(this.btndvr2off);
            this.bunifuGradientPanel3.Controls.Add(this.label3);
            this.bunifuGradientPanel3.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(381, 57);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(143, 132);
            this.bunifuGradientPanel3.TabIndex = 0;
            // 
            // btndvr2off
            // 
            this.btndvr2off.FlatAppearance.BorderSize = 0;
            this.btndvr2off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndvr2off.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndvr2off.ForeColor = System.Drawing.Color.White;
            this.btndvr2off.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btndvr2off.IconColor = System.Drawing.Color.White;
            this.btndvr2off.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndvr2off.IconSize = 25;
            this.btndvr2off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndvr2off.Location = new System.Drawing.Point(28, 89);
            this.btndvr2off.Name = "btndvr2off";
            this.btndvr2off.Size = new System.Drawing.Size(89, 32);
            this.btndvr2off.TabIndex = 1;
            this.btndvr2off.Text = "Closed";
            this.btndvr2off.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndvr2off.UseVisualStyleBackColor = true;
            this.btndvr2off.Click += new System.EventHandler(this.btndvr2off_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DVR 2 OFF";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fpsbooster.Properties.Resources.regedit;
            this.pictureBox3.Location = new System.Drawing.Point(51, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderRadius = 50;
            this.bunifuGradientPanel4.Controls.Add(this.btnGameOptimization);
            this.bunifuGradientPanel4.Controls.Add(this.label4);
            this.bunifuGradientPanel4.Controls.Add(this.pictureBox4);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(550, 57);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(143, 132);
            this.bunifuGradientPanel4.TabIndex = 0;
            // 
            // btnGameOptimization
            // 
            this.btnGameOptimization.FlatAppearance.BorderSize = 0;
            this.btnGameOptimization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameOptimization.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGameOptimization.ForeColor = System.Drawing.Color.White;
            this.btnGameOptimization.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnGameOptimization.IconColor = System.Drawing.Color.White;
            this.btnGameOptimization.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGameOptimization.IconSize = 25;
            this.btnGameOptimization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameOptimization.Location = new System.Drawing.Point(28, 89);
            this.btnGameOptimization.Name = "btnGameOptimization";
            this.btnGameOptimization.Size = new System.Drawing.Size(89, 32);
            this.btnGameOptimization.TabIndex = 1;
            this.btnGameOptimization.Text = "Closed";
            this.btnGameOptimization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGameOptimization.UseVisualStyleBackColor = true;
            this.btnGameOptimization.Click += new System.EventHandler(this.btnGameOptimization_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Game Optimization";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::fpsbooster.Properties.Resources.regedit;
            this.pictureBox4.Location = new System.Drawing.Point(51, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // FormRegeditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "FormRegeditManager";
            this.Text = "Kayıt Defteri";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnDelayReducation;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private FontAwesome.Sharp.IconButton btndvr1off;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btndvr2off;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel4;
        private FontAwesome.Sharp.IconButton btnGameOptimization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
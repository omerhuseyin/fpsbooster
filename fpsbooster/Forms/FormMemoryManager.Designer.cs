
namespace fpsbooster.Forms
{
    partial class FormMemoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemoryManager));
            this.controller = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuStatusBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.PCPU = new System.Diagnostics.PerformanceCounter();
            this.PRAM = new System.Diagnostics.PerformanceCounter();
            this.ramStatusBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label4 = new System.Windows.Forms.Label();
            this.availableMemory = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.cputemp = new System.Windows.Forms.Label();
            this.upTime = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.cpuname = new System.Windows.Forms.Label();
            this.l2cachesize = new System.Windows.Forms.Label();
            this.maxclock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // controller
            // 
            this.controller.Interval = 1000;
            this.controller.Tick += new System.EventHandler(this.controller_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU (Central Processing Unit)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "% Processor Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "RAM (Random Access Memory)";
            // 
            // cpuStatusBar
            // 
            this.cpuStatusBar.Animated = false;
            this.cpuStatusBar.AnimationInterval = 1;
            this.cpuStatusBar.AnimationSpeed = 1;
            this.cpuStatusBar.BackColor = System.Drawing.Color.Transparent;
            this.cpuStatusBar.CircleMargin = 10;
            this.cpuStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cpuStatusBar.ForeColor = System.Drawing.Color.White;
            this.cpuStatusBar.IsPercentage = false;
            this.cpuStatusBar.LineProgressThickness = 10;
            this.cpuStatusBar.LineThickness = 10;
            this.cpuStatusBar.Location = new System.Drawing.Point(102, 121);
            this.cpuStatusBar.Name = "cpuStatusBar";
            this.cpuStatusBar.ProgressAnimationSpeed = 200;
            this.cpuStatusBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpuStatusBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.cpuStatusBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.cpuStatusBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpuStatusBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.cpuStatusBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpuStatusBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cpuStatusBar.Size = new System.Drawing.Size(125, 125);
            this.cpuStatusBar.SubScriptColor = System.Drawing.Color.White;
            this.cpuStatusBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.cpuStatusBar.SubScriptText = "";
            this.cpuStatusBar.SuperScriptColor = System.Drawing.Color.White;
            this.cpuStatusBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.cpuStatusBar.SuperScriptText = "%";
            this.cpuStatusBar.TabIndex = 16;
            this.cpuStatusBar.Text = "30";
            this.cpuStatusBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpuStatusBar.Value = 30;
            this.cpuStatusBar.ValueByTransition = 30;
            this.cpuStatusBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // PCPU
            // 
            this.PCPU.CategoryName = "Processor";
            this.PCPU.CounterName = "% Processor Time";
            this.PCPU.InstanceName = "_Total";
            // 
            // PRAM
            // 
            this.PRAM.CategoryName = "Memory";
            this.PRAM.CounterName = "% Committed Bytes in Use";
            // 
            // ramStatusBar
            // 
            this.ramStatusBar.Animated = false;
            this.ramStatusBar.AnimationInterval = 1;
            this.ramStatusBar.AnimationSpeed = 1;
            this.ramStatusBar.BackColor = System.Drawing.Color.Transparent;
            this.ramStatusBar.CircleMargin = 10;
            this.ramStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ramStatusBar.ForeColor = System.Drawing.Color.White;
            this.ramStatusBar.IsPercentage = false;
            this.ramStatusBar.LineProgressThickness = 10;
            this.ramStatusBar.LineThickness = 10;
            this.ramStatusBar.Location = new System.Drawing.Point(505, 121);
            this.ramStatusBar.Name = "ramStatusBar";
            this.ramStatusBar.ProgressAnimationSpeed = 200;
            this.ramStatusBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ramStatusBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.ramStatusBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.ramStatusBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ramStatusBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.ramStatusBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ramStatusBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ramStatusBar.Size = new System.Drawing.Size(125, 125);
            this.ramStatusBar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramStatusBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.ramStatusBar.SubScriptText = "";
            this.ramStatusBar.SuperScriptColor = System.Drawing.Color.White;
            this.ramStatusBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.ramStatusBar.SuperScriptText = "%";
            this.ramStatusBar.TabIndex = 16;
            this.ramStatusBar.Text = "30";
            this.ramStatusBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ramStatusBar.Value = 30;
            this.ramStatusBar.ValueByTransition = 30;
            this.ramStatusBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "% Commited Bytes in Use";
            // 
            // availableMemory
            // 
            this.availableMemory.AutoSize = true;
            this.availableMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.availableMemory.ForeColor = System.Drawing.Color.White;
            this.availableMemory.Location = new System.Drawing.Point(472, 285);
            this.availableMemory.Name = "availableMemory";
            this.availableMemory.Size = new System.Drawing.Size(156, 16);
            this.availableMemory.TabIndex = 2;
            this.availableMemory.Text = "Available Memory : 0 MB";
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(73, 252);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(192, 33);
            this.bunifuSeparator1.TabIndex = 17;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(475, 254);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(192, 31);
            this.bunifuSeparator2.TabIndex = 18;
            // 
            // cputemp
            // 
            this.cputemp.AutoSize = true;
            this.cputemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cputemp.ForeColor = System.Drawing.Color.White;
            this.cputemp.Location = new System.Drawing.Point(70, 285);
            this.cputemp.Name = "cputemp";
            this.cputemp.Size = new System.Drawing.Size(148, 16);
            this.cputemp.TabIndex = 2;
            this.cputemp.Text = "CPU Temperature : 0 %";
            // 
            // upTime
            // 
            this.upTime.AutoSize = true;
            this.upTime.ForeColor = System.Drawing.Color.White;
            this.upTime.Location = new System.Drawing.Point(299, 425);
            this.upTime.Name = "upTime";
            this.upTime.Size = new System.Drawing.Size(130, 13);
            this.upTime.TabIndex = 19;
            this.upTime.Text = "System Up Time : 0 Hours";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.capacity.ForeColor = System.Drawing.Color.White;
            this.capacity.Location = new System.Drawing.Point(472, 312);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(147, 16);
            this.capacity.TabIndex = 2;
            this.capacity.Text = "RAM Capacity : 0 Bytes";
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manufacturer.ForeColor = System.Drawing.Color.White;
            this.manufacturer.Location = new System.Drawing.Point(472, 340);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(142, 16);
            this.manufacturer.TabIndex = 2;
            this.manufacturer.Text = "Manufacturer : Unknow";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speed.ForeColor = System.Drawing.Color.White;
            this.speed.Location = new System.Drawing.Point(472, 365);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(95, 16);
            this.speed.TabIndex = 2;
            this.speed.Text = "Speed : 0 MHz";
            // 
            // cpuname
            // 
            this.cpuname.AutoSize = true;
            this.cpuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cpuname.ForeColor = System.Drawing.Color.White;
            this.cpuname.Location = new System.Drawing.Point(70, 312);
            this.cpuname.Name = "cpuname";
            this.cpuname.Size = new System.Drawing.Size(133, 16);
            this.cpuname.TabIndex = 2;
            this.cpuname.Text = "CPU Name : Unknow";
            // 
            // l2cachesize
            // 
            this.l2cachesize.AutoSize = true;
            this.l2cachesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2cachesize.ForeColor = System.Drawing.Color.White;
            this.l2cachesize.Location = new System.Drawing.Point(70, 340);
            this.l2cachesize.Name = "l2cachesize";
            this.l2cachesize.Size = new System.Drawing.Size(146, 16);
            this.l2cachesize.TabIndex = 2;
            this.l2cachesize.Text = "L2 Cache Size : 0 Bytes";
            // 
            // maxclock
            // 
            this.maxclock.AutoSize = true;
            this.maxclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maxclock.ForeColor = System.Drawing.Color.White;
            this.maxclock.Location = new System.Drawing.Point(70, 365);
            this.maxclock.Name = "maxclock";
            this.maxclock.Size = new System.Drawing.Size(160, 16);
            this.maxclock.TabIndex = 2;
            this.maxclock.Text = "Max Clock Speed : 0 MHz";
            // 
            // FormMemoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.Controls.Add(this.upTime);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.ramStatusBar);
            this.Controls.Add(this.cpuStatusBar);
            this.Controls.Add(this.maxclock);
            this.Controls.Add(this.l2cachesize);
            this.Controls.Add(this.cpuname);
            this.Controls.Add(this.cputemp);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.availableMemory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormMemoryManager";
            this.Text = "Bellek Yönetimi";
            this.Load += new System.EventHandler(this.FormMemoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer controller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuCircleProgress cpuStatusBar;
        private System.Diagnostics.PerformanceCounter PCPU;
        private System.Diagnostics.PerformanceCounter PRAM;
        private Bunifu.UI.WinForms.BunifuCircleProgress ramStatusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label availableMemory;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label cputemp;
        private System.Windows.Forms.Label upTime;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label cpuname;
        private System.Windows.Forms.Label l2cachesize;
        private System.Windows.Forms.Label maxclock;
    }
}
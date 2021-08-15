
namespace fpsbooster
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSoftwareInformation = new FontAwesome.Sharp.IconButton();
            this.btnSystemInformation = new FontAwesome.Sharp.IconButton();
            this.btnWinManager = new FontAwesome.Sharp.IconButton();
            this.btnRegManager = new FontAwesome.Sharp.IconButton();
            this.btnFileManager = new FontAwesome.Sharp.IconButton();
            this.btnMemoryManager = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(195, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(747, 59);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 26;
            this.btnMinimize.Location = new System.Drawing.Point(671, 18);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 26);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 26;
            this.btnExit.Location = new System.Drawing.Point(705, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 19);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(69, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Ana Sayfa";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(147)))), ((int)(((byte)(43)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(195, 59);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(747, 5);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(195, 64);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(747, 482);
            this.panelDesktop.TabIndex = 3;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 15;
            this.elipseForm.TargetControl = this;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.panelMenu.BorderRadius = 0;
            this.panelMenu.BorderThickness = 0;
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnSoftwareInformation);
            this.panelMenu.Controls.Add(this.btnSystemInformation);
            this.panelMenu.Controls.Add(this.btnWinManager);
            this.panelMenu.Controls.Add(this.btnRegManager);
            this.panelMenu.Controls.Add(this.btnFileManager);
            this.panelMenu.Controls.Add(this.btnMemoryManager);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShowBorders = true;
            this.panelMenu.Size = new System.Drawing.Size(195, 546);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "coded by laweis | v0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fpsbooster.Properties.Resources.fpsbooster;
            this.pictureBox1.Location = new System.Drawing.Point(12, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSoftwareInformation
            // 
            this.btnSoftwareInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnSoftwareInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoftwareInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoftwareInformation.FlatAppearance.BorderSize = 0;
            this.btnSoftwareInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSoftwareInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSoftwareInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftwareInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoftwareInformation.ForeColor = System.Drawing.Color.White;
            this.btnSoftwareInformation.IconChar = FontAwesome.Sharp.IconChar.CodeBranch;
            this.btnSoftwareInformation.IconColor = System.Drawing.Color.White;
            this.btnSoftwareInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSoftwareInformation.IconSize = 25;
            this.btnSoftwareInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftwareInformation.Location = new System.Drawing.Point(0, 355);
            this.btnSoftwareInformation.Name = "btnSoftwareInformation";
            this.btnSoftwareInformation.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSoftwareInformation.Size = new System.Drawing.Size(195, 51);
            this.btnSoftwareInformation.TabIndex = 6;
            this.btnSoftwareInformation.Text = "Versiyon Bilgisi";
            this.btnSoftwareInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftwareInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoftwareInformation.UseVisualStyleBackColor = false;
            this.btnSoftwareInformation.Click += new System.EventHandler(this.btnSoftwareInformation_Click);
            // 
            // btnSystemInformation
            // 
            this.btnSystemInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemInformation.FlatAppearance.BorderSize = 0;
            this.btnSystemInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSystemInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnSystemInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSystemInformation.ForeColor = System.Drawing.Color.White;
            this.btnSystemInformation.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnSystemInformation.IconColor = System.Drawing.Color.White;
            this.btnSystemInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSystemInformation.IconSize = 25;
            this.btnSystemInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemInformation.Location = new System.Drawing.Point(0, 304);
            this.btnSystemInformation.Name = "btnSystemInformation";
            this.btnSystemInformation.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSystemInformation.Size = new System.Drawing.Size(195, 51);
            this.btnSystemInformation.TabIndex = 5;
            this.btnSystemInformation.Text = "Sistem Bilgisi";
            this.btnSystemInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemInformation.UseVisualStyleBackColor = false;
            this.btnSystemInformation.Click += new System.EventHandler(this.btnSystemInformation_Click);
            // 
            // btnWinManager
            // 
            this.btnWinManager.BackColor = System.Drawing.Color.Transparent;
            this.btnWinManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWinManager.FlatAppearance.BorderSize = 0;
            this.btnWinManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnWinManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnWinManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWinManager.ForeColor = System.Drawing.Color.White;
            this.btnWinManager.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.btnWinManager.IconColor = System.Drawing.Color.White;
            this.btnWinManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWinManager.IconSize = 25;
            this.btnWinManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWinManager.Location = new System.Drawing.Point(0, 253);
            this.btnWinManager.Name = "btnWinManager";
            this.btnWinManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWinManager.Size = new System.Drawing.Size(195, 51);
            this.btnWinManager.TabIndex = 4;
            this.btnWinManager.Text = "Windows Ayarları";
            this.btnWinManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWinManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWinManager.UseVisualStyleBackColor = false;
            this.btnWinManager.Click += new System.EventHandler(this.btnWinManager_Click);
            // 
            // btnRegManager
            // 
            this.btnRegManager.BackColor = System.Drawing.Color.Transparent;
            this.btnRegManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegManager.FlatAppearance.BorderSize = 0;
            this.btnRegManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnRegManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnRegManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegManager.ForeColor = System.Drawing.Color.White;
            this.btnRegManager.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnRegManager.IconColor = System.Drawing.Color.White;
            this.btnRegManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegManager.IconSize = 25;
            this.btnRegManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegManager.Location = new System.Drawing.Point(0, 202);
            this.btnRegManager.Name = "btnRegManager";
            this.btnRegManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegManager.Size = new System.Drawing.Size(195, 51);
            this.btnRegManager.TabIndex = 3;
            this.btnRegManager.Text = "Kayıt Defteri";
            this.btnRegManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegManager.UseVisualStyleBackColor = false;
            this.btnRegManager.Click += new System.EventHandler(this.btnRegManager_Click);
            // 
            // btnFileManager
            // 
            this.btnFileManager.BackColor = System.Drawing.Color.Transparent;
            this.btnFileManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManager.FlatAppearance.BorderSize = 0;
            this.btnFileManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnFileManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnFileManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileManager.ForeColor = System.Drawing.Color.Transparent;
            this.btnFileManager.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnFileManager.IconColor = System.Drawing.Color.White;
            this.btnFileManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFileManager.IconSize = 25;
            this.btnFileManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManager.Location = new System.Drawing.Point(0, 151);
            this.btnFileManager.Name = "btnFileManager";
            this.btnFileManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFileManager.Size = new System.Drawing.Size(195, 51);
            this.btnFileManager.TabIndex = 2;
            this.btnFileManager.Text = "Dosya Yönetimi";
            this.btnFileManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileManager.UseVisualStyleBackColor = false;
            this.btnFileManager.Click += new System.EventHandler(this.btnFileManager_Click);
            // 
            // btnMemoryManager
            // 
            this.btnMemoryManager.BackColor = System.Drawing.Color.Transparent;
            this.btnMemoryManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemoryManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoryManager.FlatAppearance.BorderSize = 0;
            this.btnMemoryManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMemoryManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMemoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemoryManager.ForeColor = System.Drawing.Color.White;
            this.btnMemoryManager.IconChar = FontAwesome.Sharp.IconChar.Memory;
            this.btnMemoryManager.IconColor = System.Drawing.Color.White;
            this.btnMemoryManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMemoryManager.IconSize = 25;
            this.btnMemoryManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoryManager.Location = new System.Drawing.Point(0, 100);
            this.btnMemoryManager.Name = "btnMemoryManager";
            this.btnMemoryManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMemoryManager.Size = new System.Drawing.Size(195, 51);
            this.btnMemoryManager.TabIndex = 1;
            this.btnMemoryManager.Text = "Bellek Yönetimi";
            this.btnMemoryManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoryManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemoryManager.UseVisualStyleBackColor = false;
            this.btnMemoryManager.Click += new System.EventHandler(this.btnMemoryManager_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Image = global::fpsbooster.Properties.Resources.icon;
            this.btnMainMenu.Location = new System.Drawing.Point(62, 19);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(56, 57);
            this.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 406);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(195, 51);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Windows Ayarları";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 546);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSystemInformation;
        private FontAwesome.Sharp.IconButton btnWinManager;
        private FontAwesome.Sharp.IconButton btnRegManager;
        private FontAwesome.Sharp.IconButton btnFileManager;
        private FontAwesome.Sharp.IconButton btnMemoryManager;
        private FontAwesome.Sharp.IconButton btnSoftwareInformation;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMainMenu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
namespace GistOne.Forms
{
    partial class Main
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
            this.Ts_Top = new System.Windows.Forms.ToolStrip();
            this.TsBtn_Home = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_MyGists = new System.Windows.Forms.ToolStripButton();
            this.TsBtn_Opened = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtn_Create = new System.Windows.Forms.ToolStripButton();
            this.TsBtn_Settings = new System.Windows.Forms.ToolStripButton();
            this.TsBtn_About = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ts_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ts_Top
            // 
            this.Ts_Top.AutoSize = false;
            this.Ts_Top.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Home,
            this.toolStripSeparator1,
            this.TsBtn_MyGists,
            this.TsBtn_Opened,
            this.TsBtn_Create,
            this.TsBtn_Settings,
            this.TsBtn_About});
            this.Ts_Top.Location = new System.Drawing.Point(0, 0);
            this.Ts_Top.Name = "Ts_Top";
            this.Ts_Top.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.Ts_Top.Size = new System.Drawing.Size(884, 55);
            this.Ts_Top.TabIndex = 0;
            this.Ts_Top.Text = "Main menu";
            // 
            // TsBtn_Home
            // 
            this.TsBtn_Home.Image = global::GistOne.Properties.Resources.house;
            this.TsBtn_Home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Home.Name = "TsBtn_Home";
            this.TsBtn_Home.Size = new System.Drawing.Size(44, 52);
            this.TsBtn_Home.Text = "&Home";
            this.TsBtn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_Home.Click += new System.EventHandler(this.TsBtn_Home_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // TsBtn_MyGists
            // 
            this.TsBtn_MyGists.Image = global::GistOne.Properties.Resources.magnifier;
            this.TsBtn_MyGists.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_MyGists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_MyGists.Name = "TsBtn_MyGists";
            this.TsBtn_MyGists.Size = new System.Drawing.Size(56, 52);
            this.TsBtn_MyGists.Text = "&My Gists";
            this.TsBtn_MyGists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_MyGists.Click += new System.EventHandler(this.TsBtn_Browse_Click);
            // 
            // TsBtn_Opened
            // 
            this.TsBtn_Opened.Image = global::GistOne.Properties.Resources.inbox_empty;
            this.TsBtn_Opened.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtn_Opened.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_Opened.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Opened.Name = "TsBtn_Opened";
            this.TsBtn_Opened.Size = new System.Drawing.Size(62, 52);
            this.TsBtn_Opened.Text = "&Opened";
            this.TsBtn_Opened.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_Opened.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsBtn_Opened_DropDownItemClicked);
            // 
            // TsBtn_Create
            // 
            this.TsBtn_Create.Image = global::GistOne.Properties.Resources.pencil;
            this.TsBtn_Create.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Create.Name = "TsBtn_Create";
            this.TsBtn_Create.Size = new System.Drawing.Size(70, 52);
            this.TsBtn_Create.Text = "&Create new";
            this.TsBtn_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_Create.Click += new System.EventHandler(this.TsBtn_Create_Click);
            // 
            // TsBtn_Settings
            // 
            this.TsBtn_Settings.Image = global::GistOne.Properties.Resources.setting_tools;
            this.TsBtn_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Settings.Name = "TsBtn_Settings";
            this.TsBtn_Settings.Size = new System.Drawing.Size(53, 52);
            this.TsBtn_Settings.Text = "&Settings";
            this.TsBtn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_Settings.Click += new System.EventHandler(this.TsBtn_Settings_Click);
            // 
            // TsBtn_About
            // 
            this.TsBtn_About.Image = global::GistOne.Properties.Resources.info_rhombus;
            this.TsBtn_About.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_About.Name = "TsBtn_About";
            this.TsBtn_About.Size = new System.Drawing.Size(44, 52);
            this.TsBtn_About.Text = "&About";
            this.TsBtn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtn_About.Click += new System.EventHandler(this.TsBtn_About_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 506);
            this.panel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ts_Top);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GistOne";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Ts_Top.ResumeLayout(false);
            this.Ts_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip Ts_Top;
        private ToolStripButton TsBtn_Home;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsBtn_MyGists;
        private ToolStripButton TsBtn_Settings;
        private ToolStripButton TsBtn_About;
        private ToolStripButton TsBtn_Create;
        internal ToolStripDropDownButton TsBtn_Opened;
        internal Panel panel1;
    }
}
namespace GistOne.Forms
{
    partial class OpenGist
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
            this.Lbl_GistID = new System.Windows.Forms.Label();
            this.Lsv_Files = new System.Windows.Forms.ListView();
            this.Col_Files_Name = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Size = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Lang = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Type = new System.Windows.Forms.ColumnHeader();
            this.label9 = new GistOne.ImageLabel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_LastEdit = new System.Windows.Forms.Label();
            this.label13 = new GistOne.ImageLabel();
            this.label12 = new GistOne.ImageLabel();
            this.Lbl_Visibility = new System.Windows.Forms.Label();
            this.Lbl_Created = new System.Windows.Forms.Label();
            this.label11 = new GistOne.ImageLabel();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Rtb_Gist = new System.Windows.Forms.RichTextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TabCont_Gist = new System.Windows.Forms.TabControl();
            this.Tab_Files = new System.Windows.Forms.TabPage();
            this.Toolbar_Files = new System.Windows.Forms.ToolStrip();
            this.TsBtn_Files_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_Files_Save = new System.Windows.Forms.ToolStripButton();
            this.TsBtn_Files_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tab_Versions = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tab_Forks = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Tab_Comments = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.imageLabel1 = new GistOne.ImageLabel();
            this.Lnk_Forked = new System.Windows.Forms.LinkLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TabCont_Gist.SuspendLayout();
            this.Tab_Files.SuspendLayout();
            this.Toolbar_Files.SuspendLayout();
            this.Tab_Versions.SuspendLayout();
            this.Tab_Forks.SuspendLayout();
            this.Tab_Comments.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_GistID
            // 
            this.Lbl_GistID.BackColor = System.Drawing.Color.Goldenrod;
            this.Lbl_GistID.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_GistID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GistID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_GistID.Location = new System.Drawing.Point(0, 0);
            this.Lbl_GistID.Name = "Lbl_GistID";
            this.Lbl_GistID.Size = new System.Drawing.Size(884, 30);
            this.Lbl_GistID.TabIndex = 2;
            this.Lbl_GistID.Text = "Gist ID";
            this.Lbl_GistID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lsv_Files
            // 
            this.Lsv_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Files_Name,
            this.Col_Files_Size,
            this.Col_Files_Lang,
            this.Col_Files_Type});
            this.Lsv_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lsv_Files.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lsv_Files.FullRowSelect = true;
            this.Lsv_Files.GridLines = true;
            this.Lsv_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lsv_Files.LabelEdit = true;
            this.Lsv_Files.Location = new System.Drawing.Point(3, 28);
            this.Lsv_Files.Name = "Lsv_Files";
            this.Lsv_Files.Size = new System.Drawing.Size(440, 184);
            this.Lsv_Files.TabIndex = 2;
            this.Lsv_Files.UseCompatibleStateImageBehavior = false;
            this.Lsv_Files.View = System.Windows.Forms.View.Details;
            this.Lsv_Files.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.Lsv_Files_AfterLabelEdit);
            this.Lsv_Files.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.Lsv_Files_BeforeLabelEdit);
            this.Lsv_Files.DoubleClick += new System.EventHandler(this.Lsv_Files_DoubleClick);
            // 
            // Col_Files_Name
            // 
            this.Col_Files_Name.Text = "Name";
            this.Col_Files_Name.Width = 180;
            // 
            // Col_Files_Size
            // 
            this.Col_Files_Size.Text = "Size";
            // 
            // Col_Files_Lang
            // 
            this.Col_Files_Lang.Text = "Language";
            this.Col_Files_Lang.Width = 80;
            // 
            // Col_Files_Type
            // 
            this.Col_Files_Type.Text = "Type";
            this.Col_Files_Type.Width = 95;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Image = global::GistOne.Properties.Resources.barcode_2d;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(110, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_ID.HideSelection = false;
            this.Txt_ID.Location = new System.Drawing.Point(132, 95);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(330, 18);
            this.Txt_ID.TabIndex = 0;
            this.Txt_ID.Text = "Loading...";
            // 
            // Lbl_LastEdit
            // 
            this.Lbl_LastEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LastEdit.Location = new System.Drawing.Point(128, 178);
            this.Lbl_LastEdit.Name = "Lbl_LastEdit";
            this.Lbl_LastEdit.Size = new System.Drawing.Size(338, 30);
            this.Lbl_LastEdit.TabIndex = 0;
            this.Lbl_LastEdit.Text = "Loading...";
            this.Lbl_LastEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Image = global::GistOne.Properties.Resources.date_edit;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(12, 178);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(110, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "Last edit:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::GistOne.Properties.Resources.date;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(12, 148);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(110, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "Created:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Visibility
            // 
            this.Lbl_Visibility.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Visibility.Location = new System.Drawing.Point(128, 208);
            this.Lbl_Visibility.Name = "Lbl_Visibility";
            this.Lbl_Visibility.Size = new System.Drawing.Size(338, 30);
            this.Lbl_Visibility.TabIndex = 0;
            this.Lbl_Visibility.Text = "Loading...";
            this.Lbl_Visibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Created
            // 
            this.Lbl_Created.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Created.Location = new System.Drawing.Point(128, 148);
            this.Lbl_Created.Name = "Lbl_Created";
            this.Lbl_Created.Size = new System.Drawing.Size(338, 30);
            this.Lbl_Created.TabIndex = 0;
            this.Lbl_Created.Text = "Loading...";
            this.Lbl_Created.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Image = global::GistOne.Properties.Resources.share;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(12, 208);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(110, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Visibility:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Description.Location = new System.Drawing.Point(12, 43);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.PlaceholderText = "Gist description...";
            this.Txt_Description.Size = new System.Drawing.Size(698, 29);
            this.Txt_Description.TabIndex = 5;
            this.Txt_Description.Leave += new System.EventHandler(this.Txt_Description_Leave);
            // 
            // Rtb_Gist
            // 
            this.Rtb_Gist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtb_Gist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rtb_Gist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rtb_Gist.Location = new System.Drawing.Point(472, 88);
            this.Rtb_Gist.Name = "Rtb_Gist";
            this.Rtb_Gist.Size = new System.Drawing.Size(400, 406);
            this.Rtb_Gist.TabIndex = 7;
            this.Rtb_Gist.Text = "";
            this.Rtb_Gist.WordWrap = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Save.Image = global::GistOne.Properties.Resources.diskette;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Save.Location = new System.Drawing.Point(716, 43);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 29);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Tag = "";
            this.Btn_Save.Text = "&Save";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Close.Image = global::GistOne.Properties.Resources.cancel;
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Close.Location = new System.Drawing.Point(797, 43);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 29);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.Tag = "";
            this.Btn_Close.Text = "&Close";
            this.Btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // TabCont_Gist
            // 
            this.TabCont_Gist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabCont_Gist.Controls.Add(this.Tab_Files);
            this.TabCont_Gist.Controls.Add(this.Tab_Versions);
            this.TabCont_Gist.Controls.Add(this.Tab_Forks);
            this.TabCont_Gist.Controls.Add(this.Tab_Comments);
            this.TabCont_Gist.Location = new System.Drawing.Point(12, 251);
            this.TabCont_Gist.Name = "TabCont_Gist";
            this.TabCont_Gist.SelectedIndex = 0;
            this.TabCont_Gist.Size = new System.Drawing.Size(454, 243);
            this.TabCont_Gist.TabIndex = 9;
            // 
            // Tab_Files
            // 
            this.Tab_Files.Controls.Add(this.Lsv_Files);
            this.Tab_Files.Controls.Add(this.Toolbar_Files);
            this.Tab_Files.Location = new System.Drawing.Point(4, 24);
            this.Tab_Files.Name = "Tab_Files";
            this.Tab_Files.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Files.Size = new System.Drawing.Size(446, 215);
            this.Tab_Files.TabIndex = 0;
            this.Tab_Files.Text = "Files";
            this.Tab_Files.ToolTipText = "Files of the Gist";
            this.Tab_Files.UseVisualStyleBackColor = true;
            // 
            // Toolbar_Files
            // 
            this.Toolbar_Files.AutoSize = false;
            this.Toolbar_Files.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar_Files.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Files_Add,
            this.toolStripSeparator1,
            this.TsBtn_Files_Delete,
            this.toolStripSeparator2,
            this.TsBtn_Files_Save});
            this.Toolbar_Files.Location = new System.Drawing.Point(3, 3);
            this.Toolbar_Files.Name = "Toolbar_Files";
            this.Toolbar_Files.Size = new System.Drawing.Size(440, 25);
            this.Toolbar_Files.TabIndex = 3;
            // 
            // TsBtn_Files_Add
            // 
            this.TsBtn_Files_Add.Image = global::GistOne.Properties.Resources.add;
            this.TsBtn_Files_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Files_Add.Name = "TsBtn_Files_Add";
            this.TsBtn_Files_Add.Size = new System.Drawing.Size(102, 22);
            this.TsBtn_Files_Add.Text = "&Add a new file";
            this.TsBtn_Files_Add.Click += new System.EventHandler(this.TsBtn_Files_Add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsBtn_Files_Save
            // 
            this.TsBtn_Files_Save.Image = global::GistOne.Properties.Resources.diskette;
            this.TsBtn_Files_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Files_Save.Name = "TsBtn_Files_Save";
            this.TsBtn_Files_Save.Size = new System.Drawing.Size(51, 22);
            this.TsBtn_Files_Save.Text = "&Save";
            this.TsBtn_Files_Save.Visible = false;
            this.TsBtn_Files_Save.Click += new System.EventHandler(this.TsBtn_Files_Save_Click);
            // 
            // TsBtn_Files_Delete
            // 
            this.TsBtn_Files_Delete.Image = global::GistOne.Properties.Resources.delete;
            this.TsBtn_Files_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Files_Delete.Name = "TsBtn_Files_Delete";
            this.TsBtn_Files_Delete.Size = new System.Drawing.Size(92, 22);
            this.TsBtn_Files_Delete.Text = "&Delete file(s)";
            this.TsBtn_Files_Delete.Click += new System.EventHandler(this.TsBtn_Files_Delete_Click);
            // 
            // Tab_Versions
            // 
            this.Tab_Versions.Controls.Add(this.listView1);
            this.Tab_Versions.Controls.Add(this.toolStrip1);
            this.Tab_Versions.Location = new System.Drawing.Point(4, 24);
            this.Tab_Versions.Name = "Tab_Versions";
            this.Tab_Versions.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Versions.Size = new System.Drawing.Size(446, 215);
            this.Tab_Versions.TabIndex = 1;
            this.Tab_Versions.Text = "Versions";
            this.Tab_Versions.ToolTipText = "Versions/Commits of the Gist";
            this.Tab_Versions.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 184);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Language";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 95;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(440, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // Tab_Forks
            // 
            this.Tab_Forks.Controls.Add(this.listView2);
            this.Tab_Forks.Controls.Add(this.toolStrip2);
            this.Tab_Forks.Location = new System.Drawing.Point(4, 24);
            this.Tab_Forks.Name = "Tab_Forks";
            this.Tab_Forks.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Forks.Size = new System.Drawing.Size(446, 215);
            this.Tab_Forks.TabIndex = 2;
            this.Tab_Forks.Text = "Forks";
            this.Tab_Forks.ToolTipText = "Forks of the Gist";
            this.Tab_Forks.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(3, 28);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(440, 184);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Size";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Language";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            this.columnHeader8.Width = 95;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(440, 25);
            this.toolStrip2.TabIndex = 5;
            // 
            // Tab_Comments
            // 
            this.Tab_Comments.Controls.Add(this.listView3);
            this.Tab_Comments.Controls.Add(this.toolStrip3);
            this.Tab_Comments.Location = new System.Drawing.Point(4, 24);
            this.Tab_Comments.Name = "Tab_Comments";
            this.Tab_Comments.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Comments.Size = new System.Drawing.Size(446, 215);
            this.Tab_Comments.TabIndex = 3;
            this.Tab_Comments.Text = "Comments";
            this.Tab_Comments.ToolTipText = "Comments of the Gist";
            this.Tab_Comments.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.Location = new System.Drawing.Point(3, 28);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(440, 184);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 180;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Size";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Language";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Type";
            this.columnHeader12.Width = 95;
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(440, 25);
            this.toolStrip3.TabIndex = 5;
            // 
            // imageLabel1
            // 
            this.imageLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imageLabel1.Image = global::GistOne.Properties.Resources.node;
            this.imageLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imageLabel1.Location = new System.Drawing.Point(12, 118);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.imageLabel1.Size = new System.Drawing.Size(110, 30);
            this.imageLabel1.TabIndex = 2;
            this.imageLabel1.Text = "Forked of:";
            this.imageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imageLabel1.Visible = false;
            // 
            // Lnk_Forked
            // 
            this.Lnk_Forked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lnk_Forked.Location = new System.Drawing.Point(128, 118);
            this.Lnk_Forked.Name = "Lnk_Forked";
            this.Lnk_Forked.Size = new System.Drawing.Size(338, 30);
            this.Lnk_Forked.TabIndex = 10;
            this.Lnk_Forked.TabStop = true;
            this.Lnk_Forked.Text = "Loading...";
            this.Lnk_Forked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lnk_Forked.Visible = false;
            this.Lnk_Forked.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Forked_LinkClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // OpenGist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.Lnk_Forked);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbl_Visibility);
            this.Controls.Add(this.TabCont_Gist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Lbl_LastEdit);
            this.Controls.Add(this.Rtb_Gist);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Lbl_GistID);
            this.Controls.Add(this.Lbl_Created);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenGist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OpenGist";
            this.Load += new System.EventHandler(this.OpenGist_Load);
            this.Shown += new System.EventHandler(this.OpenGist_Shown);
            this.TabCont_Gist.ResumeLayout(false);
            this.Tab_Files.ResumeLayout(false);
            this.Toolbar_Files.ResumeLayout(false);
            this.Toolbar_Files.PerformLayout();
            this.Tab_Versions.ResumeLayout(false);
            this.Tab_Forks.ResumeLayout(false);
            this.Tab_Comments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_GistID;
        private ListView Lsv_Files;
        private ColumnHeader Col_Files_Name;
        private ColumnHeader Col_Files_Size;
        private ColumnHeader Col_Files_Lang;
        private ColumnHeader Col_Files_Type;
        private ImageLabel label9;
        private TextBox Txt_ID;
        private Label Lbl_LastEdit;
        private ImageLabel label13;
        private ImageLabel label12;
        private Label Lbl_Visibility;
        private Label Lbl_Created;
        private ImageLabel label11;
        private TextBox Txt_Description;
        private RichTextBox Rtb_Gist;
        private Button Btn_Save;
        private Button Btn_Close;
        private TabControl TabCont_Gist;
        private TabPage Tab_Files;
        private TabPage Tab_Versions;
        private ToolStrip Toolbar_Files;
        private TabPage Tab_Forks;
        private TabPage Tab_Comments;
        private ImageLabel imageLabel1;
        private LinkLabel Lnk_Forked;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ToolStrip toolStrip1;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ToolStrip toolStrip2;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ToolStrip toolStrip3;
        private ToolStripButton TsBtn_Files_Save;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsBtn_Files_Add;
        private ToolStripButton TsBtn_Files_Delete;
        private ToolStripSeparator toolStripSeparator2;
    }
}
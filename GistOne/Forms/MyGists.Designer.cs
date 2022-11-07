namespace GistOne.Forms
{
    partial class MyGists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Toolbar_Gists = new System.Windows.Forms.ToolStrip();
            this.TsLbl_Total = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lsv_Files = new System.Windows.Forms.ListView();
            this.Col_Files_Name = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Size = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Lang = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Type = new System.Windows.Forms.ColumnHeader();
            this.Lnk_Link = new System.Windows.Forms.LinkLabel();
            this.label3 = new GistOne.ImageLabel();
            this.label9 = new GistOne.ImageLabel();
            this.label15 = new GistOne.ImageLabel();
            this.Lbl_Comments = new System.Windows.Forms.Label();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.label14 = new GistOne.ImageLabel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_LastEdit = new System.Windows.Forms.Label();
            this.label13 = new GistOne.ImageLabel();
            this.label12 = new GistOne.ImageLabel();
            this.Lbl_Visibility = new System.Windows.Forms.Label();
            this.Lbl_Created = new System.Windows.Forms.Label();
            this.label11 = new GistOne.ImageLabel();
            this.label10 = new GistOne.ImageLabel();
            this.Dgw_Gists = new System.Windows.Forms.DataGridView();
            this.DgwCol_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgwCol_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toolbar_Gists.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Gists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Gists";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Search.Location = new System.Drawing.Point(12, 43);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.PlaceholderText = "Search a Gist...";
            this.Txt_Search.Size = new System.Drawing.Size(779, 29);
            this.Txt_Search.TabIndex = 0;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Image = global::GistOne.Properties.Resources.arrow_refresh16;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.Location = new System.Drawing.Point(797, 43);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 29);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Tag = "";
            this.Btn_Search.Text = "&Refresh";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Toolbar_Gists
            // 
            this.Toolbar_Gists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Toolbar_Gists.AutoSize = false;
            this.Toolbar_Gists.Dock = System.Windows.Forms.DockStyle.None;
            this.Toolbar_Gists.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar_Gists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLbl_Total,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.Toolbar_Gists.Location = new System.Drawing.Point(12, 88);
            this.Toolbar_Gists.Name = "Toolbar_Gists";
            this.Toolbar_Gists.Size = new System.Drawing.Size(400, 25);
            this.Toolbar_Gists.TabIndex = 2;
            // 
            // TsLbl_Total
            // 
            this.TsLbl_Total.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsLbl_Total.Name = "TsLbl_Total";
            this.TsLbl_Total.Size = new System.Drawing.Size(44, 22);
            this.TsLbl_Total.Text = "Total: 0";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GistOne.Properties.Resources.book_open;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "&Open";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::GistOne.Properties.Resources.textfield_rename;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(130, 22);
            this.toolStripButton3.Text = "&Change description";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::GistOne.Properties.Resources.world;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton4.Text = "Copy &URL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::GistOne.Properties.Resources.cross;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "&Delete";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Lsv_Files);
            this.groupBox1.Controls.Add(this.Lnk_Link);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Lbl_Comments);
            this.groupBox1.Controls.Add(this.Txt_Description);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.Lbl_LastEdit);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Lbl_Visibility);
            this.groupBox1.Controls.Add(this.Lbl_Created);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(418, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 406);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // Lsv_Files
            // 
            this.Lsv_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lsv_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Files_Name,
            this.Col_Files_Size,
            this.Col_Files_Lang,
            this.Col_Files_Type});
            this.Lsv_Files.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lsv_Files.FullRowSelect = true;
            this.Lsv_Files.GridLines = true;
            this.Lsv_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lsv_Files.Location = new System.Drawing.Point(6, 285);
            this.Lsv_Files.MultiSelect = false;
            this.Lsv_Files.Name = "Lsv_Files";
            this.Lsv_Files.Size = new System.Drawing.Size(442, 115);
            this.Lsv_Files.TabIndex = 2;
            this.Lsv_Files.UseCompatibleStateImageBehavior = false;
            this.Lsv_Files.View = System.Windows.Forms.View.Details;
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
            // Lnk_Link
            // 
            this.Lnk_Link.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lnk_Link.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lnk_Link.Location = new System.Drawing.Point(77, 205);
            this.Lnk_Link.Name = "Lnk_Link";
            this.Lnk_Link.Size = new System.Drawing.Size(371, 30);
            this.Lnk_Link.TabIndex = 3;
            this.Lnk_Link.TabStop = true;
            this.Lnk_Link.Text = "Link";
            this.Lnk_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lnk_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Link_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Image = global::GistOne.Properties.Resources.attach;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 257);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(442, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Files:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Image = global::GistOne.Properties.Resources.barcode_2d;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(110, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Image = global::GistOne.Properties.Resources.world;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(6, 205);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label15.Size = new System.Drawing.Size(65, 30);
            this.label15.TabIndex = 2;
            this.label15.Text = "URL:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Comments
            // 
            this.Lbl_Comments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Comments.Location = new System.Drawing.Point(122, 175);
            this.Lbl_Comments.Name = "Lbl_Comments";
            this.Lbl_Comments.Size = new System.Drawing.Size(326, 30);
            this.Lbl_Comments.TabIndex = 0;
            this.Lbl_Comments.Text = "0";
            this.Lbl_Comments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Description
            // 
            this.Txt_Description.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Description.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Description.HideSelection = false;
            this.Txt_Description.Location = new System.Drawing.Point(126, 62);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.ReadOnly = true;
            this.Txt_Description.Size = new System.Drawing.Size(322, 18);
            this.Txt_Description.TabIndex = 1;
            this.Txt_Description.Text = "---";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Image = global::GistOne.Properties.Resources.comments;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(6, 175);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label14.Size = new System.Drawing.Size(110, 30);
            this.label14.TabIndex = 2;
            this.label14.Text = "Comments:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_ID.HideSelection = false;
            this.Txt_ID.Location = new System.Drawing.Point(126, 32);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(322, 18);
            this.Txt_ID.TabIndex = 0;
            this.Txt_ID.Text = "---";
            // 
            // Lbl_LastEdit
            // 
            this.Lbl_LastEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LastEdit.Location = new System.Drawing.Point(122, 145);
            this.Lbl_LastEdit.Name = "Lbl_LastEdit";
            this.Lbl_LastEdit.Size = new System.Drawing.Size(326, 30);
            this.Lbl_LastEdit.TabIndex = 0;
            this.Lbl_LastEdit.Text = "---";
            this.Lbl_LastEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Image = global::GistOne.Properties.Resources.date_edit;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(6, 145);
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
            this.label12.Location = new System.Drawing.Point(6, 115);
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
            this.Lbl_Visibility.Location = new System.Drawing.Point(122, 85);
            this.Lbl_Visibility.Name = "Lbl_Visibility";
            this.Lbl_Visibility.Size = new System.Drawing.Size(326, 30);
            this.Lbl_Visibility.TabIndex = 0;
            this.Lbl_Visibility.Text = "---";
            this.Lbl_Visibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Created
            // 
            this.Lbl_Created.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Created.Location = new System.Drawing.Point(122, 115);
            this.Lbl_Created.Name = "Lbl_Created";
            this.Lbl_Created.Size = new System.Drawing.Size(326, 30);
            this.Lbl_Created.TabIndex = 0;
            this.Lbl_Created.Text = "---";
            this.Lbl_Created.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Image = global::GistOne.Properties.Resources.share;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(110, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Visibility:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Image = global::GistOne.Properties.Resources.bookmark_red;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(110, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Description:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dgw_Gists
            // 
            this.Dgw_Gists.AllowUserToAddRows = false;
            this.Dgw_Gists.AllowUserToDeleteRows = false;
            this.Dgw_Gists.AllowUserToResizeColumns = false;
            this.Dgw_Gists.AllowUserToResizeRows = false;
            this.Dgw_Gists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgw_Gists.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgw_Gists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_Gists.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgw_Gists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_Gists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Gists.ColumnHeadersVisible = false;
            this.Dgw_Gists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgwCol_ID,
            this.DgwCol_Img,
            this.DgwCol_Text});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Gists.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgw_Gists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgw_Gists.Location = new System.Drawing.Point(12, 116);
            this.Dgw_Gists.MultiSelect = false;
            this.Dgw_Gists.Name = "Dgw_Gists";
            this.Dgw_Gists.ReadOnly = true;
            this.Dgw_Gists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_Gists.RowHeadersVisible = false;
            this.Dgw_Gists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgw_Gists.RowTemplate.Height = 50;
            this.Dgw_Gists.RowTemplate.ReadOnly = true;
            this.Dgw_Gists.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Gists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Gists.ShowEditingIcon = false;
            this.Dgw_Gists.Size = new System.Drawing.Size(400, 378);
            this.Dgw_Gists.TabIndex = 3;
            this.Dgw_Gists.SelectionChanged += new System.EventHandler(this.Dgw_Gists_SelectionChanged);
            // 
            // DgwCol_ID
            // 
            this.DgwCol_ID.Frozen = true;
            this.DgwCol_ID.HeaderText = "";
            this.DgwCol_ID.MaxInputLength = 256;
            this.DgwCol_ID.Name = "DgwCol_ID";
            this.DgwCol_ID.ReadOnly = true;
            this.DgwCol_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_ID.Visible = false;
            // 
            // DgwCol_Img
            // 
            this.DgwCol_Img.Frozen = true;
            this.DgwCol_Img.HeaderText = "";
            this.DgwCol_Img.MinimumWidth = 45;
            this.DgwCol_Img.Name = "DgwCol_Img";
            this.DgwCol_Img.ReadOnly = true;
            this.DgwCol_Img.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_Img.Width = 45;
            // 
            // DgwCol_Text
            // 
            this.DgwCol_Text.Frozen = true;
            this.DgwCol_Text.HeaderText = "";
            this.DgwCol_Text.Name = "DgwCol_Text";
            this.DgwCol_Text.ReadOnly = true;
            this.DgwCol_Text.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MyGists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.Dgw_Gists);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Toolbar_Gists);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyGists";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MyGists";
            this.Load += new System.EventHandler(this.MyGists_Load);
            this.Shown += new System.EventHandler(this.MyGists_Shown);
            this.Resize += new System.EventHandler(this.MyGists_Resize);
            this.StyleChanged += new System.EventHandler(this.MyGists_StyleChanged);
            this.Toolbar_Gists.ResumeLayout(false);
            this.Toolbar_Gists.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Gists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Txt_Search;
        private Button Btn_Search;
        private ToolStrip Toolbar_Gists;
        private GroupBox groupBox1;
        private TextBox Txt_Description;
        private Label Lbl_LastEdit;
        private Label Lbl_Created;
        private ListView Lsv_Files;
        private ColumnHeader Col_Files_Name;
        private ImageLabel label3;
        private ColumnHeader Col_Files_Size;
        private ColumnHeader Col_Files_Lang;
        private ColumnHeader Col_Files_Type;
        private Label Lbl_Comments;
        private Label Lbl_Visibility;
        private LinkLabel Lnk_Link;
        private TextBox Txt_ID;
        private DataGridView Dgw_Gists;
        private DataGridViewTextBoxColumn DgwCol_ID;
        private DataGridViewImageColumn DgwCol_Img;
        private DataGridViewTextBoxColumn DgwCol_Text;
        private ImageLabel label9;
        private ImageLabel label10;
        private ImageLabel label11;
        private ImageLabel label12;
        private ImageLabel label13;
        private ImageLabel label14;
        private ImageLabel label15;
        private ToolStripLabel TsLbl_Total;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
    }
}
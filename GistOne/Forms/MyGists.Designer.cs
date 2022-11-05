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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lsv_Gists = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lnk_Comments = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Col_Files_Name = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Size = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Lang = new System.Windows.Forms.ColumnHeader();
            this.Col_Files_Type = new System.Windows.Forms.ColumnHeader();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_LastEdit = new System.Windows.Forms.Label();
            this.Lbl_Created = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.Txt_Search.TabIndex = 2;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Location = new System.Drawing.Point(797, 43);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 29);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Tag = "";
            this.Btn_Search.Text = "&Refresh";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Lsv_Gists
            // 
            this.Lsv_Gists.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.Lsv_Gists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lsv_Gists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Lsv_Gists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lsv_Gists.FullRowSelect = true;
            this.Lsv_Gists.Location = new System.Drawing.Point(12, 113);
            this.Lsv_Gists.MultiSelect = false;
            this.Lsv_Gists.Name = "Lsv_Gists";
            this.Lsv_Gists.Size = new System.Drawing.Size(400, 381);
            this.Lsv_Gists.TabIndex = 4;
            this.Lsv_Gists.TileSize = new System.Drawing.Size(490, 60);
            this.Lsv_Gists.UseCompatibleStateImageBehavior = false;
            this.Lsv_Gists.View = System.Windows.Forms.View.Tile;
            this.Lsv_Gists.SelectedIndexChanged += new System.EventHandler(this.Lsv_Gists_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(12, 88);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Lnk_Comments);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.Txt_Description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_LastEdit);
            this.groupBox1.Controls.Add(this.Lbl_Created);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(418, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // Lnk_Comments
            // 
            this.Lnk_Comments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lnk_Comments.Location = new System.Drawing.Point(111, 146);
            this.Lnk_Comments.Name = "Lnk_Comments";
            this.Lnk_Comments.Size = new System.Drawing.Size(97, 25);
            this.Lnk_Comments.TabIndex = 3;
            this.Lnk_Comments.TabStop = true;
            this.Lnk_Comments.Text = "0";
            this.Lnk_Comments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lnk_Comments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Comments_LinkClicked);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Files_Name,
            this.Col_Files_Size,
            this.Col_Files_Lang,
            this.Col_Files_Type});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(6, 285);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 115);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Txt_Description
            // 
            this.Txt_Description.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Description.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Description.Location = new System.Drawing.Point(6, 53);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.ReadOnly = true;
            this.Txt_Description.Size = new System.Drawing.Size(442, 25);
            this.Txt_Description.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Files:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Comments:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_LastEdit
            // 
            this.Lbl_LastEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LastEdit.Location = new System.Drawing.Point(6, 116);
            this.Lbl_LastEdit.Name = "Lbl_LastEdit";
            this.Lbl_LastEdit.Size = new System.Drawing.Size(442, 25);
            this.Lbl_LastEdit.TabIndex = 0;
            this.Lbl_LastEdit.Text = "Last edit:";
            this.Lbl_LastEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Created
            // 
            this.Lbl_Created.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Created.Location = new System.Drawing.Point(6, 86);
            this.Lbl_Created.Name = "Lbl_Created";
            this.Lbl_Created.Size = new System.Drawing.Size(442, 25);
            this.Lbl_Created.TabIndex = 0;
            this.Lbl_Created.Text = "Created:";
            this.Lbl_Created.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyGists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Lsv_Gists);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Txt_Search;
        private Button Btn_Search;
        private ListView Lsv_Gists;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private TextBox Txt_Description;
        private Label label2;
        private Label Lbl_LastEdit;
        private Label Lbl_Created;
        private ListView listView1;
        private ColumnHeader Col_Files_Name;
        private Label label3;
        private ColumnHeader Col_Files_Size;
        private ColumnHeader Col_Files_Lang;
        private ColumnHeader Col_Files_Type;
        private LinkLabel Lnk_Comments;
        private Label label4;
    }
}
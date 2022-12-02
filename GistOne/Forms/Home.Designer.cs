namespace GistOne.Forms
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgw_Gists = new System.Windows.Forms.DataGridView();
            this.DgwCol_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgwCol_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_LastEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgwCol_URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Toolbar_Gists = new System.Windows.Forms.ToolStrip();
            this.TsLbl_Total = new System.Windows.Forms.ToolStripLabel();
            this.TsBtn_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_PagePrev = new System.Windows.Forms.ToolStripButton();
            this.Txt_Page = new System.Windows.Forms.ToolStripTextBox();
            this.TsBtn_PageNext = new System.Windows.Forms.ToolStripButton();
            this.TsBtn_GotToPage = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Gists)).BeginInit();
            this.Toolbar_Gists.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgw_Gists
            // 
            this.Dgw_Gists.AllowUserToAddRows = false;
            this.Dgw_Gists.AllowUserToDeleteRows = false;
            this.Dgw_Gists.AllowUserToResizeColumns = false;
            this.Dgw_Gists.AllowUserToResizeRows = false;
            this.Dgw_Gists.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgw_Gists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_Gists.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgw_Gists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_Gists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Gists.ColumnHeadersVisible = false;
            this.Dgw_Gists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgwCol_ID,
            this.DgwCol_Img,
            this.DgwCol_Description,
            this.DgwCol_User,
            this.DgwCol_Created,
            this.DgwCol_LastEdit,
            this.DgwCol_URL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Gists.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_Gists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgw_Gists.Location = new System.Drawing.Point(12, 68);
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
            this.Dgw_Gists.Size = new System.Drawing.Size(860, 426);
            this.Dgw_Gists.TabIndex = 4;
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
            // DgwCol_Description
            // 
            this.DgwCol_Description.Frozen = true;
            this.DgwCol_Description.HeaderText = "";
            this.DgwCol_Description.Name = "DgwCol_Description";
            this.DgwCol_Description.ReadOnly = true;
            this.DgwCol_Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DgwCol_User
            // 
            this.DgwCol_User.Frozen = true;
            this.DgwCol_User.HeaderText = "";
            this.DgwCol_User.MaxInputLength = 500;
            this.DgwCol_User.Name = "DgwCol_User";
            this.DgwCol_User.ReadOnly = true;
            this.DgwCol_User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_User.Visible = false;
            // 
            // DgwCol_Created
            // 
            this.DgwCol_Created.Frozen = true;
            this.DgwCol_Created.HeaderText = "";
            this.DgwCol_Created.MaxInputLength = 500;
            this.DgwCol_Created.Name = "DgwCol_Created";
            this.DgwCol_Created.ReadOnly = true;
            this.DgwCol_Created.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_Created.Visible = false;
            // 
            // DgwCol_LastEdit
            // 
            this.DgwCol_LastEdit.Frozen = true;
            this.DgwCol_LastEdit.HeaderText = "";
            this.DgwCol_LastEdit.MaxInputLength = 500;
            this.DgwCol_LastEdit.Name = "DgwCol_LastEdit";
            this.DgwCol_LastEdit.ReadOnly = true;
            this.DgwCol_LastEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_LastEdit.Visible = false;
            // 
            // DgwCol_URL
            // 
            this.DgwCol_URL.Frozen = true;
            this.DgwCol_URL.HeaderText = "";
            this.DgwCol_URL.Name = "DgwCol_URL";
            this.DgwCol_URL.ReadOnly = true;
            this.DgwCol_URL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCol_URL.Visible = false;
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
            this.TsBtn_Open,
            this.toolStripSeparator1,
            this.TsBtn_PagePrev,
            this.TsBtn_PageNext,
            this.TsBtn_GotToPage,
            this.Txt_Page});
            this.Toolbar_Gists.Location = new System.Drawing.Point(12, 40);
            this.Toolbar_Gists.Name = "Toolbar_Gists";
            this.Toolbar_Gists.Size = new System.Drawing.Size(860, 25);
            this.Toolbar_Gists.TabIndex = 5;
            // 
            // TsLbl_Total
            // 
            this.TsLbl_Total.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsLbl_Total.Name = "TsLbl_Total";
            this.TsLbl_Total.Size = new System.Drawing.Size(44, 22);
            this.TsLbl_Total.Text = "Total: 0";
            // 
            // TsBtn_Open
            // 
            this.TsBtn_Open.Image = global::GistOne.Properties.Resources.book_open;
            this.TsBtn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_Open.Name = "TsBtn_Open";
            this.TsBtn_Open.Size = new System.Drawing.Size(56, 22);
            this.TsBtn_Open.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsBtn_PagePrev
            // 
            this.TsBtn_PagePrev.Image = global::GistOne.Properties.Resources.control_rewind_blue;
            this.TsBtn_PagePrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_PagePrev.Name = "TsBtn_PagePrev";
            this.TsBtn_PagePrev.Size = new System.Drawing.Size(101, 22);
            this.TsBtn_PagePrev.Text = "&Previous page";
            this.TsBtn_PagePrev.Click += new System.EventHandler(this.TsBtn_PagePrev_Click);
            // 
            // Txt_Page
            // 
            this.Txt_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Page.Name = "Txt_Page";
            this.Txt_Page.ShortcutsEnabled = false;
            this.Txt_Page.Size = new System.Drawing.Size(50, 25);
            this.Txt_Page.Text = "0";
            this.Txt_Page.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Page_KeyPress);
            // 
            // TsBtn_PageNext
            // 
            this.TsBtn_PageNext.Image = global::GistOne.Properties.Resources.control_fastforward_blue;
            this.TsBtn_PageNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_PageNext.Name = "TsBtn_PageNext";
            this.TsBtn_PageNext.Size = new System.Drawing.Size(81, 22);
            this.TsBtn_PageNext.Text = "&Next page";
            this.TsBtn_PageNext.Click += new System.EventHandler(this.TsBtn_PageNext_Click);
            // 
            // TsBtn_GotToPage
            // 
            this.TsBtn_GotToPage.Image = global::GistOne.Properties.Resources.find;
            this.TsBtn_GotToPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtn_GotToPage.Name = "TsBtn_GotToPage";
            this.TsBtn_GotToPage.Size = new System.Drawing.Size(86, 22);
            this.TsBtn_GotToPage.Text = "&GoTo page:";
            this.TsBtn_GotToPage.Click += new System.EventHandler(this.TsBtn_GotToPage_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.Toolbar_Gists);
            this.Controls.Add(this.Dgw_Gists);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Gists)).EndInit();
            this.Toolbar_Gists.ResumeLayout(false);
            this.Toolbar_Gists.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private DataGridView Dgw_Gists;
        private DataGridViewTextBoxColumn DgwCol_ID;
        private DataGridViewImageColumn DgwCol_Img;
        private DataGridViewTextBoxColumn DgwCol_Description;
        private DataGridViewTextBoxColumn DgwCol_User;
        private DataGridViewTextBoxColumn DgwCol_Created;
        private DataGridViewTextBoxColumn DgwCol_LastEdit;
        private DataGridViewLinkColumn DgwCol_URL;
        private ToolStrip Toolbar_Gists;
        private ToolStripLabel TsLbl_Total;
        private ToolStripButton TsBtn_Open;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsBtn_PagePrev;
        private ToolStripTextBox Txt_Page;
        private ToolStripButton TsBtn_PageNext;
        private ToolStripButton TsBtn_GotToPage;
    }
}
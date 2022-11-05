namespace GistOne.Forms
{
    partial class Settings
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txt_Token = new System.Windows.Forms.TextBox();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(397, 226);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "&Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_Token
            // 
            this.Txt_Token.Location = new System.Drawing.Point(12, 12);
            this.Txt_Token.Name = "Txt_Token";
            this.Txt_Token.PlaceholderText = "Your GitHub token";
            this.Txt_Token.Size = new System.Drawing.Size(460, 23);
            this.Txt_Token.TabIndex = 1;
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(12, 41);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PlaceholderText = "Your GitHub username";
            this.Txt_Username.Size = new System.Drawing.Size(460, 23);
            this.Txt_Username.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Txt_Token);
            this.Controls.Add(this.Btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Save;
        private TextBox Txt_Token;
        private TextBox Txt_Username;
    }
}
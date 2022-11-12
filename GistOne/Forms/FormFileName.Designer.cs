namespace GistOne.Forms
{
    partial class FormFileName
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
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Image = global::GistOne.Properties.Resources.diskette;
            this.Btn_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ok.Location = new System.Drawing.Point(100, 46);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(47, 23);
            this.Btn_Ok.TabIndex = 0;
            this.Btn_Ok.Text = "&Ok";
            this.Btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Image = global::GistOne.Properties.Resources.cancel;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.Location = new System.Drawing.Point(12, 46);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(61, 23);
            this.Btn_Cancel.TabIndex = 0;
            this.Btn_Cancel.Text = "&Close";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // FormFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 81);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFileName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Ok;
        private TextBox textBox1;
        private Button Btn_Cancel;
    }
}
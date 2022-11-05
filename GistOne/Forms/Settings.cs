namespace GistOne.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                Txt_Token.Text = Functions.Settings.Token;
                Txt_Username.Text = Functions.Settings.Username;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Functions.Settings.Token = Txt_Token.Text.Trim();
                Functions.Settings.Username = Txt_Username.Text.Trim();

                Functions.SaveSettings();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

namespace GistOne.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            panel1.DoubleBuffering();
            Functions.FM = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Application.ProductName;

                Functions.ReadSettings();

                Functions.LoadAllForms();
                Functions.ParseForm("Home",false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region MainMenu

        private void TsBtn_Home_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm((ToolStripButton)sender);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm((ToolStripButton)sender);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm((ToolStripButton)sender);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Settings_Click(object sender, EventArgs e)
        {
            try
            {
                Settings S = new();
                S.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_About_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion


        #region Voids


        private void OpenForm(ToolStripButton TSBTN)
        {
            Functions.ParseForm(TSBTN.Name.Split("_").Last<string>(),false);
        }




        #endregion

    }
}

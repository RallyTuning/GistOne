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
                Functions.ParseForm("Home", Functions.Action.Open);
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

        private void TsBtn_Opened_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string Name = e.ClickedItem.Tag.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(Name)) { return; }

                Functions.ParseForm(Name, Functions.Action.Open);
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


        private static void OpenForm(ToolStripButton TSBTN)
        {
            string Name = TSBTN.Name.Split("_").Last<string>();
            if (string.IsNullOrWhiteSpace(Name)) { return; }

            Functions.ParseForm(Name, Functions.Action.Open);
        }





        #endregion

        
    }
}

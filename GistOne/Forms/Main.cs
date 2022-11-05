namespace GistOne.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            panel1.DoubleBuffering();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Application.ProductName;

                Functions.ReadSettings();

                LoadAllForms();
                OpenForm("Home");
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
                Settings S =new();
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

        private void LoadAllForms()
        {
            List<Form> FormList = new() { new Home(), new MyGists() };

            foreach (Form F in FormList)
            {
                F.TopLevel = false;        // First
                panel1.Controls.Add(F);   // Then
                F.Dock = DockStyle.Fill; // Finally
            }
        }

        private void OpenForm(ToolStripButton TSBTN)
        {
            OpenForm(TSBTN.Name.Split("_").Last<string>());
        }

        private void OpenForm(string Name)
        {
            panel1.SuspendLayout();
            foreach (Form F in panel1.Controls.OfType<Form>())
            {
                if (F.Name == Name)
                { F.Show(); }
                else
                { F.Hide(); }
            }
            panel1.ResumeLayout();
        }


        #endregion

    }
}

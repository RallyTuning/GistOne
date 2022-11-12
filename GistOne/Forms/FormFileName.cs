namespace GistOne.Forms
{
    public partial class FormFileName : Form
    {
        private readonly ListView.ListViewItemCollection? Coll = null;
        private readonly int Idx = 0;   

        public string NewName { get; set; } = string.Empty;

        public FormFileName(ListView.ListViewItemCollection FileColl, int Index)
        {
            InitializeComponent();

            Coll = FileColl;
            Idx = Index;
            textBox1.Text = FileColl[Index].Text;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("File name is mandatory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (Coll is null) { throw new Exception("Collection is empty"); }
if (Coll[Idx].Text.ToLower().Trim() == textBox1.Text.ToLower().Trim()) {  DialogResult= DialogResult.Cancel; return; }

                foreach (ListViewItem item in Coll)
                {
                    if (item.Text.ToLower().Equals(textBox1.Text.ToLower()))
                    {
                        MessageBox.Show("File name already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                }

                

                NewName = textBox1.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

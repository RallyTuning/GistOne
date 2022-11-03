using System.Text.Json;

namespace GistOne.Forms
{
    public partial class MyGists : Form
    {
        public MyGists()
        {
            InitializeComponent();
        }

        private void MyGists_Load(object sender, EventArgs e)
        {

        }

        private void MyGists_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadGists();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void LoadGists()
        {
            ListViewItem LvItmTmp = new("Loading. Please wait...");
            Lsv_Gists.Items.Add(LvItmTmp);

            List<Gist> GistsList = new();
            int CurPage = 1;

            while (true)
            {
                GistNet.Browse TheGist = new(Functions.tmptoken, "RallyTuning", 100, CurPage);
                string ReturnedString = await TheGist.GetAll();

                if (string.IsNullOrWhiteSpace(ReturnedString)) { throw new Exception("Json is empty"); }

                List<Gist> TempList = JsonSerializer.Deserialize<List<Gist>>(ReturnedString);

                if (TempList is null || TempList.Count == 0) { break; }

                GistsList.AddRange(TempList);

                CurPage++;
            }

            if (GistsList is null) { throw new Exception("Json is empty"); }

            Lsv_Gists.Items.Clear();

            foreach (Gist G in GistsList)
            {
                if (G is null) { return; }

                ListViewItem LvItm = new(G.Description) { Tag = G.ID };
                LvItm.SubItems.Add(G.Created_At.ToString());
                LvItm.SubItems.Add(G.Public.ToString());
                LvItm.SubItems.Add(G.Updated_At.ToString());
                LvItm.SubItems.Add(G.Files.Count.ToString());
                LvItm.SubItems.Add(G.URL);

                Lsv_Gists.Items.Add(LvItm);
            }
        }

        private void MyGists_Resize(object sender, EventArgs e)
        {
            try
            {
                Lsv_Gists.TileSize = new Size(Lsv_Gists.Width - 25, 50);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MyGists_StyleChanged(object sender, EventArgs e)
        {
try
            {
                Lsv_Gists.TileSize = new Size(Lsv_Gists.Width - 25, 50);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

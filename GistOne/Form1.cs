//using GistNet;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace GistOne
{
    public partial class Form1 : Form
    {
        static readonly string tmptoken = File.ReadAllText("token.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.Create TheGist = new(tmptoken);
                TheGist.Content.IsPublic = false;
                TheGist.Content.Description = "una gist (" + new Random().Next(1, 100).ToString() + ") a caso per arrivare a 65";
                TheGist.Content.Files.Add("file " + new Random().Next(1, 100).ToString() + ".txt", new(new Random().Next(1, 999999).ToString()));
                //TheGist.Content.Files.Add("Z file.txt", new("contenuto del file"));
                //TheGist.Content.FilesList.Add("new file.cs", new("# potrebbe essere la descrizione della gist"));

                string jsonString = await TheGist.Push();
                Gist test = JsonSerializer.Deserialize<Gist>(jsonString);
                JsonNode Jobj = JsonNode.Parse(jsonString);


                //if (Jobj != null)
                //{
                //    Root jest = new()
                //    {
                //        Url = Jobj["url"].ToString(),
                //    };
                //}
                //var jsonString22 = await jsonString.Content.ReadAsStringAsync();
                //var jsonObject = JsonNode.Parse(jsonString22).AsObject();
                //Root test = JsonSerializer.Deserialize<Root>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Gist> GistsList = new();
                int CurPage = 1;

                while (true)
                {
                    GistNet.Browse TheGist = new(tmptoken, "RallyTuning", 100, CurPage);
                    string jsonString = await TheGist.GetAll();

                    if (string.IsNullOrWhiteSpace(jsonString)) { throw new Exception("Json is empty"); }

                    //JsonNode Jobj = JsonNode.Parse(jsonString)!;

                    //if (Jobj is null) { throw new Exception("Json is empty"); }

                    List<Gist> TempList = JsonSerializer.Deserialize<List<Gist>>(jsonString);

                    if (TempList is null || TempList.Count == 0) { break; }

                    GistsList.AddRange(TempList);

                    CurPage++;
                }

                if (GistsList is null) { throw new Exception("Json is empty"); }

                listView1.Items.Clear();

                foreach (Gist G in GistsList)
                {
                    if (G is null) { return; }

                    ListViewItem LvItm = new(G.ID) { Tag = G.ID };
                    LvItm.SubItems.Add(G.Description);
                    LvItm.SubItems.Add(G.Owner.Login);
                    LvItm.SubItems.Add(G.Public.ToString());
                    LvItm.SubItems.Add(G.Created_At.ToString());
                    LvItm.SubItems.Add(G.Updated_At.ToString());
                    LvItm.SubItems.Add(G.Files.Count.ToString());
                    LvItm.SubItems.Add(G.URL);

                    listView1.Items.Add(LvItm);
                }

                label1.Text = listView1.Items.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.UpdateGist Update = new(tmptoken, "cc738721b9610f6987e886ab8fb035c2");
                Update.Content.Description = "nuova descrizione" + " " + DateTime.Now.ToString("HH_mm_ss");
                Update.Content.Files.Add("aaa.txt", new("un nuovo file 1200000 " + DateTime.Now.ToString("HH_mm_ss")));

                string jsonString = await Update.Patch();
                Gist test = JsonSerializer.Deserialize<Gist>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.Delete TheGist = new(tmptoken, listView1.SelectedItems[0].Tag.ToString());
                string jsonString = await TheGist.Confirm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.GetByID TheGist = new(tmptoken, "f30e95f26dc3b63bc25f9bd664a0ddbb");
                string jsonString = await TheGist.Get();

                Gist test = JsonSerializer.Deserialize<Gist>(jsonString);
                //JsonNode Jobj = JsonNode.Parse(jsonString);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.RenameFiles Rename = new(tmptoken, "cc738721b9610f6987e886ab8fb035c2");
                Rename.Content.Files.Add("ok.cs", new GistNet.RenameFiles.Details.FileContent("aaa.txt"));
                //Rename.Content.Files.Add("il file.inf", new GistNet.RenameFiles.Details.FileContent("README.md"));
                string jsonString = await Rename.Patch();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            try
            {

                GistNet.DeleteFiles DelF = new(tmptoken, "cc738721b9610f6987e886ab8fb035c2");
                DelF.Content.Files.Add("aaa.txt", new());
                string jsonString = await DelF.Patch();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
                GistNet.GetGistRevision TheGist = new(tmptoken, "f30e95f26dc3b63bc25f9bd664a0ddbb", "a14f4ff9ef0efd9f585b00f81223b3e2fbc21304");
                string jsonString = await TheGist.Get();

                Gist test = JsonSerializer.Deserialize<Gist>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
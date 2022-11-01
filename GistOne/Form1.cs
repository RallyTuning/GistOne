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
                TheGist.Content.Description = "descrizione test, di non so quanti caratteri test";
                TheGist.Content.Files.Add("new file.cs", new("public Form1()\r\n        {\r\n            InitializeComponent();\r\n\r\n\r\n        }"));
                TheGist.Content.Files.Add("Z file.txt", new("contenuto del file"));
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
                GistNet.Browse TheGist = new(tmptoken, "RallyTuning");
                string jsonString = await TheGist.GetAll();

                if (string.IsNullOrWhiteSpace(jsonString)) { throw new Exception("Json is empty"); }

                //JsonNode Jobj = JsonNode.Parse(jsonString)!;

                //if (Jobj is null) { throw new Exception("Json is empty"); }

                List<Gist> GistsList = JsonSerializer.Deserialize<List<Gist>>(jsonString);

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
                GistNet.GetByID TheGist = new(tmptoken);
                string jsonString = await TheGist.Get("f30e95f26dc3b63bc25f9bd664a0ddbb");

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
    }
}
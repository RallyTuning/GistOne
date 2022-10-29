using GistNet;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace GistOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tmptoken = File.ReadAllText("token.txt");

                Create TheGist = new() { Token = tmptoken };
                TheGist.Content.IsPublic = false;
                TheGist.Content.Description = "descrizione test, di non so quanti caratteri test";
                TheGist.Content.FilesList.Add("new file.cs", new("public Form1()\r\n        {\r\n            InitializeComponent();\r\n\r\n\r\n        }"));
                //TheGist.Content.files.Add("Z file.txt", new("contenuto del file"));
                //TheGist.Content.files.Add("README.md", new("# potrebbe essere la descrizione della gist"));

                string jsonString = await TheGist.Push();
                JsonNode Jobj = JsonNode.Parse(jsonString);


                if (Jobj != null)
                {
                    Root jest = new()
                    {
                        Url = Jobj["url"].ToString(),
                    };
                }
                //var jsonString22 = await jsonString.Content.ReadAsStringAsync();
                //var jsonObject = JsonNode.Parse(jsonString22).AsObject();
                Root test = JsonSerializer.Deserialize<Root>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tmptoken = File.ReadAllText("token.txt");

                Browse TheGist = new() { Token = tmptoken, User = "RallyTuning" };
                string jsonString = await TheGist.Get();

                if (string.IsNullOrWhiteSpace(jsonString)) { throw new Exception("Json is empty"); }

                JsonNode Jobj = JsonNode.Parse(jsonString)!;

                if (Jobj is null) { throw new Exception("Json is empty"); }

                foreach (JsonNode? item in Jobj.AsArray())
                {
                    if (item is null) { return; }

                    ListViewItem LvItm = new(item["description"]!.ToString()) { Tag = item["id"].ToString() };
                    LvItm.SubItems.Add(item["public"].ToString());
                    LvItm.SubItems.Add(item["created_at"].ToString());
                    LvItm.SubItems.Add(item["updated_at"].ToString());
                    LvItm.SubItems.Add(item["url"].ToString());
                    JsonObject TmpNode = (JsonObject)item["files"];
                    LvItm.SubItems.Add(TmpNode.Count.ToString());

                    listView1.Items.Add(LvItm);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
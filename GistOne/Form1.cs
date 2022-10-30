using GistNet;
using System.Text.Json;
using System.Text.Json.Nodes;
using static GistOne.Gist;

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
                Create TheGist = new() { Token = tmptoken };
                TheGist.Content.IsPublic = false;
                TheGist.Content.Description = "descrizione test, di non so quanti caratteri test";
                TheGist.Content.FilesList.Add("new file.cs", new("public Form1()\r\n        {\r\n            InitializeComponent();\r\n\r\n\r\n        }"));
                TheGist.Content.FilesList.Add("Z file.txt", new("contenuto del file"));
                //TheGist.Content.FilesList.Add("README.md", new("# potrebbe essere la descrizione della gist"));

                string jsonString = await TheGist.Push();
                Rootobject test = JsonSerializer.Deserialize<Rootobject>(jsonString);
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
                Browse TheGist = new() { Token = tmptoken, User = "RallyTuning" };
                string jsonString = await TheGist.GetAll();

                if (string.IsNullOrWhiteSpace(jsonString)) { throw new Exception("Json is empty"); }

                JsonNode Jobj = JsonNode.Parse(jsonString)!;

                if (Jobj is null) { throw new Exception("Json is empty"); }

                listView1.Items.Clear();

                foreach (JsonNode? item in Jobj.AsArray())
                {
                    if (item is null) { return; }

                    ListViewItem LvItm = new(item["description"]!.ToString()) { Tag = item["id"].ToString() };
                    LvItm.SubItems.Add(item["id"].ToString());
                    LvItm.SubItems.Add(item["public"].ToString());
                    LvItm.SubItems.Add(item["created_at"].ToString());
                    LvItm.SubItems.Add(item["updated_at"].ToString());

                    JsonObject TmpNode = (JsonObject)item["files"];
                    LvItm.SubItems.Add(TmpNode.Count.ToString());

                    LvItm.SubItems.Add(item["url"].ToString());

                    listView1.Items.Add(LvItm);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Delete TheGist = new() { Token = tmptoken, ID = listView1.SelectedItems[0].Tag.ToString() };
                string jsonString = await TheGist.Confirm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                GistByID  TheGist = new() { Token = tmptoken };
                string jsonString = await TheGist.Get("f30e95f26dc3b63bc25f9bd664a0ddbb");

                Console.Write("");

                Rootobject test = JsonSerializer.Deserialize<Rootobject>(jsonString);
                JsonNode Jobj = JsonNode.Parse(jsonString);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
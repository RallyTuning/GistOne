using GistNet;
using System.Text.Json;

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
                TheGist.Content.@public = false;
                TheGist.Content.description = "descrizione test, di non so quanti caratteri test";
                TheGist.Content.files.Add("come creare un file quando non si ha nulla da fare.cs", new("public Form1()\r\n        {\r\n            InitializeComponent();\r\n\r\n\r\n        }"));
                //TheGist.Content.files.Add("Z file.txt", new("contenuto del file"));
                //TheGist.Content.files.Add("README.md", new("# potrebbe essere la descrizione della gist"));

                await TheGist.Push();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string tmptoken = File.ReadAllText("token.txt");

                //Create TheGist = new() { Token = tmptoken };
                //TheGist.Content.Public = false;
                //TheGist.Content.Description = "test";
                //TheGist.Content.Files.Add("test.md", new("# title\n\nthis is a test"));
                //TheGist.Content.Files.Add("file.txt", new("contenuto del file"));
                //TheGist.Content.Files.Add("altro file.md", new("this is only a test"));

                //string serializzato = JsonSerializer.Serialize(TheGist.Content);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
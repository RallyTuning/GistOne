using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace GistOne.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Config Set = new();
                Set.Token = "fdfsdfsdfsd";

                var Opzioni = new JsonSerializerOptions { WriteIndented = true };

                string JSONString = JsonSerializer.Serialize(Set, Opzioni);

                //if (!Directory.Exists(Funzioni.Path_MailingLists)) { Directory.CreateDirectory(Funzioni.Path_MailingLists); }

                using (FileStream FS = new("Settings.json", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    FS.SetLength(0);
                    using StreamWriter SW = new(FS, System.Text.Encoding.UTF8);
                    SW.Write(JSONString);
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Task<string> JsonString = File.ReadAllTextAsync("Settings.json");
                Config Set = JsonSerializer.Deserialize<Config>(JsonString.Result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

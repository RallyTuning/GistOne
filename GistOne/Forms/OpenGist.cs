using System.Diagnostics;
using System.Text.Json;

namespace GistOne.Forms
{
    public partial class OpenGist : Form
    {
        private string SelID = string.Empty;
        private Gist? SelGist = new();

        public OpenGist(string ID)
        {
            InitializeComponent();

            SelID = ID;
        }

        private void InWork(bool B)
        {
            Txt_Description.ReadOnly = B;
            Btn_Save.Enabled = !B;
            Rtb_Gist.ReadOnly = B;
            TabCont_Gist.Enabled = !B;
        }

        private void ImgLists()
        {
            ImageList ImgTab = new() { ColorDepth = ColorDepth.Depth24Bit };
            ImgTab.Images.AddRange(new Image[] { Properties.Resources.attach, Properties.Resources.diskette, Properties.Resources.node, Properties.Resources.comments });

            TabCont_Gist.ImageList = ImgTab;
            Tab_Files.ImageIndex = 0;
            Tab_Versions.ImageIndex = 1;
            Tab_Forks.ImageIndex = 2;
            Tab_Comments.ImageIndex = 3;
        }

        private async void OpenGist_Load(object sender, EventArgs e)
        {
            try
            {
                ImgLists();

                InWork(true);

                GistNet.GetByID TheGist = new(Functions.Settings.Token, SelID);
                string ReturnedString = await TheGist.Get();

                SelGist = JsonSerializer.Deserialize<Gist>(ReturnedString);

                if (SelGist is null) { throw new Exception("Unable to open the Gist"); }

                string ThisOrThis = String.IsNullOrWhiteSpace(SelGist.Description) ? SelGist.ID : SelGist.Description;
                this.Text = ThisOrThis;
                Lbl_GistID.Text = ThisOrThis;
                Txt_Description.Text = String.IsNullOrWhiteSpace(SelGist.Description) ? "" : SelGist.Description;
                Txt_ID.Text = SelGist.ID;
                Lbl_Created.Text = SelGist.Created_At.ToLongDateString() + " @ " + SelGist.Created_At.ToLongTimeString();
                Lbl_LastEdit.Text = SelGist.Updated_At.ToLongDateString() + " @ " + SelGist.Updated_At.ToLongTimeString();
                Lbl_Visibility.Text = SelGist.Public ? "Public" : "Private";
                Lbl_Visibility.ForeColor = SelGist.Public ? Color.ForestGreen : Color.Firebrick;

                if (!string.IsNullOrWhiteSpace(SelGist.Fork_Of.ID))
                {
                    imageLabel1.Visible = true;
                    Lnk_Forked.Visible = true;
                    Lnk_Forked.Text = String.Format("{0}/{1}", SelGist.Fork_Of.Owner.Login, SelGist.Fork_Of.ID);
                    Lnk_Forked.Tag = SelGist.Fork_Of.HTML_URL;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { InWork(false); }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                Functions.ParseForm(SelID, Functions.Action.Close);
                Functions.ParseForm("Home", Functions.Action.Open);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Lnk_Forked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string URL = Lnk_Forked.Tag.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(URL)) { return; }
                Process.Start(new ProcessStartInfo(URL) { UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

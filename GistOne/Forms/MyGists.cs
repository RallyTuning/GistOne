using System.Diagnostics;
using System.Text.Json;

namespace GistOne.Forms
{
    public partial class MyGists : Form
    {
        private readonly List<Gist> GistsList = new();

        public MyGists()
        {
            InitializeComponent();

            Lsv_Gists.DoubleBuffering();
            listView1.DoubleBuffering();
        }

        private void MyGists_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void MyGists_Shown(object sender, EventArgs e)
        {
            try
            {
                await LoadGists("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task LoadGists(string Filter)
        {
            try
            {
                Btn_Search.Enabled = false;
                Lsv_Gists.Items.Clear();
                Lsv_Gists.Items.Add(new ListViewItem("Loading. Please wait..."));

                await Task.Delay(100); // Just for avoid form flicker

                GistsList.Clear();
                int CurPage = 1;

                while (true)
                {
                    GistNet.Browse TheGist = new(Functions.Settings.Token, Functions.Settings.Username, 100, CurPage);
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

                    if (G.Description.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                    {
                        if (G.Description == "suavemente")
                        {
                        }
                        ListViewItem LvItm = new(G.Description) { Tag = G.ID };
                        string Sub = string.Format("Created: {0} | Files: {1}", G.Created_At.ToString(), G.Files.Count.ToString());
                        LvItm.SubItems.Add(Sub);

                        Lsv_Gists.Items.Add(LvItm);
                    }
                }
            }
            catch (Exception ex)
            {
                Lsv_Gists.Items.Clear();
                ListViewItem LvItmTmp = new("Error");
                LvItmTmp.SubItems.Add(ex.Message);
                Lsv_Gists.Items.Add(LvItmTmp);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Btn_Search.Enabled = true; }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Search.Text))
                {
                    Btn_Search.Text = "&Refresh";
                }
                else
                {
                    Btn_Search.Text = "&Search";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Search.Text == "&Refresh")
                {
                    await LoadGists("");
                }
                else
                {
                    await LoadGists(Txt_Search.Text.Trim());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MyGists_Resize(object sender, EventArgs e)
        {
            try
            {
                Lsv_Gists.TileSize = new Size(Lsv_Gists.Width - 25, 60);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MyGists_StyleChanged(object sender, EventArgs e)
        {
            try
            {
                Lsv_Gists.TileSize = new Size(Lsv_Gists.Width - 25, 60);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Lsv_Gists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Lsv_Gists.SelectedItems.Count < 1) { return; }


                ListViewItem SelItm = Lsv_Gists.SelectedItems[0];
                if (SelItm.Tag is not null)
                {
                    listView1.Items.Clear();

                    Gist G = GistsList.Where(T => T.ID == SelItm.Tag.ToString()).First();

                    Txt_Description.Text = G.Description;
                    Lbl_Created.Text = "Created: " + G.Created_At.ToString();
                    Lbl_LastEdit.Text = "Last edit: " + G.Updated_At.ToString();
                    Lnk_Comments.Text = G.Comments.ToString();
                    Lnk_Comments.Tag = G.HTML_URL;

                    foreach (FileDetails F in G.Files.Values)
                    {
                        ListViewItem LVI = new(F.Filename) { Tag = F.Raw_URL };
                        LVI.SubItems.Add(F.Size.ToString());
                        LVI.SubItems.Add(F.Language);
                        LVI.SubItems.Add(F.Type);
                        listView1.Items.Add(LVI);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Lnk_Comments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel TmpLnk = (LinkLabel)sender;
                if (TmpLnk is null || TmpLnk.Tag is null) { return; }

                Process.Start(new ProcessStartInfo(TmpLnk.Tag.ToString()!) { UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

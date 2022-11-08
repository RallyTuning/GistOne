using System.Data;
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

            Lsv_Files.DoubleBuffering();
            Dgw_Gists.DoubleBuffering();
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
                ClearCntls();
                Dgw_Gists.Rows.Clear();
                Dgw_Gists.Rows.Add(string.Empty, Properties.Resources.arrow_refresh, "Loading. Please wait...");
                Dgw_Gists.ClearSelection();

                await Task.Delay(100); // Just for avoid form flicker

                GistsList.Clear();
                int CurPage = 1;

                while (true)
                {
                    GistNet.MyGists TheGist = new(Functions.Settings.Token, 100, CurPage);
                    string ReturnedString = await TheGist.GetAll();


                    //string teeeeeeeeeeeeeeeest = await GetAll2();

                    //List<Gist> TempList2 = JsonSerializer.Deserialize<List<Gist>>(teeeeeeeeeeeeeeeest);

                    //if (string.IsNullOrWhiteSpace(ReturnedString)) { throw new Exception("Json is empty"); }

                    //GistNet.GetByID TheGist2 = new(Functions.Settings.Token, "37bcec303c536707903f43c78826103a");
                    //string testa = await TheGist2.Get();
                    //Gist testaG =JsonSerializer.Deserialize<Gist>(testa);


                    List<Gist> TempList = JsonSerializer.Deserialize<List<Gist>>(ReturnedString);

                    if (TempList is null || TempList.Count == 0) { break; }

                    GistsList.AddRange(TempList);

                    CurPage++;
                }

                if (GistsList is null) { throw new Exception("Json is empty"); }

                //Lsv_Gists.Items.Clear();
                //foreach (Gist G in GistsList)
                //{
                //    if (G is null) { return; }

                //    if (G.Description.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                //    {
                //        if (G.Description == "suavemente")
                //        {
                //        }
                //        ListViewItem LvItm = new(G.Description) { Tag = G.ID };
                //        string Sub = string.Format("Created: {0} | Files: {1}", G.Created_At.ToString(), G.Files.Count.ToString());
                //        LvItm.SubItems.Add(Sub);

                //        Lsv_Gists.Items.Add(LvItm);
                //    }
                //}

                //DataTable dt = new DataTable();
                //dt.Columns.Add(new DataColumn("DgwCol_ID"));
                //dt.Columns.Add(new DataColumn("Col_Img"));
                //dt.Columns.Add(new DataColumn("Col_Txt"));

                Dgw_Gists.Rows.Clear();
                foreach (Gist G in GistsList)
                {
                    if (G is null) { return; }
                    if (G.Description is null) { G.Description = ""; }

                    if (G.Description.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                    {
                        //dt.Rows.Add(G.ID, Properties.Resources.info_rhombus, G.Description);
                        Image Icon = G.Public ? Properties.Resources.page_white_world : Properties.Resources.page_white;
                        Dgw_Gists.Rows.Add(G.ID, Icon, G.Description, G.Owner.Login, G.Created_At, G.Updated_At, G.HTML_URL);
                    }
                }

                Dgw_Gists.ClearSelection();
                ClearCntls();

                //Dgw_Gists.DataSource = dt;
            }
            catch (Exception ex)
            {
                Dgw_Gists.Rows.Clear();
                Dgw_Gists.Rows.Add(string.Empty, Properties.Resources.exclamation, ex.Message);
                Dgw_Gists.ClearSelection();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Btn_Search.Enabled = true;
                TsLbl_Total.Text = "Total: " + Dgw_Gists.Rows.Count.ToString();
            }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Search.Text))
                {
                    Btn_Search.Text = "&Refresh";
                    Btn_Search.Image = Properties.Resources.arrow_refresh16;
                }
                else
                {
                    Btn_Search.Text = "&Search";
                    Btn_Search.Image = Properties.Resources.find;
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
                DgwCol_Description.Width = Dgw_Gists.Width - 20 - DgwCol_Img.Width;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void MyGists_StyleChanged(object sender, EventArgs e)
        {
            try
            {
                DgwCol_Description.Width = Dgw_Gists.Width - 20 - DgwCol_Img.Width;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Lnk_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //LinkLabel TmpLnk = (LinkLabel)sender;
                //if (TmpLnk is null || TmpLnk.Tag is null) { return; }

                //Process.Start(new ProcessStartInfo(TmpLnk.Tag.ToString()!) { UseShellExecute = true });

                Process.Start(new ProcessStartInfo(Lnk_Link.Text) { UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Dgw_Gists_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_Gists.SelectedRows.Count < 1) { return; }


                DataGridViewRow SelItm = Dgw_Gists.SelectedRows[0];
                if (SelItm is not null && !string.IsNullOrWhiteSpace(SelItm.Cells[0].Value.ToString()))
                {
                    Lsv_Files.Items.Clear();

                    Gist G = GistsList.Where(T => T.ID == SelItm.Cells[0].Value.ToString()).First();

                    Txt_ID.Text = G.ID;
                    Txt_Description.Text = G.Description;
                    Lbl_Visibility.Text = G.Public ? "Public" : "Private";
                    Lbl_Visibility.ForeColor = G.Public ? Color.ForestGreen : Color.Firebrick;

                    Lbl_Created.Text = G.Created_At.ToString();
                    Lbl_LastEdit.Text = G.Updated_At.ToString();
                    Lbl_Comments.Text = G.Comments.ToString();
                    Lnk_Link.Text = G.HTML_URL;

                    foreach (FileDetails F in G.Files.Values)
                    {
                        ListViewItem LVI = new(F.Filename);
                        LVI.SubItems.Add(F.Size.ToString());
                        LVI.SubItems.Add(F.Language);
                        LVI.SubItems.Add(F.Type);
                        Lsv_Files.Items.Add(LVI);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ClearCntls()
        {
            Lsv_Files.Items.Clear();

            Txt_ID.Text = string.Empty;
            Txt_Description.Text = string.Empty;
            Lbl_Visibility.Text = string.Empty;
            Lbl_Visibility.ForeColor = Color.Black;

            Lbl_Created.Text = string.Empty;
            Lbl_LastEdit.Text = string.Empty;
            Lbl_Comments.Text = string.Empty;
            Lnk_Link.Text = string.Empty;

            TsLbl_Total.Text = "Total: 0";
        }

        #region Toolbar

        private void TsBtn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_Gists.SelectedRows.Count < 1) { MessageBox.Show("No gist selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                string GID = Dgw_Gists.SelectedRows[0].Cells[DgwCol_ID.Index].Value.ToString() ?? "";

                OpenGist OG = new(GID);
                OG.Name = GID;
                OG.Text = GID;
                OG.TopLevel = false;         // First
                Functions.LoadOneForms(OG); // Then
                OG.Dock = DockStyle.Fill;  // Finally

                Functions.ParseForm(GID,false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_ChangeDesc_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_Gists.SelectedRows.Count < 1) { MessageBox.Show("No gist selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                string GID = Dgw_Gists.SelectedRows[0].Cells[DgwCol_ID.Index].Value.ToString() ?? "";

                Dgw_Gists.SelectedRows[0].Cells[DgwCol_Description.Index].ReadOnly = false;

                DataGridViewRow DGR = Dgw_Gists.SelectedRows[0];


                Dgw_Gists.CurrentCell = Dgw_Gists.SelectedRows[0].Cells[DgwCol_Description.Index];
                Dgw_Gists.BeginEdit(true);

                return;

                GistNet.UpdateGist ChangeDesc = new(Functions.Settings.Token, GID);
                ChangeDesc.Content.Description = "";

                string ReturnedString = await ChangeDesc.Patch();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_CopyUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_Gists.SelectedRows.Count < 1) { MessageBox.Show("No gist selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                string GURL = Dgw_Gists.SelectedRows[0].Cells[DgwCol_URL.Index].Value.ToString() ?? "";
                Clipboard.SetText(GURL);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_Gists.SelectedRows.Count < 1) { MessageBox.Show("No gist selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                string GID = Dgw_Gists.SelectedRows[0].Cells[DgwCol_ID.Index].Value.ToString() ?? "";

                if (MessageBox.Show("Are you sure you want to delete this Gist?" + Environment.NewLine + GID, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

                GistNet.Delete Destroy = new(Functions.Settings.Token, GID);
                string ReturnedString = await Destroy.Confirm();

                if (ReturnedString == "NoContent")
                {
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception(ReturnedString);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        #endregion
    }
}

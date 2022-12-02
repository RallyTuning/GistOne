using System.Text.Json;

namespace GistOne.Forms
{
    public partial class Home : Form
    {

        private readonly List<Gist> GistsList = new();

        public Home()
        {
            InitializeComponent();

            Dgw_Gists.DoubleBuffering();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                ClearCntls();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void Home_Shown(object sender, EventArgs e)
        {
            try
            {
                await LoadGists("", 30, 1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task LoadGists(string Filter, int PerPage, int CurPage)
        {
            try
            {
                ClearCntls();
                Dgw_Gists.Rows.Clear();
                Dgw_Gists.Rows.Add(string.Empty, Properties.Resources.arrow_refresh, "Loading. Please wait...", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                Dgw_Gists.ClearSelection();

                await Task.Delay(100); // Just for avoid form flicker

                GistsList.Clear();

                GistNet.Explore TheGist = new(Functions.Settings.Token, PerPage, CurPage);
                string ReturnedString = await TheGist.GetAll();

                List<Gist> TempList = JsonSerializer.Deserialize<List<Gist>>(ReturnedString);

                if (TempList is null || TempList.Count == 0) { return; }

                GistsList.AddRange(TempList);

                if (GistsList is null) { throw new Exception("Json is empty"); }

                Dgw_Gists.Rows.Clear();
                foreach (Gist G in GistsList)
                {
                    if (G is null) { return; }
                    if (G.Description is null) { G.Description = ""; }

                    if (G.Description.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                    {
                        Image Icon = await Functions.GetImageFromWebAsync(G.Owner.Avatar_URL);
                        string FileName = G.Files.Count > 0 ? G.Files.FirstOrDefault().Key.ToString() : "// No description and no files in this Gist. WTF ?! //";
                        Dgw_Gists.Rows.Add(G.ID, Icon, string.IsNullOrEmpty(G.Description) ? G.Files.FirstOrDefault().Key.ToString() : G.Description, G.Owner.Login, G.Created_At, G.Updated_At, G.HTML_URL);
                    }
                }

                Dgw_Gists.ClearSelection();
                ClearCntls();
            }
            catch (Exception ex)
            {
                Dgw_Gists.Rows.Clear();
                Dgw_Gists.Rows.Add(string.Empty, Properties.Resources.exclamation, ex.Message, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                Dgw_Gists.ClearSelection();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TsLbl_Total.Text = "Total: " + Dgw_Gists.Rows.Count.ToString();
            }
        }

        private void ClearCntls()
        {
            Cmb_GistsPerPage.SelectedIndex = 2;
            TsLbl_Total.Text = "Total: 0";
        }

        private void Txt_Page_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_PagePrev_Click(object sender, EventArgs e)
        {
            try
            {
                int CurPage = Convert.ToInt32(Txt_Page.Text);
                int PerPage = Convert.ToInt32(Cmb_GistsPerPage.SelectedItem.ToString());

                if (CurPage == 0)
                {
                    TsBtn_PagePrev.Enabled = false;
                }
                else
                {
                    TsBtn_PagePrev.Enabled = true;
                    CurPage -= 1;
                    Txt_Page.Text = CurPage.ToString();
                }

                await LoadGists("", PerPage, CurPage);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_PageNext_Click(object sender, EventArgs e)
        {
            try
            {
                int CurPage = Convert.ToInt32(Txt_Page.Text);
                int PerPage = Convert.ToInt32(Cmb_GistsPerPage.SelectedItem.ToString());

                TsBtn_PagePrev.Enabled = true;
                CurPage += 1;
                Txt_Page.Text = CurPage.ToString();

                await LoadGists("", PerPage, CurPage);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_GotToPage_Click(object sender, EventArgs e)
        {
            try
            {
                int PerPage = Convert.ToInt32(Cmb_GistsPerPage.SelectedItem.ToString());

                await LoadGists("", PerPage, Convert.ToInt32(Txt_Page.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            try
            {
                DgwCol_Description.Width = Dgw_Gists.Width - 20 ;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Home_StyleChanged(object sender, EventArgs e)
        {
            try
            {
                DgwCol_Description.Width = Dgw_Gists.Width - 20 ;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Dgw_Gists_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (Dgw_Gists.Columns["DgwCol_Description"].Index == e.ColumnIndex && e.RowIndex >= 0)
                {
                    using (Brush GridBrush = new SolidBrush(Dgw_Gists.GridColor), BackColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        using (Pen GridLinePen = new Pen(GridBrush))
                        {
                            e.Graphics.FillRectangle(BackColorBrush, e.CellBounds);// Erase the cell.
                            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                            Rectangle BackRect = new(e.CellBounds.X + 1, e.CellBounds.Y + 1, Dgw_Gists.Columns["DgwCol_Description"].Width  - 4, Dgw_Gists.Rows[e.RowIndex].Height - 4);
                            e.PaintBackground(BackRect, true);

                            Image Avatar = (Image)Dgw_Gists.Rows[e.RowIndex].Cells[Dgw_Gists.Columns["DgwCol_Img"].Index].Value;
                            e.Graphics.DrawImage((Image)new Bitmap(Avatar, new Size(70, 70)), new Point(e.CellBounds.X + 5, e.CellBounds.Y + 5));


                            Font FontID = new("Courier New", 10, FontStyle.Bold);
                            string StrID = Dgw_Gists.Rows[e.RowIndex].Cells[Dgw_Gists.Columns["DgwCol_ID"].Index].Value.ToString() ?? "No ID ?!";
                            Size SizeID = TextRenderer.MeasureText(StrID, FontID);

                            Font FontUser = new(e.CellStyle.Font.FontFamily, 11, FontStyle.Regular);
                            string StrUser = Dgw_Gists.Rows[e.RowIndex].Cells[Dgw_Gists.Columns["DgwCol_User"].Index].Value.ToString() ?? "No user ?!";
                            Size SizeUser = TextRenderer.MeasureText(StrUser, FontUser);

                            Font FontDesc = new(e.CellStyle.Font.FontFamily, 15, FontStyle.Regular);
                            string StrDesc = Dgw_Gists.Rows[e.RowIndex].Cells[Dgw_Gists.Columns["DgwCol_Description"].Index].Value.ToString() ?? "";
                            Size SizeDesc = TextRenderer.MeasureText(StrDesc, FontDesc);

                            Font FontDate = new(e.CellStyle.Font.FontFamily, 10, FontStyle.Regular);
                            string StrDate = Dgw_Gists.Rows[e.RowIndex].Cells[Dgw_Gists.Columns["DgwCol_Created"].Index].Value.ToString() ?? "No date ?!";
                            Size SizeDate = TextRenderer.MeasureText(StrDate, FontDate);



                            e.Graphics.DrawString(StrID, FontID, Brushes.Silver, e.CellBounds.Width - SizeID.Width  - 10,
                                e.CellBounds.Y + 10, StringFormat.GenericDefault);

                            e.Graphics.DrawString(StrUser, FontUser, Brushes.Black, e.CellBounds.X + 2 + 80,
                                e.CellBounds.Y + 10, StringFormat.GenericDefault);

                            e.Graphics.DrawString(StrDesc, FontDesc, Brushes.Black, e.CellBounds.X + 2 + 80,
                                e.CellBounds.Y + (SizeUser.Height == 0 ? 15 : SizeUser.Height) + 10, StringFormat.GenericDefault);

                            e.Graphics.DrawString(StrDate, FontDate, Brushes.DarkGray, e.CellBounds.X + 2 + 80,
                                e.CellBounds.Y + SizeUser.Height + 5 + SizeDesc.Height + 5, StringFormat.GenericDefault);


                            e.Handled = true;
                        }
                    }
                }

                //if (Dgw_Gists.Columns["DgwCol_Img"].Index == e.ColumnIndex && e.RowIndex >= 0)
                //{

                //}

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Dgw_Gists_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void OpenGist()
        {
            if (Dgw_Gists.SelectedRows.Count < 1) { return; }

            string GDesc = Dgw_Gists.SelectedRows[0].Cells[DgwCol_Description.Index].Value.ToString() ?? "";
            string GID = Dgw_Gists.SelectedRows[0].Cells[DgwCol_ID.Index].Value.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(GID)) { return; }

            OpenGist OG = new(GID)
            {
                Name = GID,
                Text = string.IsNullOrWhiteSpace(GDesc) ? GID : GDesc,
                TopLevel = false
            };

            Functions.LoadFormType Result = Functions.LoadOneForms(OG);

            switch (Result)
            {
                case Functions.LoadFormType.Loaded:
                    OG.Dock = DockStyle.Fill;

                    Functions.ParseForm(GID, Functions.Action.Open);

                    Functions.AddEntryOpened(GDesc, GID);

                    break;

                case Functions.LoadFormType.Exist:
                    Functions.ParseForm(GID, Functions.Action.Open);

                    break;

                default:
                    throw new Exception("Error opening \"" + GDesc + "\" (" + GID + ")");
            }

            Dgw_Gists.ClearSelection();
            ClearCntls();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Task<string> JsonString = File.ReadAllTextAsync("Settings.json");
        //        Config Set = JsonSerializer.Deserialize<Config>(JsonString.Result);
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //}
    }
}

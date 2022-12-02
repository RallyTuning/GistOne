using System.Text.Json;

namespace GistOne.Forms
{
    public partial class Home : Form
    {

        private readonly List<Gist> GistsList = new();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void Home_Shown(object sender, EventArgs e)
        {
            try
            {
                await LoadGists("", 1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task LoadGists(string Filter, int CurPage)
        {
            try
            {
                ClearCntls();
                Dgw_Gists.Rows.Clear();
                Dgw_Gists.Rows.Add(string.Empty, Properties.Resources.arrow_refresh, "Loading. Please wait...");
                Dgw_Gists.ClearSelection();

                //await Task.Delay(100); // Just for avoid form flicker

                GistsList.Clear();

                //while (true)
                //{
                    GistNet.Explore TheGist = new(Functions.Settings.Token, CurPage);
                    string ReturnedString = await TheGist.GetAll();

                    List<Gist> TempList = JsonSerializer.Deserialize<List<Gist>>(ReturnedString);

                    if (TempList is null || TempList.Count == 0) { return; }

                    GistsList.AddRange(TempList);

                    CurPage++;
                //}

                if (GistsList is null) { throw new Exception("Json is empty"); }

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
                TsLbl_Total.Text = "Total: " + Dgw_Gists.Rows.Count.ToString();
            }
        }

        private void ClearCntls()
        {


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

                await LoadGists("", CurPage);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_PageNext_Click(object sender, EventArgs e)
        {
            try
            {
                int CurPage = Convert.ToInt32(Txt_Page.Text);
                    TsBtn_PagePrev.Enabled = true;
                    CurPage += 1;
                    Txt_Page.Text = CurPage.ToString();
           
                await LoadGists("", CurPage);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void TsBtn_GotToPage_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadGists("", Convert.ToInt32(Txt_Page.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

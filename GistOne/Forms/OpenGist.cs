﻿using System.Diagnostics;
using System.Text.Json;

namespace GistOne.Forms
{
    public partial class OpenGist : Form
    {
        private readonly string SelID = string.Empty;
        private Gist? SelGist = new();


        public OpenGist(string ID)
        {
            InitializeComponent();

            try
            {
                SelID = ID;

                Rtb_Gist.DoubleBuffering();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Lock the form while is working/loading
        /// </summary>
        /// <param name="B">B-lock it? True or false</param>
        private void InWork(bool B)
        {
            Txt_Description.ReadOnly = B;
            Btn_Save.Enabled = !B;
            Rtb_Gist.ReadOnly = B;
            TabCont_Gist.Enabled = !B;
        }

        /// <summary>Create and set ImageLists</summary>
        private void ImgLists()
        {
            ImageList ImgTab = new() { ColorDepth = ColorDepth.Depth24Bit };
            ImgTab.Images.AddRange(new Image[] { Properties.Resources.attach, Properties.Resources.diskette, Properties.Resources.node, Properties.Resources.comments });

            TabCont_Gist.ImageList = ImgTab;
            Tab_Files.ImageIndex = 0;
            Tab_Versions.ImageIndex = 1;
            Tab_Forks.ImageIndex = 2;
            Tab_Comments.ImageIndex = 3;

            ImageList ImgFls = new() { ColorDepth = ColorDepth.Depth24Bit };
            ImgFls.Images.AddRange(new Image[] { Properties.Resources.yellow_lock, Properties.Resources.tick_red });
            Lsv_Files.SmallImageList = ImgFls;

        }

        private void OpenGist_Load(object sender, EventArgs e)
        {

        }

        /// <summary>Load Gist details after the form is shown</summary>
        private void OpenGist_Shown(object sender, EventArgs e)
        {
            try
            {
                ReadTheGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

#warning la modifica della descrizione e della gist va incorporata in un unica funzione
        /// <summary>Read the Gist details and fill the form</summary>
        private async void ReadTheGist()
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

                Lsv_Files.BeginUpdate();
                Lsv_Files.Items.Clear();
                foreach (FileDetails F in SelGist.Files.Values)
                {
                    ListViewItem LVI = new(F.Filename) { ImageIndex = 0, Tag = false };
                    LVI.SubItems.Add(F.Size.ToString());
                    LVI.SubItems.Add(F.Language);
                    LVI.SubItems.Add(F.Type);
                    Lsv_Files.Items.Add(LVI);
                }
                Lsv_Files.EndUpdate();

                //Rtb_Gist.Text = OpenGistFile(Lsv_Files.Items[0].Text); //SelGist.Files.Values.First().Content.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { InWork(false); }
        }

        /// <summary>
        /// Open a file by the name
        /// </summary>
        /// <param name="Filename">The name</param>
        /// <returns>The file content</returns>
        private string OpenGistFile(string Filename)
        {
            try
            {
                if (SelGist is null) { throw new Exception(); }

                return SelGist.Files[Filename].Content.ToString();
            }
            catch { return "Error opening file " + Filename; }
        }

        /// <summary>Close the Gist</summary>
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                Functions.ParseForm(SelID, Functions.Action.Close);
                Functions.ParseForm("Home", Functions.Action.Open);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Click on fork link</summary>
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

        /// <summary>Open a file content</summary>
        private void Lsv_Files_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Lsv_Files.SelectedItems.Count == 0) { return; }

                foreach (ListViewItem LI in Lsv_Files.Items)
                {
                    if ((bool)LI.Tag) { MessageBox.Show("You need to save first the file " + LI.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                }

                ListViewItem SelItm = Lsv_Files.SelectedItems[0];

                SelItm.ImageIndex = 1;
                SelItm.Tag = true;
                Rtb_Gist.Text = OpenGistFile(SelItm.Text);

                toolStripSeparator2.Visible = true;
                TsBtn_Files_Save.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Change the description</summary>
        private async void Txt_Description_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SelGist is null) { return; }

                if (Txt_Description.Text.Trim() != SelGist.Description)
                {
                    Txt_Description.Enabled = false;

                    GistNet.UpdateGist ChangeDesc = new(Functions.Settings.Token, SelID);
                    ChangeDesc.Content.Description = Txt_Description.Text.Trim();

                    await ChangeDesc.Patch();

                    ReadTheGist();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Txt_Description.Enabled = true; }
        }

        /// <summary>Before rename a file</summary>
        private void Lsv_Files_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                if ((bool)Lsv_Files.Items[e.Item].Tag) { e.CancelEdit = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>After rename a file</summary>
        private async void Lsv_Files_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                if (e.Label is null) { return; }

                Lsv_Files.Enabled = false;

                GistNet.RenameFiles RenameF = new(Functions.Settings.Token, SelID);
                RenameF.Content.Files.Add(Lsv_Files.Items[e.Item].Text, new(e.Label));

                await RenameF.Patch();

                ReadTheGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Lsv_Files.Enabled = true; }
        }


        #region Toolbar Files

        private void TsBtn_Files_Add_Click(object sender, EventArgs e)
        {
            try
            {


                ReadTheGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Files_Delete_Click(object sender, EventArgs e)
        {
            try
            {


                ReadTheGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Save the content of a file</summary>
        private async void TsBtn_Files_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Lsv_Files.Enabled = false;

                ListViewItem? EditItem = null;

                foreach (ListViewItem LI in Lsv_Files.Items)
                {
                    if ((bool)LI.Tag) { EditItem = LI; break; }
                }

                if (SelGist is null || EditItem is null) { throw new Exception("Can't get the item to save"); }
                if (SelGist.Files[EditItem.Text].Content.Trim().ToLower() == Rtb_Gist.Text.Trim().ToLower())
                {
                    EditItem.ImageIndex = 0;
                    EditItem.Tag = false;
                    return;
                }

                GistNet.UpdateGist EditFileContent = new(Functions.Settings.Token, SelID);
                EditFileContent.Content.Description = SelGist.Description; // Mandatory or will erase the description
                EditFileContent.Content.Files.Add(EditItem.Text, new(Rtb_Gist.Text));

                await EditFileContent.Patch();

                EditItem.ImageIndex = 0;
                EditItem.Tag = false;

                ReadTheGist();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                Lsv_Files.Enabled = true;
                toolStripSeparator2.Visible = false;
                TsBtn_Files_Save.Visible = false;
            }
        }

        #endregion
    }
}

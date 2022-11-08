using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GistOne.Forms
{
    public partial class OpenGist : Form
    {
        private string SelID =string.Empty;
        private Gist SelGist = new();

        public OpenGist(string ID)
        {
            InitializeComponent();

            SelID = ID;
        }

        private async void OpenGist_Load(object sender, EventArgs e)
        {
            try
            {
                Lbl_GistID.Text = SelID;

                GistNet.GetByID TheGist = new(Functions.Settings.Token, SelID);
                string ReturnedString = await TheGist.Get();

                SelGist = JsonSerializer.Deserialize<Gist>(ReturnedString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                Functions.ParseForm(SelID, true);
                Functions.ParseForm("Home", false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

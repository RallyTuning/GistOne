using GistOne.Forms;
using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;

namespace GistOne
{
    internal static class Functions
    {
        internal static readonly string AppPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GistOne");
        internal static readonly string ConfigPath = Path.Combine(AppPath, "Settings.json");

        //internal static readonly Task<string> tmptoken = File.ReadAllTextAsync("token.txt");

        internal static Config Settings { get; set; } = new();


        /// <summary>Abilita il Double Buffer sui controlli che non lo prevedono.</summary>
        /// <param name="Controllo">Controllo sul quale abilitare il Double Buffer.</param>
        /// <param name="Abilita">True abilita, False disabilita.</param>
        internal static void DoubleBuffering(this Control Controllo, bool Abilita = true)
        {
            if (Controllo != null)
            {
                System.Reflection.PropertyInfo? DBPI = Controllo.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (DBPI != null) { DBPI.SetValue(Controllo, Abilita); }
            }
        }

        internal static void SaveSettings()
        {
            try
            {
                JsonSerializerOptions Opzioni = new() { WriteIndented = true };
                string JSONString = JsonSerializer.Serialize(Settings, Opzioni);

                if (!Directory.Exists(AppPath)) { Directory.CreateDirectory(AppPath); }

                using (FileStream FS = new(ConfigPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    FS.SetLength(0);
                    using StreamWriter SW = new(FS, System.Text.Encoding.UTF8);
                    SW.Write(JSONString);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal static void ReadSettings()
        {
            try
            {
                if (!Directory.Exists(AppPath) || !File.Exists(ConfigPath))
                {
                    Directory.CreateDirectory(AppPath);
                    MessageBox.Show("Missing configuration file, in the next window please fill in the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Settings S = new();
                    if (S.ShowDialog() == DialogResult.Cancel) { return; }
                }

                Task<string> JsonString = File.ReadAllTextAsync(ConfigPath);
                Settings = JsonSerializer.Deserialize<Config>(JsonString.Result);
            }
            catch (JsonException) { MessageBox.Show("Corrupted configuration file. Please generate a new one!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal static Main? FM;

        internal static void LoadAllForms()
        {
            List<Form> FormList = new() { new Home(), new MyGists() };

            foreach (Form F in FormList)
            {
                LoadOneForms(F);
            }
        }

        internal enum LoadFormType
        {
            Loaded,
            Exist,
            None
        }

        internal static LoadFormType LoadOneForms(Form F)
        {
            if (FM == null) { return LoadFormType.None; }
            if(FM.panel1.Controls.ContainsKey(F.Name)) { 
                ParseForm(F.Name, Action.Open);
                return LoadFormType.Exist;
            }

            F.TopLevel = false;         // First
            FM.panel1.Controls.Add(F); // Then
            F.Dock = DockStyle.Fill;  // Finally

            return LoadFormType.Loaded;
        }

        internal enum Action { Open, Close }

        internal static void ParseForm(string Name, Action Act)
        {
            if (FM == null) { return; }

            Panel P = FM.panel1;

            P.SuspendLayout();
            foreach (Form F in P.Controls.OfType<Form>())
            {
                if (Act == Action.Close)
                {
                    if (F.Name == Name)
                    {
                        F.Dispose();
                        P.Controls.Remove(F);
                        RemoveEntryOpened(Name);
                        break;
                    }
                }
                else
                {
                    if (F.Name == Name)
                    { F.Show(); break; }
                    else
                    { F.Hide(); }
                }
            }
            P.ResumeLayout();
        }

        internal static void AddEntryOpened(string Name, string ID)
        {
            if (FM == null) { return; }

            ToolStripDropDownButton OpenedMenu = FM.TsBtn_Opened;

            ToolStripMenuItem NewBtn = new(string.IsNullOrWhiteSpace(Name) ? ID : Name)
            {
                Image = Properties.Resources.barcode_2d,
                Tag = ID,
                AutoSize = true
            };

            OpenedMenu.DropDownItems.Add(NewBtn);
            OpenedMenu.Image = Properties.Resources.inbox_document_text;
            //NewBtn.Width = TextRenderer.MeasureText(NewBtn.Text, NewBtn.Font).Width;
        }

        internal static void RemoveEntryOpened(string ID)
        {
            if (FM == null) { return; }

            ToolStripDropDownButton OpenedMenu = FM.TsBtn_Opened;

            foreach (ToolStripMenuItem B in OpenedMenu.DropDownItems)
            {
                if (B.Tag.ToString() == ID) { OpenedMenu.DropDownItems.Remove(B); break; }
            }

            OpenedMenu.Image = OpenedMenu.DropDownItems.Count == 0 ? Properties.Resources.inbox_empty : Properties.Resources.inbox_document_text;
        }

        internal static void NavigateToURL(string URL)
        {
            if (string.IsNullOrWhiteSpace(URL)) { return; }
            Process.Start(new ProcessStartInfo(URL) { UseShellExecute = true });
        }
    }
}

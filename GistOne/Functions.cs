using GistOne.Forms;
using System.Text.Json;

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
    }
}

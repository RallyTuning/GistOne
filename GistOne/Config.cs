using System.Text.Json.Serialization;

namespace GistOne
{
    public class Config
    {
        [JsonPropertyName("Token")]
        public string Token { get; set; } = string.Empty;

        [JsonPropertyName("Username")]
        public string Username { get; set; } = string.Empty;

        [JsonPropertyName("committed_at")]
        public DateTime Committed_At { get; set; }

        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;
    }
}

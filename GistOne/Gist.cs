using System.Text.Json.Serialization;

namespace GistOne
{
    /// <summary>A class for a complete Gist</summary>
    public class Gist
    {
        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("forks_url")]
        public string Forks_URL { get; set; } = string.Empty;

        [JsonPropertyName("commits_url")]
        public string Commits_URL { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("node_id")]
        public string Node_ID { get; set; } = string.Empty;

        [JsonPropertyName("git_pull_url")]
        public string Git_Pull_URL { get; set; } = string.Empty;

        [JsonPropertyName("git_push_url")]
        public string Git_Push_URL { get; set; } = string.Empty;

        [JsonPropertyName("html_url")]
        public string HTML_URL { get; set; } = string.Empty;

        /// <summary>A list of files inside the Gist</summary>
        [JsonPropertyName("files")]
        public Dictionary<string, FileDetails> Files { get; set; } = new();

        /// <summary>Public or private Gist (olny for logged user)</summary>
        [JsonPropertyName("public")]
        public bool Public { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime Updated_At { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>Total comments</summary>
        [JsonPropertyName("comments")]
        public int Comments { get; set; }

#warning probabilmente per le gist pubbliche (testare):
        [JsonPropertyName("user")]
        public User User { get; set; } = new();

        [JsonPropertyName("comments_url")]
        public string Comments_URL { get; set; } = string.Empty;

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; } = new();

        [JsonPropertyName("fork_of")]
        public Fork_Of Fork_Of { get; set; } = new();

        [JsonPropertyName("forks")]
        public List<Forks> Forks { get; set; } = new();

        [JsonPropertyName("history")]
        public List<History> History { get; set; } = new();

        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }
    }

    /// <summary>Details of the file</summary>
    public class FileDetails
    {
        [JsonPropertyName("filename")]
        public string Filename { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("language")]
        public string Language { get; set; } = string.Empty;

        [JsonPropertyName("raw_url")]
        public string Raw_URL { get; set; } = string.Empty;

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }

        /// <summary>Content of the file</summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>Content of the file</summary>
        public FileDetails(string Content)
        {
            this.Content = Content;
        }
    }

    /// <summary>Different from Owner because this is for public users</summary>
    public class User
    {
        [JsonPropertyName("login")]
        public string Login { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("node_id")]
        public string Node_ID { get; set; } = string.Empty;

        [JsonPropertyName("avatar_url")]
        public string Avatar_URL { get; set; } = string.Empty;

        [JsonPropertyName("gravatar_id")]
        public string Gravatar_ID { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("html_url")]
        public string HTML_URL { get; set; } = string.Empty;

        [JsonPropertyName("followers_url")]
        public string Followers_URL { get; set; } = string.Empty;

        [JsonPropertyName("following_url")]
        public string Following_URL { get; set; } = string.Empty;

        [JsonPropertyName("gists_url")]
        public string Gists_URL { get; set; } = string.Empty;

        [JsonPropertyName("starred_url")]
        public string Starred_URL { get; set; } = string.Empty;

        [JsonPropertyName("subscriptions_url")]
        public string Subscriptions_URL { get; set; } = string.Empty;

        [JsonPropertyName("organizations_url")]
        public string Organizations_URL { get; set; } = string.Empty;

        [JsonPropertyName("repos_url")]
        public string Repos_URL { get; set; } = string.Empty;

        [JsonPropertyName("events_url")]
        public string Events_URL { get; set; } = string.Empty;

        [JsonPropertyName("received_events_url")]
        public string Received_Events_URL { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("site_admin")]
        public bool Site_Admin { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("company")]
        public string Company { get; set; } = string.Empty;

        [JsonPropertyName("blog")]
        public string Blog { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("hireable")]
        public object? Hireable { get; set; } // It's a boolean, butgive an error when "false".

        [JsonPropertyName("bio")]
        public string Bio { get; set; } = string.Empty;

        [JsonPropertyName("twitter_username")]
        public string Twitter_Username { get; set; } = string.Empty;

        [JsonPropertyName("public_repos")]
        public int Public_Repos { get; set; }

        [JsonPropertyName("public_gists")]
        public int Public_Gists { get; set; }

        [JsonPropertyName("followers")]
        public int Followers { get; set; }

        [JsonPropertyName("following")]
        public int Following { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime Updated_At { get; set; }
    }

    /// <summary>Similar to User class, but compact</summary>
    public class Owner
    {
        [JsonPropertyName("login")]
        public string Login { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("node_id")]
        public string Node_ID { get; set; } = string.Empty;

        [JsonPropertyName("avatar_url")]
        public string Avatar_URL { get; set; } = string.Empty;

        [JsonPropertyName("gravatar_id")]
        public string Gravatar_ID { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("html_url")]
        public string HTML_URL { get; set; } = string.Empty;

        [JsonPropertyName("followers_url")]
        public string Followers_URL { get; set; } = string.Empty;

        [JsonPropertyName("following_url")]
        public string Following_URL { get; set; } = string.Empty;

        [JsonPropertyName("gists_url")]
        public string Gists_URL { get; set; } = string.Empty;

        [JsonPropertyName("starred_url")]
        public string Starred_URL { get; set; } = string.Empty;

        [JsonPropertyName("subscriptions_url")]
        public string Subscriptions_URL { get; set; } = string.Empty;

        [JsonPropertyName("organizations_url")]
        public string Organizations_URL { get; set; } = string.Empty;

        [JsonPropertyName("repos_url")]
        public string Repos_URL { get; set; } = string.Empty;

        [JsonPropertyName("events_url")]
        public string Events_URL { get; set; } = string.Empty;

        [JsonPropertyName("received_events_url")]
        public string Received_Events_URL { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("site_admin")]
        public bool Site_Admin { get; set; }
    }

    /// <summary>Gist forked from</summary>
    public class Fork_Of
    {
        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("forks_url")]
        public string Forks_URL { get; set; } = string.Empty;

        [JsonPropertyName("commits_url")]
        public string Commits_URL { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("node_id")]
        public string Node_ID { get; set; } = string.Empty;

        [JsonPropertyName("git_pull_url")]
        public string Git_Pull_URL { get; set; } = string.Empty;

        [JsonPropertyName("git_push_url")]
        public string Git_Push_URL { get; set; } = string.Empty;

        [JsonPropertyName("html_url")]
        public string HTML_URL { get; set; } = string.Empty;

        /// <summary>A list of files inside the Gist</summary>
        [JsonPropertyName("files")]
        public Dictionary<string, FileDetails> Files { get; set; } = new();

        [JsonPropertyName("public")]
        public bool Public { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime Updated_At { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; } = new();

        [JsonPropertyName("comments_url")]
        public string Comments_URL { get; set; } = string.Empty;

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; } = new();
    }

    /// <summary>Forks of the Gist</summary>
    public class Forks
    {
        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("user")]
        public User User { get; set; } = new();

        [JsonPropertyName("id")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("created_at")]
        public DateTime Created_At { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime Updated_At { get; set; }
    }

    /// <summary>History of Gist changes</summary>
    public class History
    {
        [JsonPropertyName("user")]
        public User User { get; set; } = new();

        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        [JsonPropertyName("committed_at")]
        public DateTime Committed_At { get; set; }

        [JsonPropertyName("change_status")]
        public Change_Status Change_Status { get; set; } = new();

        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;
    }

    /// <summary>Status changes of History class</summary>
    public class Change_Status
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("additions")]
        public int Additions { get; set; }

        [JsonPropertyName("deletions")]
        public int Deletions { get; set; }
    }
}

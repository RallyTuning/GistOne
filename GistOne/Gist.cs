using System.Text.Json.Serialization;

namespace GistOne
{

    public class Gist
    {
        //    [JsonPropertyName("url")]
        //    public string Url { get; set; } = string.Empty;

        //    [JsonPropertyName("forks_url")]
        //    public string ForksUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("commits_url")]
        //    public string CommitsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("id")]
        //    public string Id { get; set; } = string.Empty;

        //    [JsonPropertyName("node_id")]
        //    public string NodeId { get; set; } = string.Empty;

        //    [JsonPropertyName("git_pull_url")]
        //    public string GitPullUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("git_push_url")]
        //    public string GitPushUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("html_url")]
        //    public string HtmlUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("files")]
        //    public List<Files> Files { get; set; } = new();

        //    [JsonPropertyName("public")]
        //    public bool Public { get; set; }

        //    [JsonPropertyName("created_at")]
        //    public DateTime CreatedAt { get; set; }

        //    [JsonPropertyName("updated_at")]
        //    public DateTime UpdatedAt { get; set; }

        //    [JsonPropertyName("description")]
        //    public string Description { get; set; } = string.Empty;

        //    [JsonPropertyName("comments")]
        //    public int Comments { get; set; }

        //    [JsonPropertyName("user")]
        //    public User User { get; set; } = new();

        //    [JsonPropertyName("comments_url")]
        //    public string CommentsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("owner")]
        //    public Owner Owner { get; set; } = new();

        //    [JsonPropertyName("forks")]
        //    public List<Forks> Forks { get; set; } = new();

        //    [JsonPropertyName("history")]
        //    public List<History> History { get; set; } = new();

        //    [JsonPropertyName("truncated")]
        //    public bool Truncated { get; set; }
        //}


        //public class User
        //{
        //    [JsonPropertyName("login")]
        //    public string Login { get; set; } = string.Empty;

        //    [JsonPropertyName("id")]
        //    public int Id { get; set; }

        //    [JsonPropertyName("node_id")]
        //    public string NodeId { get; set; } = string.Empty;

        //    [JsonPropertyName("avatar_url")]
        //    public string AvatarUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("gravatar_id")]
        //    public string GravatarId { get; set; } = string.Empty;

        //    [JsonPropertyName("url")]
        //    public string Url { get; set; } = string.Empty;

        //    [JsonPropertyName("html_url")]
        //    public string HtmlUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("followers_url")]
        //    public string FollowersUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("following_url")]
        //    public string FollowingUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("gists_url")]
        //    public string GistsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("starred_url")]
        //    public string StarredUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("subscriptions_url")]
        //    public string SubscriptionsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("organizations_url")]
        //    public string OrganizationsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("repos_url")]
        //    public string ReposUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("events_url")]
        //    public string EventsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("received_events_url")]
        //    public string ReceivedEventsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("type")]
        //    public string Type { get; set; } = string.Empty;

        //    [JsonPropertyName("site_admin")]
        //    public bool SiteAdmin { get; set; }
        //}

        //public class Owner
        //{
        //    [JsonPropertyName("login")]
        //    public string Login { get; set; } = string.Empty;

        //    [JsonPropertyName("id")]
        //    public int Id { get; set; }

        //    [JsonPropertyName("node_id")]
        //    public string NodeId { get; set; } = string.Empty;

        //    [JsonPropertyName("avatar_url")]
        //    public string AvatarUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("gravatar_id")]
        //    public string GravatarId { get; set; } = string.Empty;

        //    [JsonPropertyName("url")]
        //    public string Url { get; set; } = string.Empty;

        //    [JsonPropertyName("html_url")]
        //    public string HtmlUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("followers_url")]
        //    public string FollowersUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("following_url")]
        //    public string FollowingUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("gists_url")]
        //    public string GistsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("starred_url")]
        //    public string StarredUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("subscriptions_url")]
        //    public string SubscriptionsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("organizations_url")]
        //    public string OrganizationsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("repos_url")]
        //    public string ReposUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("events_url")]
        //    public string EventsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("received_events_url")]
        //    public string ReceivedEventsUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("type")]
        //    public string Type { get; set; } = string.Empty;

        //    [JsonPropertyName("site_admin")]
        //    public bool SiteAdmin { get; set; }
        //}

        //public class Files
        //{
        //    [JsonPropertyName("filename")]
        //    public string Filename { get; set; } = string.Empty;

        //    [JsonPropertyName("type")]
        //    public string Type { get; set; } = string.Empty;

        //    [JsonPropertyName("language")]
        //    public string Language { get; set; } = string.Empty;

        //    [JsonPropertyName("raw_url")]
        //    public string RawUrl { get; set; } = string.Empty;

        //    [JsonPropertyName("size")]
        //    public int Size { get; set; }

        //    [JsonPropertyName("truncated")]
        //    public bool Truncated { get; set; }

        //    [JsonPropertyName("content")]
        //    public string Content { get; set; } = string.Empty;
        //}

        //public class History
        //{
        //    [JsonPropertyName("user")]
        //    public User User { get; set; } = new();

        //    [JsonPropertyName("version")]
        //    public string Version { get; set; } = string.Empty;

        //    [JsonPropertyName("committed_at")]
        //    public DateTime CommittedAt { get; set; }

        //    [JsonPropertyName("change_status")]
        //    public ChangeStatus ChangeStatus { get; set; } = new();

        //    [JsonPropertyName("url")]
        //    public string Url { get; set; } = string.Empty;
        //}

        //public class ChangeStatus
        //{
        //    [JsonPropertyName("total")]
        //    public int Total { get; set; }

        //    [JsonPropertyName("additions")]
        //    public int Additions { get; set; }

        //    [JsonPropertyName("deletions")]
        //    public int Deletions { get; set; }
        //}

        //public class Forks
        //{

        //}


        public class Rootobject
        {
            public string url { get; set; }
            public string forks_url { get; set; }
            public string commits_url { get; set; }
            public string id { get; set; }
            public string node_id { get; set; }
            public string git_pull_url { get; set; }
            public string git_push_url { get; set; }
            public string html_url { get; set; }
            /// <summary>A list of files inside your Gist</summary>
            [JsonPropertyName("files")]
            public Dictionary<string, FileContent> FilesList { get; set; } = new();

            /// <summary>A list of files inside your Gist</summary>
            [JsonPropertyName("public")]
            public bool Public { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string description { get; set; }

            /// <summary>A list of files inside your Gist</summary>
            [JsonPropertyName("comments")]
            public int Comments { get; set; }
            public object user { get; set; }
            public string comments_url { get; set; }
            public Owner owner { get; set; }
            public object[] forks { get; set; }
            public History[] history { get; set; }
            public bool truncated { get; set; }
        }



        /// <summary>A class for the content of your file</summary>
        public class FileContent
        {
            /// <summary>Content of your file</summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;

            /// <summary>Content of your file</summary>
            public FileContent(string Content)
            {
                this.Content = Content;
            }
        }

        public class ZFileTxt
        {
            public string filename { get; set; }
            public string type { get; set; }
            public string language { get; set; }
            public string raw_url { get; set; }
            public int size { get; set; }
            public bool truncated { get; set; }
            public string content { get; set; }
        }

        public class NewFileCs
        {
            public string filename { get; set; }
            public string type { get; set; }
            public string language { get; set; }
            public string raw_url { get; set; }
            public int size { get; set; }
            public bool truncated { get; set; }
            public string content { get; set; }
        }

        public class Owner
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class History
        {
            public User user { get; set; }
            public string version { get; set; }
            public DateTime committed_at { get; set; }
            public Change_Status change_status { get; set; }
            public string url { get; set; }
        }

        public class User
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class Change_Status
        {
            public int total { get; set; }
            public int additions { get; set; }
            public int deletions { get; set; }
        }



    }
}
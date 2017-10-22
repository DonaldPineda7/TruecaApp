using Newtonsoft.Json;

namespace TruecaApp.Classes
{
    public class DataFacebook
    {
        [JsonProperty(PropertyName = "is_silhouette")]
        public bool IsSilhouette
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "url")]
        public string Url
        {
            get;
            set;
        }
    }

    public class FacebookResponse
    {
        [JsonProperty(PropertyName = "cover")]
        public Cover Cover
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "email")]
        public string Email
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "birthday")]
        public string BirthDate
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "picture")]
        public Picture Picture
        {
            get;
            set;
        }
    }

    public class Picture
    {
        [JsonProperty(PropertyName = "data")]
        public DataFacebook Data
        {
            get;
            set;
        }
    }

    public class Cover
    {
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "offset_y")]
        public int OffsetY
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "source")]
        public string Source
        {
            get;
            set;
        }
    }

}

using System.Text.Json.Serialization;

namespace LaMiaPizzeriaCategoriaETagELogin.Models
{
    public class Tag
    {

        public int Id { get; set; }
        public string Title { get; set; }


        [JsonIgnore]
        public List<Pizza> Pizza { get; set; }


        public Tag() { }

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_DOTNET.DTO
{
    public class ItemEditDto
    {
        [JsonPropertyName("name"), JsonRequired, JsonPropertyOrder(1)]
        public string Name { get; set; }

        [JsonPropertyName("description"), JsonRequired, JsonPropertyOrder(2)]
        public string Description { get; set; }

    }
}

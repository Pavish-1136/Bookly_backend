using System.Text.Json.Serialization;

namespace Bookly_backend.Models.DTOs
{
    public class AttendeeDto
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace JoyGAPI.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
        [JsonIgnore]
        public string Message { get; set; }

    }
}

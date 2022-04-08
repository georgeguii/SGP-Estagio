using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;
using SpgEstagioTeste.Models.Enums;

namespace SpgEstagioTeste.Models.Entities.Users
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("CreateAd")]
        public DateTime CreateAd { get; set; } = DateTime.Now;

        [BsonElement("Role")]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public Role Role { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

    }
}

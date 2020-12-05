using MongoDB.Bson;

namespace AspNetCoreMongoDb.Models
{
    public class Car
    {
        public ObjectId Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
    }
}

using AspNetCoreMongoDb.Models;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreMongoDb.Repositories
{
    public interface ICarRepository
    {
        // Create
        Task<ObjectId> Create(Car car);

        // Read
        Task<Car> Get(ObjectId objectId);
        Task<IEnumerable<Car>> Get();
        Task<IEnumerable<Car>> GetByMake(string make);

        // Update
        Task<bool> Update(ObjectId objectId, Car car);

        // Delete
        Task<bool> Delete(ObjectId objectId);
    }
}

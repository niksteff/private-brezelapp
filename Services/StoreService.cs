using System.Collections.Generic;
using System.Threading.Tasks;
using Brezelapp.Models;
using Brezelapp.Services.Contracts;

namespace Brezelapp.Services
{
    internal class StoreService : IStoreService
    {
        public async Task<Store> CreateStore(Store store)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteStoreById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Store> GetStoreById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Store>> GetStores(int offset, int limit)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Store>> GetStoresByLocation(double lat, double lon, int range)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Store>> GetStoresByRating(int minRating, int maxRating)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> UpdateStore(int id, Store store)
        {
            throw new System.NotImplementedException();
        }
    }
}
using Microsoft.Azure.Cosmos;
using Models;
using Models.Dtos;

namespace Services
{
    public class Service : IService
    {
        private Container _container;   
        public Service( CosmosClient cosmos,string databaseName, string containerName)
        {
            _container = cosmos.GetContainer(databaseName, containerName);  
        }
        public async Task AddAsync(ProgramDto item)
        {
            await _container.CreateItemAsync(item, new PartitionKey(item.ProgramId));
        }

        public async Task<ProgramDto> GetAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<ProgramDto>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException)
            {
                return null;
            }
        }

        public async Task UpdateAsync(string id, ProgramDto item)
        {
            await _container.UpsertItemAsync(item, new PartitionKey(id));
        }
    }
}
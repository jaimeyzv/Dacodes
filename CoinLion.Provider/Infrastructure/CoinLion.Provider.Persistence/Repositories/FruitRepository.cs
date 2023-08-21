using CoinLion.Provider.Application.Interfaces.Persistence;
using CoinLion.Provider.Application.UseCases.Queries;

namespace CoinLion.Provider.Persistence.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        public async Task<IEnumerable<FruitModel>> GetFruitsAsync()
        {
            var fruits = new List<FruitModel>()
            {
                new FruitModel { FruitId = 1, Name = "Apple" },
                new FruitModel { FruitId = 2, Name = "Orange" },
                new FruitModel { FruitId = 3, Name = "Banana" }
            };

            return fruits;
        }
    }
}

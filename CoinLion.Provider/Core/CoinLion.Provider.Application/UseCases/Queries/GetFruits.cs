using CoinLion.Provider.Application.Interfaces.Persistence;

namespace CoinLion.Provider.Application.UseCases.Queries
{
    public class GetFruits : IGetFruits
    {
        private readonly IFruitRepository FruitRepository;

        public GetFruits(IFruitRepository fruitRepository)
        {
            this.FruitRepository = fruitRepository;
        }

        public async Task<IEnumerable<FruitModel>> GetFruitsAsync()
        {
            return await FruitRepository.GetFruitsAsync();
        }
    }
}

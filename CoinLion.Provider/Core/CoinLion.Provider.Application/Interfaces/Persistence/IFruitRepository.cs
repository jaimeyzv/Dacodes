using CoinLion.Provider.Application.UseCases.Queries;

namespace CoinLion.Provider.Application.Interfaces.Persistence
{
    public interface IFruitRepository
    {
        Task<IEnumerable<FruitModel>> GetFruitsAsync();
    }
}

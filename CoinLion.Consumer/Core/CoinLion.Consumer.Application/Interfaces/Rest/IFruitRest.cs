using CoinLion.Consumer.Application.UseCases.Queries;

namespace CoinLion.Consumer.Application.Interfaces.Rest
{
    public interface IFruitRest
    {
        Task<IEnumerable<FruitModel>> GetFruits();
    }
}

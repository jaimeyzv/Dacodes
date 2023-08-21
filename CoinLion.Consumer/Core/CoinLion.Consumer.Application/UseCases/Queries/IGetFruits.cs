namespace CoinLion.Consumer.Application.UseCases.Queries
{
    public interface IGetFruits
    {
        Task<IEnumerable<FruitModel>> GetAllFruits();
    }
}

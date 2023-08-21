namespace CoinLion.Provider.Application.UseCases.Queries
{
    public interface IGetFruits
    {
        Task<IEnumerable<FruitModel>> GetFruitsAsync(); 
    }
}

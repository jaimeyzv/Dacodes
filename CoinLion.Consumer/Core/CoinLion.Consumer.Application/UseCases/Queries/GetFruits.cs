using CoinLion.Consumer.Application.Interfaces.Rest;

namespace CoinLion.Consumer.Application.UseCases.Queries
{
    public class GetFruits : IGetFruits
    {
        private readonly IFruitRest FruitRest;

        public GetFruits(IFruitRest fruitRest)
        {
            this.FruitRest = fruitRest;
        }

        public async Task<IEnumerable<FruitModel>> GetAllFruits()
        {
            return await this.FruitRest.GetFruits();
        }
    }
}

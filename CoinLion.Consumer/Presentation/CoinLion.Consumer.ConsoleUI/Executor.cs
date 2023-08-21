using CoinLion.Consumer.Application.UseCases.Queries;

namespace CoinLion.Consumer.ConsoleUI
{
    public class Executor
    {
        private readonly IGetFruits GetFruitQuery;

        public Executor(IGetFruits getFruitQuery)
        {
            this.GetFruitQuery = getFruitQuery;
        }

        public async Task Execute()
        {
            var fruits = await this.GetFruitQuery.GetAllFruits();

            // Log
            Console.WriteLine(fruits);
        }
    }
}

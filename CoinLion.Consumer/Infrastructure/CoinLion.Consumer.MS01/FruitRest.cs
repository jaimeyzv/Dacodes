using CoinLion.Consumer.Application.Interfaces.Rest;
using CoinLion.Consumer.Application.UseCases.Queries;
using RestSharp;
using System.Text.Json;

namespace CoinLion.Consumer.MS01
{
    public class FruitRest : IFruitRest
    {
        private readonly RestClient RestClient;

        public FruitRest()
        {
            this.RestClient = new RestClient("https://localhost:44388/api/");
        }

        public async Task<IEnumerable<FruitModel>> GetFruits()
        {
            var request = new RestRequest("fruit");
            try
            {
                var response = await this.RestClient.ExecuteGetAsync(request);

                if (!response.IsSuccessful)
                {
                    //Logic for handling unsuccessful response
                }

                var fruitList = JsonSerializer.Deserialize<IEnumerable<FruitModel>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return fruitList;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return null;
        }
    }
}
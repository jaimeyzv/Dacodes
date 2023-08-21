using CoinLion.Provider.Application.UseCases.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CoinLion.Provider.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly IGetFruits GetFruitsQuery;

        public FruitController(IGetFruits getFruitsQuery)
        {
            this.GetFruitsQuery = getFruitsQuery;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fruits = await this.GetFruitsQuery.GetFruitsAsync();
            var fruitNames = fruits.Select(x => x.Name).ToArray();

            return Ok(fruitNames);
        }
    }
}

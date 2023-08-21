// See https://aka.ms/new-console-template for more information

using CoinLion.Consumer.Application.Interfaces.Rest;
using CoinLion.Consumer.Application.UseCases.Queries;
using CoinLion.Consumer.ConsoleUI;
using CoinLion.Consumer.MS01;
using Microsoft.Extensions.DependencyInjection;

//var serviceProvider = new ServiceCollection()
//            .AddScoped<IFruitRest, FruitRest>()
//            .AddScoped<IGetFruits, GetFruits>()
//            .BuildServiceProvider()
//            .GetService<Executor>().Execute();

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        services
            .AddSingleton<Executor, Executor>()
            .BuildServiceProvider()
            .GetService<Executor>()
            .Execute();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IFruitRest, FruitRest>();
        services.AddScoped<IGetFruits, GetFruits>();
    }
}
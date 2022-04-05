using Microsoft.EntityFrameworkCore;
using StockData.Worker;
using StockData.Worker.Context;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();

        services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer("Server=.\\SQLEXPRESS;Database=StockDb1;Trusted_Connection=True;MultipleActiveResultSets=true"));


    })
    .Build();

await host.RunAsync();

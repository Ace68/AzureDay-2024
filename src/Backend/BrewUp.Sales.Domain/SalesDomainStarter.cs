using Microsoft.Extensions.Hosting;

namespace BrewUp.Sales.Domain;

public class SalesDomainStarter(CreateSalesOrderConsumer consumer) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await consumer.StartAsync(cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
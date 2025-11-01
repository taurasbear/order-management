namespace OrderManagement.Infrastructure.Interfaces;

public interface IDevelopmentSeeder
{
    public Task SeedAsync(CancellationToken cancellationToken);
}
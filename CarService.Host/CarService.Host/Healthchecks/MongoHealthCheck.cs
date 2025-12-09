using CarService.Models.Configurations;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CarService.Host.Healthchecks
{
    public class MongoHealthCheck
    {
        private readonly IOptionsMonitor<MongoDbConfiguration> _mongoDbConfiguration;

        public MongoHealthCheck(IOptionsMonitor<MongoDbConfiguration> mongoDbConfiguration)
        {
            _mongoDbConfiguration = mongoDbConfiguration;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = false;

            try
            {
                var client = new MongoClient(_mongoDbConfiguration.CurrentValue.ConnectionString);
                var database = client.GetDatabase(_mongoDbConfiguration.CurrentValue.DatabaseName);

                database.RunCommandAsync((Command<dynamic>)"{ping:1}").Wait(cancellationToken);
            }
            catch (Exception)
            {
                isHealthy = false;
            }

            // ...

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("MongoDB is healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "MongoDB is unhealthy."));
        }
    }
}

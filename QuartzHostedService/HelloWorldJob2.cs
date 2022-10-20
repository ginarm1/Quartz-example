using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzHostedServices
{
    public class HelloWorldJob2 : IJob
    {
        private readonly ILogger<HelloWorldJob2> _logger;

        public HelloWorldJob2(ILogger<HelloWorldJob2> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Hello world! V2");
            return Task.CompletedTask;
        }
    }
}

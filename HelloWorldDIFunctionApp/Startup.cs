using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(HelloWorldDIFunctionApp.Startup))]

namespace HelloWorldDIFunctionApp
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging((loggingBuilder) =>
            {
                loggingBuilder.SetMinimumLevel(LogLevel.Trace);
            });

            //Registering MyDependency as a service so that it can be dependency-injected into a client
            builder.Services.AddScoped<IMyDependency, MyDependency>();

        }
    }
}

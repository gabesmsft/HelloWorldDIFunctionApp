﻿using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

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
            //Registering MyDependency as a service so that it can be dependency-injected into a client
            builder.Services.AddTransient<IMyDependency, MyDependency>();
        }
    }
}

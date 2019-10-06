using Microsoft.Extensions.Logging;

namespace HelloWorldDIFunctionApp
{
    public interface IMyDependency
    {
        string TestDependencyInjection();
    }
}

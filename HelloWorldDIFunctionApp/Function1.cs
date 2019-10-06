using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HelloWorldDIFunctionApp
{
	// This class will serve as the Dependency Injection client for this demo.
    public class Function1
    {
        private readonly IMyDependency _myDependency;

        public Function1(IMyDependency myDependency)
        {
            // notice that when we are creating the MyDependency object, we are not explicitly instantiating it. The Functions Dependency Injection framework is calling the constructor behind-the-scenes.
            _myDependency = myDependency;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            // We're going to call the MyDependency instance's TestDependency method.
            // Logging the return value of this method will verify whether dependency injection worked.
            // If MyDependency is successfully injected into the client code without the client code having to explicitly instantiate MyDependency,
            // then TestString will be initialized and will equal "mydependency is injected",
            // and thus the log statement below will print "mydependency is injected"

            log.LogInformation(_myDependency.TestDependencyInjection());

            return (ActionResult)new OkObjectResult("Well, it didn't return an HTTP error at least");
        }
    }
}

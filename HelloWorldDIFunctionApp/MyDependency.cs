using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HelloWorldDIFunctionApp
{
    public class MyDependency : IMyDependency
    {
        private string TestString;

        public MyDependency()
        {
            TestString = "Dependency injection worked";
        }

        // We're going to use this method to verify that dependency injection worked. If MyDependency is successfully injected into the client code without the client code having to explicitly instantiate MyDependency, then TestString will be initialized and the Function will log the value of TestString
        public String TestDependencyInjection()
        {
            return TestString;
        }
    }
}

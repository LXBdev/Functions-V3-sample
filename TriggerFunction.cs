using System;
using Functions_V3_sample;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class TriggerFunction
    {
        private readonly MyService myService;

        public TriggerFunction(MyService myService)
        {
            this.myService = myService ?? throw new ArgumentNullException(nameof(myService));
        }

        [FunctionName("TriggerFunction")]
        public void Run([TimerTrigger("0/15 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            myService.Foo();
        }
    }
}

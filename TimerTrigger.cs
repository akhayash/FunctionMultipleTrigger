using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionMultipleTrigger
{
    public static class TimerTrigger
    {
        [FunctionName("TimerTrigger")]
        public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            var greetingMessage = GreetingService.Say("Timer Trigger");
            log.LogInformation($"[TimerTrigger]: {greetingMessage}");
        }
    }
}

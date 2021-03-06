using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionMultipleTrigger
{
    public static class CosmosDBTrigger
    {
        [FunctionName("CosmosDBTrigger")]
        public static void Run([CosmosDBTrigger(
            databaseName: "%CosmosDB:Database%",
            collectionName: "%CosmosDB:Container%",
            ConnectionStringSetting = "CosmosDB:ConnectionString",
            LeaseCollectionName = "leases",  CreateLeaseCollectionIfNotExists =true)]IReadOnlyList<Document> input, ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                log.LogInformation("First document Id " + input[0].Id);
            }
        }
    }
}

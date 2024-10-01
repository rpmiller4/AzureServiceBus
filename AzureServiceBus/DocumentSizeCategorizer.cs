using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureServiceBus
{
    public class DocumentSizeCategorizer
    {
        [FunctionName("DocumentSizeCategorizer")]
        public void Run([ServiceBusTrigger("documentsQueue", Connection = "ServiceBusConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");

            log.LogInformation($"Received document: {myQueueItem}");

            string category = CategorizeDocumentByLength(myQueueItem);

            log.LogInformation($"Document categorized as: {category}");
        }

        private static string CategorizeDocumentByLength(string document)
        {
            if (document.Length < 100)
                return "Small";
            else if (document.Length < 1000)
                return "Medium";
            else
                return "Large";
        }
    }
}

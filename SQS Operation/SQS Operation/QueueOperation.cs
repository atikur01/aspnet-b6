using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS_Operation
{
    public class QueueOperation
    {
        private static IAmazonSQS sqsClient;

        public QueueOperation()
        {
            sqsClient = new AmazonSQSClient(RegionEndpoint.USEast1);
        }

        public async Task SendMessage(string qUrl, string messageBody)
        {  
            SendMessageResponse responseSendMsg =
              await sqsClient.SendMessageAsync(qUrl, messageBody);
            Console.WriteLine($"Message added to queue\n  {qUrl}");
            Console.WriteLine($"HttpStatusCode: {responseSendMsg.HttpStatusCode}");
        }

        public async Task<ReceiveMessageResponse> GetMessage(string qUrl)
        {
            var x = await sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
            {
                QueueUrl = qUrl,
                MaxNumberOfMessages = 10,
                WaitTimeSeconds = 20
            });

            //Console.WriteLine($"Count : {x.Messages.Count}");
            foreach (var item in x.Messages)
            {

                Console.WriteLine(item.Body);
            }
            return x;   
        }

        public async Task<ReceiveMessageResponse> DeleteReadMessages(string queueUrl, ReceiveMessageResponse receiveMessageResponse)
        {
            for (int i = 0; i < receiveMessageResponse.Messages.Count; i++)
            {
                var deleteMessageRequest = new DeleteMessageRequest
                {
                    QueueUrl = queueUrl,
                    ReceiptHandle = receiveMessageResponse.Messages[i].ReceiptHandle,
                };

                  await sqsClient.DeleteMessageAsync(deleteMessageRequest);
            }
           
            return receiveMessageResponse;
        }

    }
}

namespace SQS_Operation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            QueueOperation queueOperation = new QueueOperation();

            var url = "https://sqs.us-east-1.amazonaws.com/667432834983/AtiksQueue";
            var body = "hello world";
      
            await queueOperation.SendMessage(url,body);

            var receiveMessageResponse = await queueOperation.GetMessage(url);
   
            await queueOperation.DeleteReadMessages(url, receiveMessageResponse);
           
        }
    }
}
namespace DynamoDb_Operation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Book myBook = new Book
            {
                Id = 24,
                Title = "object persistence-AWS SDK for.NET SDK-Book 1001",
                ISBN = "111-1111111001",    
            };

            DynamoDbOperation dbOperation = new DynamoDbOperation();

            //await dbOperation.AddRow(myBook);
            //await dbOperation.GetRow(1, 10);

            //dbOperation.DeleteRowAsync(24);

        }
    }
}
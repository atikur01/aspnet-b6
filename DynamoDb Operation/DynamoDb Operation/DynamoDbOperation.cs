using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoDb_Operation
{
    
    public class DynamoDbOperation
    {
        private static AmazonDynamoDBClient _client;
        private DynamoDBContext _context;
        public DynamoDbOperation()
        {
            _client = new AmazonDynamoDBClient();
            _context = new DynamoDBContext(_client);

        }

        public async Task AddRow(Book book)
        {
            // Save the book.
            await _context.SaveAsync(book);
        }

        public async Task<List<Book>> GetRow(int startId, int endId)
        {
            List < Book > list = new List<Book>();  
            for (int i = startId; i <= endId; i++)
            {
                var book = await _context.LoadAsync<Book>(i);
                list.Add(book);
                Book.PrintBook(book);
            }
            return list;
        }

        public async void DeleteRowAsync(int bookId)
        {
           await _context.DeleteAsync<Book>(bookId);
        }
       


    }
}

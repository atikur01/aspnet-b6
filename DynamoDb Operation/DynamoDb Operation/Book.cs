using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoDb_Operation
{
    [DynamoDBTable("atik394009")]
    public class Book
    {
        [DynamoDBHashKey] //Partition key
        public int Id
        {
            get; set;
        }
        [DynamoDBProperty]
        public string Title
        {
            get; set;
        }
        [DynamoDBProperty]
        public string ISBN
        {
            get; set;
        }
        
        public static void PrintBook(Book obj)
        {
            Console.WriteLine($"Id: {obj.Id} ,Title: {obj.Title} ,ISBN:{obj.ISBN}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace assignment4
{

    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { id = 01 , name = "Atik", age = 22 };
            Student student2 = new Student() { id = 02, name = "Rakib", age = 23 };

            MyORM<Student> myORM = new MyORM<Student>();
            // myORM.Insert(student1);
            // myORM.Update(student2);
            // myORM.Delete(student1);  
            // myORM.Delete(1);
            //PrintList(myORM.GetById(1) );
            //PrintList( myORM.GetAll() );   
    
        }

        public static void PrintList(List<IDictionary<string, object>> obj)
        {
            foreach (var items in obj)
            {
                 foreach(var item in items)
                {
                    Console.WriteLine($"{item.Key} = {item.Value}");
                }
                Console.WriteLine();
            }   
        }

        public static Dictionary<string,object> GetKeyValues(object item)
        {
            Dictionary < string,object> obj = new Dictionary<string,object>();
            Type type = item.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                obj.Add(property.Name, property.GetValue(item));
            }

            return obj; 
        }
    }
}

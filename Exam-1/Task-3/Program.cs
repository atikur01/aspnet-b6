using System.Linq;
using Task_3;

List<Customer> customers = new List<Customer>();
customers.Add(new Customer() { Name = "A", Id = 1 });
customers.Add(new Customer() { Name = "B", Id = 2 }); 
customers.Add(new Customer() { Name = "C", Id = 3 });

List<Order> orders = new List<Order>();
orders.Add(new Order() { CustomerId = 1, ProductName = "A", Quantity = 1 });
orders.Add(new Order() { CustomerId = 2, ProductName = "B", Quantity = 2 });
orders.Add(new Order() { CustomerId = 3, ProductName = "C", Quantity = 3 });

var x = from customer in customers
        where customer.Id  == 1
        select customer;

var y = from order in orders
        where order.CustomerId == 1
        select order;






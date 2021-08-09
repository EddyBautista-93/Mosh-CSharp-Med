using System;


namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
             var customer = new Customer(1, "Eddy");
             Console.WriteLine(customer.Id);
             Console.WriteLine(customer.Name);
             
        }
    }
}

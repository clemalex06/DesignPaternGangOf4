using System;
namespace Command
{
    public class CommandMain
    {
        /*
         * Command's Concept :
         * Turns a request into a stand-alone object that contains all information about the request. 
         * This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, 
         * and support undoable operations.
         */
        public static void Main()
        {
            var today = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Utc);
            var car1 = new Car("A01", today.AddDays(-1), 1000);
            var car2 = new Car("A02", today.AddDays(-6), 2000);
            var car3 = new Car("A03", today.AddDays(-3), 3000);

            var catalog = new Catalog();
            catalog.Add(car1);
            catalog.Add(car2);
            catalog.Add(car3);

            Console.WriteLine("Display Initial Catalog");
            catalog.Display();
            Console.WriteLine();

            var discountedCommand1 = new DiscountedCommand(today, 5, 0.1, "First");
            discountedCommand1.Display();
            catalog.LaunchDiscountedCommand(discountedCommand1);
            Console.WriteLine("Display Catalog After First Discounted Command");
            catalog.Display();
            Console.WriteLine();
            var discountedCommand2 = new DiscountedCommand(today, 2, 0.5, "Second");
            discountedCommand2.Display();
            catalog.LaunchDiscountedCommand(discountedCommand2);

            Console.WriteLine("Display Catalog After Second Discounted Command");
            catalog.Display();
            Console.WriteLine();
            catalog.CancelDiscountedCommand(1);
            Console.WriteLine("Display Catalog After First Discounted Command Cancellation");
            catalog.Display();
            Console.WriteLine();
            catalog.RestoreDiscountedCommand(1);
            Console.WriteLine("Display Catalog After First Discounted Command Restoration");
            catalog.Display();
            Console.WriteLine();



        }
    }
}

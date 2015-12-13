namespace ConsoleVerification
{
   using System;
   using ForgetTheMilk.Controllers;

   class Program
   {
      static void Main(string[] args)
      {
         var input = "Pick up groceries";
         Console.WriteLine("Scenario: " + input);
         var task = new Task(input);
         var descShouldBe = input;
         DateTime? dueDateShouldBe = null;
         if (descShouldBe == task.Description &&
            dueDateShouldBe == task.DueDate)
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test passed");
            Console.ResetColor();
         }
         else
         {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Description: " + task.Description + " should be " + descShouldBe);
            Console.WriteLine("Due date: " + task.DueDate + " should be " + dueDateShouldBe);
            Console.WriteLine("Test failed!");
            Console.ResetColor();
         }


         input = "Pick up groceries may 5";
         Console.WriteLine("Scenario: " + input);
         task = new Task(input);
         dueDateShouldBe = new DateTime(DateTime.Today.Year, 5, 5);
         if (dueDateShouldBe == task.DueDate)
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test passed");
            Console.ResetColor();
         }
         else
         {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Due date: " + task.DueDate + " should be " + dueDateShouldBe);
            Console.WriteLine("Test failed!");
            Console.ResetColor();
         }

         Console.ReadLine();
      }
   }
}
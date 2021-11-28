using System;

namespace Task_2
{
    public class Program
    {

        public enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3,
        }

        public enum Status
        {
            New = 1, 
            InProgress = 2 ,
            Failed = 3 ,
            Done= 4 ,
        }
        static void Main()
        {
            Console.WriteLine("ID? ");
            int ID = Convert.ToInt32(Console.ReadLine());
                 
            DateTime CreationDate = DateTime.Now;

            Console.WriteLine("Please select Priority for the bug");
            Console.WriteLine("1. Low");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. High");
            int selectPriority = Convert.ToInt32(Console.ReadLine());
            Priority priorityChoice = new Priority();
            priorityChoice = (Priority)selectPriority;

            switch (selectPriority)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            Console.WriteLine($"You selected \"{ priorityChoice.ToString()}\" as Priority");

            Console.WriteLine("Summary? ");
            string Summary = Console.ReadLine();

            Console.WriteLine("Preconditions? ");
            string Preconditions = Console.ReadLine();

            Console.WriteLine("Please select Status for the bug");
            Console.WriteLine("1. New");
            Console.WriteLine("2. In Progress");
            Console.WriteLine("3. Failed");
            Console.WriteLine("4. Done");
            int selectStatus = Convert.ToInt32(Console.ReadLine());
            Status statusMenu = new Status();
            statusMenu = (Status)selectStatus;

            switch (selectStatus)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;                  
            }    

            Console.WriteLine($"You have selected \"{statusMenu.ToString()}\" as Status");

            Console.WriteLine("Test Case ID? ");
            int TestCaseID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Step Number? ");
            int StepNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Actual result? ");
            string ActualResult = Console.ReadLine();

            Console.WriteLine("Expected Results? ");
            string ExpectedResult = Console.ReadLine();

            //Prints all output together
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine($"Priority: {priorityChoice.ToString()}");
            Console.WriteLine($"Summary: {Summary}");
            Console.WriteLine($"Preconditions: {Preconditions}");
            Console.WriteLine($"Status: {statusMenu.ToString()}");
            Console.WriteLine($"Test Case ID: {TestCaseID}");
            Console.WriteLine($"Step Number: {StepNumber}");
            Console.WriteLine($"Actual Result: {ActualResult}");
            Console.WriteLine($"Expected Result: {ExpectedResult}");


        }

         

        
        

    }
}

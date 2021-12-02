using System;
using static Task_2.enums;

namespace Task_2
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bug.Id);
            Console.WriteLine(Bug.CreationDate);
            Console.WriteLine(Step.Number);
            Console.WriteLine(TestCase.testId);
            Console.WriteLine(TestCase.BugCreationDate);
            
            Priority priority;
            Console.WriteLine("Select priority:\n 1. Low\n 2. Medium\n 3. High");
            string input = Console.ReadLine();
            
            bool success = Enum.TryParse<Priority>(input, out priority);

            if (!success)
            {
                Console.WriteLine("It is not valid priority", input);
                return;
            }

            switch (priority)
            {
                case Priority.Low:
                    Console.WriteLine("Low");
                    break;
                case Priority.Medium:
                    Console.WriteLine("Medium");
                    break;
                case Priority.High:
                    Console.WriteLine("High");
                    break;


            }
            Console.ReadKey();

            Status status;
            Console.WriteLine("Please select status:\n1. New\n2. InProgress\n3. Failed\n4. Done");
            string input2 = Console.ReadLine();

            bool success2 = Enum.TryParse<Status>(input2, out status);

            if (!success2)
            {
                Console.WriteLine("It is not valid status", input2);
                return;
            }

            switch (status)
            {
                case Status.New:
                    Console.WriteLine("New");
                    break;
                case Status.InProgress:
                    Console.WriteLine("In Progress");
                    break;
                case Status.Failed:
                    Console.WriteLine("Failed");
                    break;
                case Status.Done:
                    Console.WriteLine("Done");
                    break;


            }
            Console.ReadKey();
        }


        public class Bug
        {
            public static int Id = 0;
            public static DateTimeOffset CreationDate => DateTime.Now;
         
            
            public Priority Priority { get; set; }

            public string Summary { get; set; }

            public string Precondition { get; set; }
            public Status Status { get; set; }

            public static int TestCaseId = 0;

            public static int StepNumber = 0;

            public string ActualResult { get; set; }
            public string ExpectedResult { get; set; }

            
        }

        
        
        //Console.WriteLine("ID? ");
        //int ID = Convert.ToInt32(Console.ReadLine());

        //DateTime CreationDate = DateTime.Now;

        //Console.WriteLine("Please select Priority for the bug");
        //Console.WriteLine("1. Low");
        //Console.WriteLine("2. Medium");
        //Console.WriteLine("3. High");
        //int selectPriority = Convert.ToInt32(Console.ReadLine());
        //Priority priorityChoice = new Priority();
        //priorityChoice = (Priority)selectPriority;

        //switch (selectPriority)
        //{
        //    case 1:
        //        break;
        //    case 2:
        //        break;
        //    case 3:
        //        break;
        //    default:
        //        break;
        //}
        //Console.WriteLine($"You selected \"{ priorityChoice.ToString()}\" as Priority");

        //Console.WriteLine("Summary? ");
        //string Summary = Console.ReadLine();

        //Console.WriteLine("Preconditions? ");
        //string Preconditions = Console.ReadLine();

        //Console.WriteLine("Please select Status for the bug");
        //Console.WriteLine("1. New");
        //Console.WriteLine("2. In Progress");
        //Console.WriteLine("3. Failed");
        //Console.WriteLine("4. Done");
        //int selectStatus = Convert.ToInt32(Console.ReadLine());
        //Status statusMenu = new Status();
        //statusMenu = (Status)selectStatus;

        //switch (selectStatus)
        //{
        //    case 1:
        //        break;
        //    case 2:
        //        break;
        //    case 3:
        //        break;
        //    case 4:
        //        break;
        //    default:
        //        break;                  
        //}    

        //Console.WriteLine($"You have selected \"{statusMenu.ToString()}\" as Status");

        //Console.WriteLine("Test Case ID? ");
        //int TestCaseID = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Step Number? ");
        //int StepNumber = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Actual result? ");
        //string ActualResult = Console.ReadLine();

        //Console.WriteLine("Expected Results? ");
        //string ExpectedResult = Console.ReadLine();

        ////Prints all output together
        //Console.WriteLine($"ID: {ID}");
        //Console.WriteLine(DateTime.Now.ToString());
        //Console.WriteLine($"Priority: {priorityChoice.ToString()}");
        //Console.WriteLine($"Summary: {Summary}");
        //Console.WriteLine($"Preconditions: {Preconditions}");
        //Console.WriteLine($"Status: {statusMenu.ToString()}");
        //Console.WriteLine($"Test Case ID: {TestCaseID}");
        //Console.WriteLine($"Step Number: {StepNumber}");
        //Console.WriteLine($"Actual Result: {ActualResult}");
        //Console.WriteLine($"Expected Result: {ExpectedResult}");
    }









}


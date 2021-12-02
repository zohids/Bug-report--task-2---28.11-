using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class TestCase
    {
        public static int testId = ++Program.Bug.TestCaseId;

        public static DateTimeOffset BugCreationDate => DateTime.Now;
        public enums.Priority Priority { get; set; }

        public string Summary {get; set;}
        public string Precondition { get; set;} 
        public enums.Status Status { get; set; }
        public int Step { get; set; }  


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class enums
    {
        public enum Priority
        {
            Low = 1,
            Medium,
            High,
        }

        public enum Status
        {
            New = 1,
            InProgress,
            Failed,
            Done,
        }
    }
}

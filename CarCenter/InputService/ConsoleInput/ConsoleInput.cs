﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.InputService.ConsoleInput
{
    class ConsoleInput : IInputService
    {
        public string InputString()
        {
            return Console.ReadLine();
        }
    }
}
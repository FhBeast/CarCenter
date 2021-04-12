using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter.View.ConsoleOutput
{
    class ConsoleOutput : IOutputService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

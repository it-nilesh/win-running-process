using System;
using System.Diagnostics;
using System.Linq;

namespace RunningProcess
{
    //https://stackoverflow.com/questions/40070703/how-to-get-a-list-of-open-tabs-from-chrome-c-sharp
    class Program
    {
        static void Main(string[] args)
        {
            var processes = Process.GetProcesses().Where(x => !string.IsNullOrEmpty(x.MainWindowTitle));
            foreach (Process p in processes)
            {
                Console.WriteLine($"{p.ProcessName} -- {p.MainWindowTitle}");
            }

            Console.WriteLine();
        }
    }
}

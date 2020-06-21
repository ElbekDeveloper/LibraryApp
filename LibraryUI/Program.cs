using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibraryBLL;

namespace LibraryUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "no";
            do
            {
                Console.Clear();
                User.GiveOptions();

                Console.WriteLine("Return back to menu? (yes/no)");
                answer = Console.ReadLine();
            } while (answer.Trim() == "yes");
            Console.WriteLine("Closing...");
            Thread.Sleep(2000);
        }
    }
}

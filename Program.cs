using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace LogicalPrograms
{/// <summary>
/// UC6-StopWatch
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Creating new stopwatch object
            Stopwatch stopwatch = new Stopwatch();

            //Setting start timming of stopwatch by calling method start();
            stopwatch.Start();

            //For-loop
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            //Setting stop timming of stopwatch by calling method stop();
            stopwatch.Stop();
            Console.WriteLine("Time elapsed:{0}",stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}

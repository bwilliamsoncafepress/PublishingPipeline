using System;
using console = System.Console;

namespace PublishingPipeline.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            console.WriteLine("rt-1 - Commit 1");
            console.WriteLine("rt-2 - Commit 1");
            console.WriteLine("rt-1 - Commit 2");
            console.WriteLine("rt-2 - Commit 2");
            console.WriteLine("rt-1 - Commit 4");
            console.WriteLine("rt-1 - Commit 5");
        }
    }
}
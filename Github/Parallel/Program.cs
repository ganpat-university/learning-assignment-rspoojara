using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Demo_Parallel
{
    internal class Program
    {
        private static void displayNumber(int i)
        {
            Console.WriteLine("i = {0} on htread: {1}", i, Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Hello World!");

            int[] arr = { 1,2,3,4,5,6,7,8,9,10};



            Console.WriteLine("for loop!");
            stopwatch.Start();
            for(int i = 0;i<arr.Length;i++)
            {
                displayNumber(arr[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("Millisecond : {0}", stopwatch.ElapsedMilliseconds);
            
            
            Console.WriteLine("parallel for loop!");
            stopwatch.Start();
            Parallel.For(0, arr.Length, i =>
            {
                displayNumber(arr[i]);
            });
            stopwatch.Stop();
            Console.WriteLine("Millisecond : {0}", stopwatch.ElapsedMilliseconds);
            
  
            Console.WriteLine("foreach loop!");
            stopwatch.Restart();
            foreach(int i in arr)
            {
                displayNumber(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Millisecond : {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}

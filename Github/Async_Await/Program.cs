using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            Console.WriteLine("Main is running on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("----Running Synchronously");
            result = ProcessJob(10);
            Console.WriteLine("Result = {0}",result);


            Console.WriteLine("----Running ASynchronously");
            Task<bool> returnVal = ProcessJobAsync(100);
            Console.WriteLine("Waiting for the result.");
            returnVal.Wait();
            result = returnVal.Result;

            Console.WriteLine("Result = {0}",result);
        }
        private static bool ProcessJob(int i)
        {
            Thread.Sleep(5000); // sleep for 5 seconds
            Console.WriteLine("Process Job start with i = {0} on thread {1}", i, Thread.CurrentThread.ManagedThreadId);

            return true;
        }

        private static async Task<bool> ProcessJobAsync(int i)
        {
            //await for the task to run 
            // return the value from the task.
            return await Task.Run( () => ProcessJob(i));
        }
    }
}

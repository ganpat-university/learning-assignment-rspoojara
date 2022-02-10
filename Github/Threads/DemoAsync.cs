using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class DemoAsync
    {
        public static void DoThis()
        {
            Console.WriteLine("Calling from DoThis() thread {0}", Thread.CurrentThread.ManagedThreadId);
        }
        public static void RunThis()
        {
            DoThis();
            Console.WriteLine("Calling from RunThis() thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread t1 = new Thread(new ThreadStart(DoThis));
            t1.Start();
        }
    }
}

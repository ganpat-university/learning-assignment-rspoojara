using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class DemoClass
    {

        public static void DoThis()
        {
            Console.WriteLine("Calling from DoThis() thread {0}", Thread.CurrentThread.ManagedThreadId);
        }
        public static void RunThis()
        {
            DoThis();
            Console.WriteLine("Calling from RunThis() thread {0}", Thread.CurrentThread.ManagedThreadId);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadSemaphore
    {
        static Semaphore semaphore = new Semaphore(5, 5);
        static int count= 0;
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Count);
                thread.Name = $" name  {i}";
                thread.Start();
            }
            
        }
        public static void Count()
        {
            semaphore.WaitOne();

            Interlocked.Increment(ref count);

            System.Diagnostics.Debug.WriteLine($"042-semaphore- {Thread.CurrentThread.Name}   START   {count}");

            Thread.Sleep(new Random().Next(500,1000));

            System.Diagnostics.Debug.WriteLine($"043-semaphore- {Thread.CurrentThread.Name}   End   {count}");

            Interlocked.Decrement(ref count);

            semaphore.Release();
        }
    }
}
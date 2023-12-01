using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadMutex
    {
        static Mutex mutexObj = new Mutex();
        static int x = 0;
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
            mutexObj.WaitOne();
            x = 1;
            for (int i = 0; i < 5; i++)
            {
                System.Diagnostics.Debug.WriteLine($"ThreadMutex 031-mutex-{Thread.CurrentThread.Name} == {x}");
                
                x++;
                Thread.Sleep(100);
            }
            mutexObj.ReleaseMutex();
        }
    }
}
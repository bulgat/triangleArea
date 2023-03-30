using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadWait
    {
        static AutoResetEvent waitHandler= new AutoResetEvent(true);
        static int x = 0;

        public static void Main()
        {
            for(int i = 0; i < 6; i++)
            {
                Thread thread = new Thread(Count);
                thread.Name = $" name  {i}";
                thread.Start();
            }
        }
        public static void Count()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 0; i < 6; i++)
            {
                System.Diagnostics.Debug.WriteLine($"021--{Thread.CurrentThread.Name} == {x}");
                
                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
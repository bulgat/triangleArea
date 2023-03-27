using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadMain
    {
        public ThreadMain()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(WriteSecond);
            thread.Start();
        }
        static void WriteSecond()
        {
            while (true)
            {
                Thread.Sleep(2000);
                System.Diagnostics.Debug.WriteLine("- едет по дороге = "+Thread.CurrentThread.GetHashCode());
            }
        }
    }
}
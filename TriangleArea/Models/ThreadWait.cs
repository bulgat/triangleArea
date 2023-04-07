using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadWait
    {
        static AutoResetEvent waitHandler= new AutoResetEvent(true);
        static int x = 0;
        static volatile bool stop;
        static bool kol;
        public static void Main()
        {
            for(int i = 0; i < 6; i++)
            {
                Thread thread = new Thread(Count);
                thread.Name = $" name  {i}";
                thread.Start();
                Thread.Sleep(500);
                stop = true;
                kol = true;

                Action myDelegate = new Action(CountSecond);
                //myDelegate.Invoke();
                //IAsyncResult asyncResult =  myDelegate.BeginInvoke(null,null);
                //myDelegate.EndInvoke(asyncResult);
                Task task = new Task(myDelegate);
                task.RunSynchronously();

                for (int z = 0; z < 6; z++)
                {
                    Thread.Sleep(100);
                    System.Diagnostics.Debug.WriteLine("=Main="+z );
                }

            }
        }
        public static void Count()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 0; i < 6; i++)
            {
                System.Diagnostics.Debug.WriteLine($"021--{Thread.CurrentThread.Name} == {x}     stop= {stop}     kol = {kol}");
                
                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
        public static void CountSecond()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 0; i < 6; i++)
            {
                System.Diagnostics.Debug.WriteLine($"022222221--{Thread.CurrentThread.Name} == {x}     stop= {stop}     kol = {kol}");

                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
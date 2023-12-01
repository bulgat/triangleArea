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
            for(int i = 0; i < 5; i++)
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

                for (int z = 0; z < 5; z++)
                {
                    Thread.Sleep(100);
                    System.Diagnostics.Debug.WriteLine("=Main="+z );
                }

            }
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(CountQueue);
                Thread.Sleep(200);
            }
            Action action = () =>
            {

                while (true)
                {
                    System.Diagnostics.Debug.WriteLine($"ThreadWait 02444 --{DateTime.Now.ToLongDateString()} ==  Action = ");
                    Thread.Sleep(1000);
                }
            };
            //Task task = new Task(action);
            //task.Start();

            //Task task1 = Task.Factory.StartNew(action);

            Task<bool> task0 = Task<bool>.Factory.StartNew(CountBool);
            bool result = task0.Result;
            task0.ContinueWith(t=>Console.WriteLine("ThreadWait 26 Complite"));
        }
        public static void Count()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 0; i < 5; i++)
            {
                System.Diagnostics.Debug.WriteLine($"ThreadWait 021--{Thread.CurrentThread.Name} == {x}     stop= {stop}     kol = {kol}");
                
                x++;
                //Thread.Sleep(100);
               // if (i == 5)
                //{
                //    throw new Exception("Мне не нравится 6!!!!");
               // }
            }
            waitHandler.Set();
        }
        public static void CountQueue(object i) {
            System.Diagnostics.Debug.WriteLine($"ThreadWait 02333333--{Thread.CurrentThread.Name} ==    Queue = {i}");
        }
        public static bool CountBool()
        {
            System.Diagnostics.Debug.WriteLine($"ThreadWait 02555555--{Thread.CurrentThread.Name} ==   Bool = ");
            return true;
        }
        public static void CountSecond()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 0; i < 5; i++)
            {
                System.Diagnostics.Debug.WriteLine($"ThreadWait 022222221--{Thread.CurrentThread.Name} == {x}     stop= {stop}     kol = {kol}");

                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
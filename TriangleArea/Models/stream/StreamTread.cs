using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models.stream
{
    public class StreamTread
    {
        public StreamTread()
        {
            int n1 = 4, n2 = 5;
            Task<int> sumTask = new Task<int>(() => n1 + n2);
            sumTask.Start();
            var tt = sumTask.Result;
            System.Diagnostics.Debug.WriteLine("5  er  = " + tt);
            //krik().Start();


            Task[] tasks1 = new Task[3]
            {
                new Task(() => {
                    Thread.Sleep(2000);
                    System.Diagnostics.Debug.WriteLine("First Task"); }) ,
                new Task(() => {
                    Thread.Sleep(2000);
                    System.Diagnostics.Debug.WriteLine("Second Task"); }),
                new Task(() => {
                    Thread.Sleep(2000);
                    System.Diagnostics.Debug.WriteLine("Third Task"); })
            };
            foreach (var item in tasks1)
            {
                item.Start();
            }
            //Task.WaitAll(tasks1);
            Task.WaitAny(tasks1);

            Thread.Sleep(4000);
            var t = krik().Result;
            System.Diagnostics.Debug.WriteLine("6  er  = " + t);
            var tttt = new Stop<int> ();
            var sssss = new Stop<string>();
            System.Diagnostics.Debug.WriteLine("601  er  = " + tttt.Krik(100));
            System.Diagnostics.Debug.WriteLine("602  er  = " + sssss.Krik("jjjjj"));
        }

        
        private static async Task<int> krik()
        {
            return 999;
        }
    }
    public class Stop <T>
    {
        public T Krik(T x)
        {
            return x;
        }
    }
}
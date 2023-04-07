using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadCancelation
    {
        public static void Main()
        {
            var cancelationTask = new CancellationTokenSource();
            var task = Task.Run(()=> ProcessTask(cancelationTask.Token));
            Task.Delay(5000).GetAwaiter().GetResult();
            cancelationTask.Cancel();
            try
            {
                System.Diagnostics.Debug.WriteLine("9998--- erro ss = " );
                //await task;
            }
            catch (Exception)
            {
               
            }
        }
        public static async Task ProcessTask(CancellationToken CancelTask) {
            var i = 0;
            while (true)
            {
                CancelTask.ThrowIfCancellationRequested();
                await Task.Delay(500);
                System.Diagnostics.Debug.WriteLine("9999 =="  );
            }
        }
    }
}
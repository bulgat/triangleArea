using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace TriangleArea.Models.adapter
{
    public class CustomerValidator
    {
        private static SemaphoreSlim semaphore;
        private static int padding;
        public CustomerValidator() {
            semaphore = new SemaphoreSlim(0, 3);

            System.Diagnostics.Debug.WriteLine("{0} tasks can enter the semaphore.",
                          semaphore.CurrentCount);
            Task[] tasks = new Task[5];

            // Create and start five numbered tasks.
            for (int i = 0; i <= 4; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    // Each task begins by requesting the semaphore.
                    

                    int semaphoreCount=0;
                    System.Diagnostics.Debug.WriteLine("{0} begins task and waits for the semaphore. count = {1} semaphore count = {2}",
                                      Task.CurrentId, semaphoreCount, semaphore.CurrentCount);
                    semaphore.Wait();
                    try
                    {
                        Interlocked.Add(ref padding, 5);

                        System.Diagnostics.Debug.WriteLine("Task {0} enters the semaphore.  semaphore count = {1}", Task.CurrentId, semaphore.CurrentCount);

                        // The task just sleeps for 1+ seconds.
                        Thread.Sleep(5 + padding);
                    }
                    finally
                    {
                        System.Diagnostics.Debug.WriteLine("Task № {0} OUT semaphore. semaphoreCount = {1}", Task.CurrentId, semaphoreCount);
                        semaphoreCount = semaphore.Release();
                        
                    }
                    System.Diagnostics.Debug.WriteLine("Task № {0} releases the semaphore; previous count: {1}.",
                                      Task.CurrentId, semaphoreCount);
                });
            }

            // Wait for half a second, to allow all the tasks to start and block.
            Thread.Sleep(5);

            // Restore the semaphore count to its maximum value.
            System.Diagnostics.Debug.WriteLine("@@@@ Main thread calls Release(3) --> {0}",semaphore.CurrentCount);
            semaphore.Release(3);
            System.Diagnostics.Debug.WriteLine("@@@@ {0} tasks can enter the semaphore.",
                              semaphore.CurrentCount);

            Task.WaitAll(tasks);

            System.Diagnostics.Debug.WriteLine("@@@@ Main thread exits. {0}", semaphore.CurrentCount);
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadMain
    {
        ReaderWriterLockSlim LockSlim = new ReaderWriterLockSlim();

        public ThreadMain()
        {


            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(WriteSecond);
            thread.Start();
            #region
            object lockTask = new object();
             Task.Run(()=> {

                lock (lockTask)
                {
                    for (var i = 0; i < 10; i++)
                    {
                        Thread.Sleep(1000);
                        System.Diagnostics.Debug.WriteLine($"0001 - едет по {i} = " + Thread.CurrentThread.GetHashCode());
                    }
                    System.Diagnostics.Debug.WriteLine($"0001 -------- END TASK = " + Thread.CurrentThread.GetHashCode());
                    return 34;
                }
            });
            try { 
                LockSlim.EnterReadLock();
                for (var i = 0; i < 10; i++)
                {
                    Task.Delay(1000);
                    System.Diagnostics.Debug.WriteLine($"0005  едет {i}  = " + Thread.CurrentThread.GetHashCode());
                }
            } finally
            {
                LockSlim.ExitReadLock();
            }
            


            Task.Run(async () => {
                //lock (lockTask)
                //{
                    for (var i = 0; i < 10; i++)
                    {
                        await Task.Delay(1000);
                        System.Diagnostics.Debug.WriteLine($"0002  едет {i}  = " + Thread.CurrentThread.GetHashCode());
                    }
                return 7777;
                //}
            });


            #endregion

            int count = 0;
            Task.WaitAll(
                Task.Run(()=> {
                    for (var i = 0; i < 10000; i++)
                    {
                        Interlocked.Increment(ref count);
                    }
                }),
                Task.Run(() => {
                    for (var i = 0; i < 10000; i++)
                    {
                        Interlocked.Increment(ref count);
                    }
                }),
                Task.Run(() => {
                    for (var i = 0; i < 10000; i++)
                    {
                        Interlocked.Increment(ref count);
                    }
                }),
                Task.Run(() => {
                    for (var i = 0; i < 10000; i++)
                    {
                        Interlocked.Increment(ref count);
                    }
                })
                );


            var _lockMonitor = false;
            try
            {
                System.Diagnostics.Debug.WriteLine("-  MONITOR = " );
                Monitor.Enter(lockTask, ref _lockMonitor);
                    for (var i = 0; i < 10; i++)
                    {
                        Thread.Sleep(5000);
                        System.Diagnostics.Debug.WriteLine($"0003 - ед {i}  =  _lockMonitor =  {_lockMonitor}            " + Thread.CurrentThread.GetHashCode());
                    }
            }
            finally
            {
                if (_lockMonitor)
                {
                    System.Diagnostics.Debug.WriteLine($"- EXIT MONITOR = {_lockMonitor}    count = "+ count);
                    
                    Monitor.Exit(lockTask);
                }
            }

        }
        static void WriteSecond()
        {
            while (true)
            {
                Thread.Sleep(10000);
                System.Diagnostics.Debug.WriteLine("-  по дороге = "+Thread.CurrentThread.GetHashCode());
            }
        }
    }
}
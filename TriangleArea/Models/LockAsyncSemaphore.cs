using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class LockAsyncSemaphore
    {
        private readonly SemaphoreSlim _lock ;

        public async Task Lock(Func<Task> f)
        {
            await _lock.WaitAsync();
            try
            {
                await f();
            }
            finally
            {
                _lock.Release();
            }
        }
        public async Task<T> Lock<T>(Func<Task<T>> f)
        {
            await _lock.WaitAsync();
            try
            {
                return await f();
            }
            finally
            {
                _lock.Release();
            }
        }
    }
}
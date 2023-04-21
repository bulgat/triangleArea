using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class TaskFactory
    {
        public static void Main()
        {
            int i = 0;
            List<Task> taskList = new List<Task>();

            Action action = () =>
        {

            //while (true)
            //{
                System.Diagnostics.Debug.WriteLine($"0244444--{DateTime.Now.ToLongDateString()} ==  Action = ");
                Thread.Sleep(1000);
                i++;
            //}
        };

            Task task = Task.Factory.StartNew(action);
            taskList.Add(task);

            Task.Factory.ContinueWhenAll(taskList.ToArray(),ts=> { });
        }
        /*
        public static Task Work(int Test)
        {
            Thread.Sleep(1000);

            //return this;
        }
        */
    }

}
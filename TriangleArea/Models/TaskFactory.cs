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
            
            Task<int> task2 = Task<int>.Factory.StartNew(SumInt, 3);
            System.Diagnostics.Debug.WriteLine($"TaskFactory__________________025556- ==SUMMA Подсчет = " + task2.Result);
            task2.Dispose();
            


            int i = 0;
            List<Task> taskList = new List<Task>();
            /*
            Action action = () =>
        {

            //while (true)
            //{
                System.Diagnostics.Debug.WriteLine($"024444--{DateTime.Now.ToLongDateString()} ==  Action = ");
                Thread.Sleep(1000);
                i++;
            //}
        };

            Task task = Task.Factory.StartNew(action);
            taskList.Add(task);

            Task.Factory.ContinueWhenAll(taskList.ToArray(),ts=> { });
            */
            Parallel.Invoke(SumInt2, SumInt3);
            Parallel.For(0, data.Length, Transform);
            System.Diagnostics.Debug.WriteLine("TaskFactory 6 SSSSSSSSSSSSSSSS = " + data[100]);
            data[101] = 999;
            var resultNum = data.AsParallel().Where(a => a == 999).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine(data[101]+ " TaskFactory  SSSSSSSSSSumma  = " + resultNum);
            var resultList = data.AsParallel().AsOrdered().OrderBy(a=>a).ToList();

            System.Diagnostics.Debug.WriteLine("TaskFactory   SSSSSSSumma  = " + resultList[0]);
        }
       
        public static int SumInt(object Num)
        {
            int count = (int)Num;
            for(var i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                System.Diagnostics.Debug.WriteLine($"TaskFactory 025555- == Подсчет = " +i);
                count++;
            }

            return count;
        }
        public static void SumInt2()
        {
            int count = 0;
            for (var i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                System.Diagnostics.Debug.WriteLine($"TaskFactory 066666- == Подсчет = " + i);
                count++;
            }

            //return count;
        }
        public static void SumInt3()
        {
            int count = 0;
            for (var i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                System.Diagnostics.Debug.WriteLine($"TaskFactory 77777- == Подсчет = " + i);
                count++;
            }

            //return count;
        }
        static int[] data = new int[1000];
        static void Transform(int i)
        {
            data[i] = 4;
        }
    }

}
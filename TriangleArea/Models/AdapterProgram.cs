using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading;
using TriangleArea.Models.stream;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;

namespace TriangleArea.Models
{
    public class AdapterProgram
    {

        public AdapterProgram()
        {
            Stack<int> stackList = new Stack<int>();
            stackList.Push(1);
            stackList.Push(2);
            stackList.Push(3);
            var ttt = stackList.Pop();
            

            int[] arrStep = new int[3];
            Array.Resize(ref arrStep, 10);
            System.Diagnostics.Debug.WriteLine("-01--  = " + arrStep.Length);

            ObservableCollection<string> peoplelist = new ObservableCollection<string>(new string[] { "Tom", "Bob", "Sam" });
            peoplelist.CollectionChanged += People_CollectionChanged;
            peoplelist.Add("Bob");  // добавляем новый элемент

            peoplelist.RemoveAt(1);                 // удаляем элемент
            peoplelist[0] = "Eugene";

System.Diagnostics.Debug.WriteLine("-00--  p = " + ttt+""+ String.Intern("kol"));


            System.Diagnostics.Debug.WriteLine("-02--   = " + ("Tom"+String.Intern(peoplelist[0])));

            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");


          

            LinkedListMain();

            Tourist tourist = new Tourist();
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            Jeep jeep = new Jeep();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel("Camel_Noise", 999, 666);
            camel.Cry = "Noooo";
            Type type = camel.GetType();
            var test = camel.GetType();
            Type test0 = typeof(Camel);
            FieldInfo myFieldInfo = test0.GetField("Noise");
            

            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            MyMethod(new List<string>() { "ko", "test" });
            List<int> methodlist = new List<int>() { 1, 4, 7, 8 };
            MyMethod(methodlist);
            //Console.Read();
            var i = 5;
            var enumerator = Fill(i);

            var yyy = methodlist.Where(b => b == 4).FirstOrDefault();

            foreach(var itemF in methodlist.Where(z=>z>0))
            {
                System.Diagnostics.Debug.WriteLine("- 777   = " + itemF);
            }
            

            System.Diagnostics.Debug.WriteLine("-03--  p  = " + yyy);

            dynamic a = "123";
            dynamic c = 50;
            dynamic kol = a + c;//.toString();
            string result = (string)kol;
            double d = 465.97443464564;
            
            result = null;
            var koll = result ?? "---5  erro = ";

            var kol22 = new StreamTread();

            ConcurrentQueue<int> number_ar = new ConcurrentQueue<int>();
            number_ar.Enqueue(1);
            number_ar.Enqueue(999);
            number_ar.Enqueue(400);
            number_ar.Enqueue(3);

         
            int item;
            bool isSuccessful = number_ar.TryDequeue(out item);

            
            

            bool isSuccessful_0 = number_ar.TryDequeue(out item);
            
            

            Dictionary<Type,int> map = new Dictionary<Type,int>();
            map.Add(typeof(int), 1);
            map.Add(typeof(string), 999);

            System.Diagnostics.Debug.WriteLine(map[typeof(int)] +"-04--  pe = " + map[typeof(string)]);

            new Thread(new ThreadStart(Run)).Start();

        }
        void People_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            

            
        }
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(10000);
                
            }
        }


        static IEnumerator<int> Fill(int i)
        {
            /*
            if (i % 2==0)
            {
                yield break;
            }
            */
            //if (i < 3)
            //{
                i++;
                yield return i;
           // }
        }
      

        void MyMethod<T>(List<T> list)
        {
            //Do stuff
            
        }

        private void LinkedListMain() { 
            
            var employees = new List<string> { "Tom", "Sam", "Bob" };

            LinkedList<string> people = new LinkedList<string>(employees);
            foreach (string person in people)
            {
                System.Diagnostics.Debug.WriteLine("---  person = " + person);
            }
            char[] strList = "zzzasdaf".ToCharArray();
             Array.Reverse(strList);
            strList = strList.Distinct().ToArray();
            for(int i=0; i< strList.Length;i++)
            {
                System.Diagnostics.Debug.WriteLine("---  p  = " + strList[i]);
            }

        }
    }

    // класс машины
  

    // интерфейс животного
 
    // класс верблюда

    // Адаптер от Camel к ITransport

}
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
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Microsoft.Ajax.Utilities;
using System.Linq.Expressions;
using System.IO;
using System.Text;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using TriangleArea.Models.adapter;
using Autofac;

namespace TriangleArea.Models
{
    public delegate void MakeNoise();
 
    public class AdapterProgram
    {
        public interface IAdapter
        {
            string Name();
        }
   
        [Flags]
        enum MultiKey 
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };
        public MakeNoise makeNoise;
        IEnumerable mass_ar;


        Task<int> AddAsync(int a, int b)
        {
            return Task.FromResult(a + b);
        }
        int Plus(int a, int b) {
            return a + b;
        }
        public AdapterProgram()
        {

            System.Diagnostics.Debug.WriteLine("=0006 "  );

            System.Diagnostics.Debug.WriteLine("=0006 "  );
            System.Diagnostics.Debug.WriteLine("=0006 "  );
            System.Diagnostics.Debug.WriteLine("=0006 "  );
            System.Diagnostics.Debug.WriteLine("=0006 "  );
            System.Diagnostics.Debug.WriteLine("=0006 "  );

            IContainer container = new Mersedes().GetAutofacContainer();
            var model = container.Resolve<Auto>();
            var beast = container.Resolve<Beast>();
            //var anim = container.Resolve<CamelAnimal>();

            int? numberOne = 67;
            int? numberTwo = null;

            var eee = numberTwo;

            mass_ar = new List<int>() { 5,6 };
            mass_ar = new int[6];
      

            System.Diagnostics.Debug.WriteLine(numberOne.HasValue+" ==000== " + numberTwo.HasValue);
            System.Diagnostics.Debug.WriteLine(numberOne.Value + " ==010== " + numberTwo.GetValueOrDefault());
            System.Diagnostics.Debug.WriteLine(numberOne.GetValueOrDefault() + " ==020== " );


            var resultTask = AddAsync(4, 5);
            int res = (int)resultTask.Result;
            System.Diagnostics.Debug.WriteLine(res+" FFFFF = "+resultTask);

            int www = Task.FromResult(Plus(5,7)).Result;

            System.Diagnostics.Debug.WriteLine(  " www= " + www);

            ThreadWait.Main();
            ThreadMutex.Main();
            ThreadSemaphore.Main();
            ThreadCancelation.Main();
            ThreadDelegate.Main();
            TaskFactory.Main();

            int[] arr = new int[] {5,6,7 };
            int[] arr0 = new int[] {};
            System.Diagnostics.Debug.WriteLine("=  arr =  " + arr.Any()+ "  arr0 = " + arr0.Any());

            Task.Factory.StartNew(() =>
            {
                System.Diagnostics.Debug.WriteLine("__000008  Server");
                var server = new NamedPipeServerStream("PipesOfPiece");
                server.WaitForConnection();
                StreamReader reader = new StreamReader(server);
                StreamWriter writer = new StreamWriter(server);
                while (true)
                {
                    System.Diagnostics.Debug.WriteLine("__0000092  StartServer  " + reader);
                    System.Diagnostics.Debug.WriteLine("__0000093  StartServer  " + reader.ReadLine());
                    string line = reader.ReadLine();
                    System.Diagnostics.Debug.WriteLine("__0000094 Server line = " + line);
                    writer.WriteLine(String.Join("", line.Reverse()));
                    
                    //writer.Flush();
                }
            });
 
          


            Stack<int> stackList = new Stack<int>();
            stackList.Push(1);
            stackList.Push(2);
            stackList.Push(3);
            var ttt = stackList.Pop();
            

            int[] arrStep = new int[3];
            Array.Resize(ref arrStep, 10);
            System.Diagnostics.Debug.WriteLine("-01--"+ MultiKey.Red.ToString() + " ____ val = "+ ((MultiKey)5) + " = " + arrStep.Length);

            Expression<Func<int>> add = () => 1 + 2;
            var func = add.Compile(); // Create Delegate
            var answer = func(); // Invoke Delegate
            System.Diagnostics.Debug.WriteLine("answer = " + answer);

            ObservableCollection<string> peoplelist = new ObservableCollection<string>(new string[] { "Tom", "Bob", "Sam" });
            string[] peopleArray = { "Tom", "Sam", "Bob" };
            object[] peopleArrayObj = { null, null, "Bob" };
            object[] peopleArrayTwoObj = { null, null};
            System.Diagnostics.Debug.WriteLine(peopleArray.Cast<string>().Any() + " ==020== ");
            System.Diagnostics.Debug.WriteLine(peopleArrayObj.Cast<string>().Any() + " ==030== ");

            IEnumerable<string> cast = peopleArray.Cast<string>();
            IEnumerable<string> castTwo = peopleArrayObj.Cast<string>();
            bool castThree = peopleArrayObj.Cast<string>().Any();
            bool castFour = peopleArrayTwoObj.Cast<string>().Any();

            IEnumerator peopleEnumerator = peopleArray.GetEnumerator();

            while(peopleEnumerator.MoveNext())
            {
               System.Diagnostics.Debug.WriteLine("-02-  val = "+ ((MultiKey)8) + "  = " + peopleEnumerator.Current); 
            }

            Queue<string> people = new Queue<string>(new List<string> { "Tom", "Sam", "Bob" });
            
            
            // добавляем элементы
            people.Enqueue("Tom0");  
            people.Enqueue("Bob0"); 
            people.Enqueue("Sam0"); 

            // получаем элемент из самого начала очереди 
            var firstPerson = people.Peek();
            System.Diagnostics.Debug.WriteLine("val =" + ((MultiKey)3) + "    firstPerson = " + firstPerson); // Tom

            // удаляем элементы

            var person1 = people.Dequeue();  // people = { Bob, Sam  }
  
            var person2 = people.Dequeue();  // people = { Sam  }

            var person3 = people.Dequeue();  // people = {  }


            int index;

            index = -40;

            var peopleEnum = FillEnumerator(0);

            System.Diagnostics.Debug.WriteLine("-05-  p  = " + peopleEnum.Count());

            var pointEnum = GetEnumerator(3, 6, 7);

            System.Diagnostics.Debug.WriteLine("-06-  p  = " + pointEnum.Count());

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

            string[] dinosaurs = { "Compsognathus",
            "Amargasaurus",   "Ovz",      "Velociraptor",
            "Deinonychus",    "Dilophosaurus",  "Gallimimus",
            "Triceratopsz" };

            System.Diagnostics.Debug.WriteLine("-033--   = "+Array.FindIndex(dinosaurs, TrueWi));
            System.Diagnostics.Debug.WriteLine("-033--   = " + Array.FindIndex(dinosaurs, FalseWi));

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
            CamelAnimal camel = new CamelAnimal("Camel_Noise", 999, 666);
            camel.Cry = "Noooo";
            Type type = camel.GetType();
            var test = camel.GetType();
            Type test0 = typeof(CamelAnimal);
            FieldInfo myFieldInfo = test0.GetField("Noise");
            

            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            MyMethod(new List<string>() { "ko", "test" });
            List<int> methodlist = new List<int>() { 1, 4, 7, 8 };
            System.Diagnostics.Debug.WriteLine("-050--   = " + methodlist.Count+ "   Capacity = " + methodlist.Capacity);
            methodlist.Capacity=20;
            System.Diagnostics.Debug.WriteLine("-051--   = " + methodlist.Count+ "   Capacity = " + methodlist.Capacity);
            MyMethod(methodlist);
 
            var i = 5;
            var enumerator = FillEnumerator(i);

            var yyy = methodlist.Where(b => b == 4).FirstOrDefault();

            foreach(var itemF in methodlist.Where(z=>z>0))
            {
                System.Diagnostics.Debug.WriteLine("- 777   = " + itemF);
            }
            methodlist.Clear();
            System.Diagnostics.Debug.WriteLine("-052--   = " + methodlist.Count + "   Capacity = " + methodlist.Capacity);
            methodlist.TrimExcess();
            System.Diagnostics.Debug.WriteLine("-053--   = " + methodlist.Count + "   Capacity = " + methodlist.Capacity);

            System.Diagnostics.Debug.WriteLine("-03--  p  = " + yyy);

            dynamic a = "123";
            dynamic c = 50;
            dynamic kol = a + c;
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

            System.Diagnostics.Debug.WriteLine(map[typeof(int)] +"-000010--  pe = " + map[typeof(string)]);

            Fire();
            FireFlash();
            System.Diagnostics.Debug.WriteLine(  "-000011--  = " );
            new Thread(new ThreadStart(RunTest)).Start();
        }
        public void Fire()
        {
            makeNoise += MakeFlash;
            makeNoise?.Invoke();
        }
        public virtual void FireFlash()
        {
            System.Diagnostics.Debug.WriteLine("-105   FireFlash = ");
        }

        public void MakeFlash()
        {
            System.Diagnostics.Debug.WriteLine("-104- MakeFlash = ");
        }

        private static bool TrueWi(String s)
        {
            System.Diagnostics.Debug.WriteLine("-041--   = " + s);
            return s.IndexOf('z')>-1;
        }
        private static bool FalseWi(String s)
        {
            return false;
        }

        void People_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            

            
        }
        public void RunTest()
        {
            System.Diagnostics.Debug.WriteLine("__000006 ");
            //Client
            var client = new NamedPipeClientStream("PipesOfPiece");
            client.Connect();
            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);
            System.Diagnostics.Debug.WriteLine("__000007 ");
            while (true)
            {
                string input = Console.ReadLine();
                System.Diagnostics.Debug.WriteLine("__000003 _________ input = " + input);
                if (String.IsNullOrEmpty(input)==false)
                {

                    writer.WriteLine(input);
                    writer.Flush();
                    System.Diagnostics.Debug.WriteLine("__000004  " + reader.ReadLine());
                }
                else 
                { 

                    System.Diagnostics.Debug.WriteLine("__000005 Break  ");
                    break;
                }
            }
        }


        private IEnumerable<string> FillEnumerator(int i)
        {
            System.Diagnostics.Debug.WriteLine("-  person = " );
            var result = new List<string>();

            string[] peopleArray = { "Tom", "Sam", "Bob" };

            IEnumerable<string> peopleEn = peopleArray.Cast<string>().ToList();

            System.Diagnostics.Debug.WriteLine("-03-  p  = " + peopleEn.Count());
            foreach (var itemEn in peopleEn)
            {
                System.Diagnostics.Debug.WriteLine("-04-  p  = " + itemEn);
                yield return itemEn;
            }

        }
        public IEnumerable<int> GetEnumerator(int X,int Y,int Z)
        {
            yield return X;
            yield return Y;
            yield return Z;
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
                
            }
            char[] strList = "zzzasdaf".ToCharArray();
             Array.Reverse(strList);
            strList = strList.Distinct().ToArray();
            for(int i=0; i< strList.Length;i++)
            {
                
            }

        }
    }

}
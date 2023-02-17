using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace TriangleArea.Models
{
    public class AdapterProgram
    {
      
        public AdapterProgram()
        {
            LinkedListMain();

            Tourist tourist = new Tourist();
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel("Camel_Noise",999,666);
            camel.Cry="Noooo";
            Type type = camel.GetType();
            var test = camel.GetType();
            Type test0 = typeof(Camel);
            FieldInfo myFieldInfo = test0.GetField("Noise");
            System.Diagnostics.Debug.WriteLine("0001 r   test = ["+ test.GetField("Cry") +"]  ="+ test);
            System.Diagnostics.Debug.WriteLine("0002 erro = " + test0+ " test0 =  [" + test0.GetField("Cry")+"]");
            System.Diagnostics.Debug.WriteLine("0003 er  = " + myFieldInfo.Name+" == "+ myFieldInfo.GetValue(camel));
            foreach (Type itype in type.GetInterfaces())
            {
                System.Diagnostics.Debug.WriteLine("=="+ itype.Name);
            }
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            MyMethod(new List<string>() {"ko","test" });
            MyMethod(new List<int>() { 1, 4,7,8 });
            //Console.Read();
            var i = 5;
            var enumerator = Fill(i);
            System.Diagnostics.Debug.WriteLine("--- 3 erro = " + enumerator.Current);
            System.Diagnostics.Debug.WriteLine("--- 0 erro ssag = " + enumerator.MoveNext());
            System.Diagnostics.Debug.WriteLine("--- 3 erro = " + enumerator.Current);
            System.Diagnostics.Debug.WriteLine("--- 1 erro ssag = " + enumerator.MoveNext());
            System.Diagnostics.Debug.WriteLine("--- 3 erro = " + enumerator.Current);
            System.Diagnostics.Debug.WriteLine("--- 2 erro ssag = " + enumerator.MoveNext());
            
            System.Diagnostics.Debug.WriteLine("--- 3 erro = " + enumerator.Current);

            dynamic a = "123";
            dynamic c = 50;
            dynamic kol = a + c;//.toString();
            string result = (string)kol;
            double d = 465.97443464564;
            System.Diagnostics.Debug.WriteLine("---4   = " + result);
            result = null;
            var koll = result ?? "---5  erro = ";

            
            System.Diagnostics.Debug.WriteLine("---5  erro = " + koll);
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
            System.Diagnostics.Debug.WriteLine("--- erro ss = "+ list[0]);
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
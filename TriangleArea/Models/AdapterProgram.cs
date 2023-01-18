using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class AdapterProgram
    {
      
        public AdapterProgram()
        {
            System.Diagnostics.Debug.WriteLine("---My error message. ");
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            Console.Read();
        }
        
    }

    // класс машины
  

    // интерфейс животного
 
    // класс верблюда

    // Адаптер от Camel к ITransport

}
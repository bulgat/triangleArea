using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class Jeep:Auto
    {
        public void Main()
        {
            Auto auto = new Auto();
            Jeep jeep = new Jeep();
            var equal = jeep.Equals(auto);
      
            ;
        }
        public void SetFunc(Func<int> func)
        {
            var kol = func();
      System.Diagnostics.Debug.WriteLine(kol +" =  car   func = " + func);
        }

    }
}
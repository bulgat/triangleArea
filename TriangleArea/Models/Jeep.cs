using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Jeep:Auto
    {
        public void Main()
        {
            Auto auto = new Auto();
            Jeep jeep = new Jeep();
            System.Diagnostics.Debug.WriteLine("0003 e car = " + jeep.Name);
            ;
        }
    }
}
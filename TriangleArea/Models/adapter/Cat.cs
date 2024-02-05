using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models.adapter
{
    public class Cat: Camel
    {
        public Cat(string name):base(name) { 
        
        }
        public override void Execute()
        {
            System.Diagnostics.Debug.WriteLine("--- CAt tpu!! ---");
        }
    }
}
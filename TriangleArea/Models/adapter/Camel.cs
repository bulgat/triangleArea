using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Camel : Beast
    { 
        public string Noise;
        private string Name;
        public Camel(string name) : base(name)
        {

            this.Name = name;
        }

        public Camel(string name, params int[] argument_ar) : this(name)
        {
            
   
        }

        public override void Move()
        {
            System.Diagnostics.Debug.WriteLine("--Верблюд идет по пескам пустыни");
        }
        public string Cry
        {
            set { Noise = value; }
            get { return Noise; }
        }
    }
}
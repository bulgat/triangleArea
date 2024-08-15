using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TriangleArea.Models.adapter;

namespace TriangleArea.Models
{
    public class Beast:Basa<int>, IAnimal
    {
        private string SuperName;
        public Beast(string name) {
            this.SuperName = name;
        }
        public virtual void Move()
        {
            System.Diagnostics.Debug.WriteLine(this.Id,"-Beast по пескам пустыни = "+ this.SuperName);
        }
    }
}
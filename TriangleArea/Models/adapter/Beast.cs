using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Beast:IAnimal
    {
        private string SuperName;
        public Beast(string name) {
            this.SuperName = name;
        }
        public virtual void Move()
        {
            System.Diagnostics.Debug.WriteLine("-Beast идет по пескам пустыни = "+ this.SuperName);
        }
    }
}
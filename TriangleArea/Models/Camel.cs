using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Camel: IAnimal
    {
        public void Move()
        {
            System.Diagnostics.Debug.WriteLine("--Верблюд идет по пескам пустыни");
        }
    }
}
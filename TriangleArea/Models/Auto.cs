using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Auto : ITransport
    {
        protected string Name= "Mers";

        public Auto()
        {
            this.Name = "SuperMers";
        }
        public void Drive()
        {
            System.Diagnostics.Debug.WriteLine("--Машина едет по дороге");
        }
    }
}
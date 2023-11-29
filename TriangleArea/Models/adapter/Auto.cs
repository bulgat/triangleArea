using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TriangleArea.Models.adapter;
using static TriangleArea.Models.AdapterProgram;

namespace TriangleArea.Models
{
    public class Auto : AbstractAuto,ITransport,IMoto, IAdapter
    {
        protected string Name= "Mers";

        public Auto() {
            CheckKey();
        }
        public void Drive()
        {
            System.Diagnostics.Debug.WriteLine("--Машина едет по дороге");
        }
        public void Drive(string Key)
        { 
        
        }

        public void SuperMove()
        {
            throw new NotImplementedException();
        }

        string IAdapter.Name()
        {
            throw new NotImplementedException();
        }
    }
}
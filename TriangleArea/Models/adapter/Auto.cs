using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TriangleArea.Models.adapter;

namespace TriangleArea.Models
{
    public class Auto : AbstractAuto,ITransport,IMoto
    {
        protected string Name= "Mers";
        public event EventHandler Zavod;

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
            Zavod.Invoke(this, EventArgs.Empty);
        }
    }
}
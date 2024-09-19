using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using TriangleArea.Models.adapter;
using static TriangleArea.Models.AdapterProgram;

namespace TriangleArea.Models
{
    public class Auto : AbstractAuto,ITransport,IMoto, IAdapter
    {
        protected string Name= "Mers";
        [Description("SSuper Drive"), Category("SAppearance")]
        public string SuperName {get; set;}
        public event EventHandler Zavod;
        [Description("Super Auto")]
        public Auto() {
            CheckKey();
            
        }
        [Description("Super Drive"), Category("Appearance")]
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

        string IAdapter.Name()
        {
            throw new NotImplementedException();
        }
    }
}
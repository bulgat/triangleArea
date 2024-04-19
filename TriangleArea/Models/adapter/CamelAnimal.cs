using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static TriangleArea.Models.CamelAnimal;

namespace TriangleArea.Models
{
    public class CamelAnimal : Beast, IAnimal, ICamelAnimal
    { 
        public string Noise;
        private string Name;
        public CamelAnimal(string name) : base(name)
        {

            this.Name = name;
        }

        public CamelAnimal(string name, params int[] argument_ar) : this(name)
        {
            
   
        }

        public override void Move()
        {
            System.Diagnostics.Debug.WriteLine("--Верблюд идет по пескам пустыни");
        }

        public void Kick(int Num)
        {
            //throw new NotImplementedException();
            System.Diagnostics.Debug.WriteLine("--Верблюд идет по пескам пустыни");
        }

        public string Cry
        {
            set { Noise = value; }
            get { return Noise; }
        }
        public string Speech { set; get; }
        public interface ICamelAnimal
        {
            void Kick(int Num);
        }
    }
    
}
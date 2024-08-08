using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Tourist:IBrute<Auto>
    {
        public string Name;
        public Tourist(string name) {
        this.Name = name;
        }
        public void Travel()
        {
            System.Diagnostics.Debug.WriteLine("Tourist");
        }
    }
}
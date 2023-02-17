using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class Tourist:IBrute<Auto>
    {
        public void Travel()
        {
            System.Diagnostics.Debug.WriteLine("Tourist");
        }
    }
}
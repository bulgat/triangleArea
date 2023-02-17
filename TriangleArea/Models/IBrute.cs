using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public interface IBrute<T> where T:Auto
    {
        void Travel();
    }
}
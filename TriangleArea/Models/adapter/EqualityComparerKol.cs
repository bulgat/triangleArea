using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models.adapter
{
    public class EqualityComparerKol : IEqualityComparer<string>
    {
        /*
        public new bool Equals(object x, object y)
        {
            return true;
        }
        */
        public bool Equals(string x, string y)
        {
            return false;
        }
        /*
        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
        */
        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}
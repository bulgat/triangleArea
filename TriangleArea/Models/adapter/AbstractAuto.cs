using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models.adapter
{
    public abstract class AbstractAuto
    {
        public virtual void CheckKey()
        {
            System.Diagnostics.Debug.WriteLine("___CheckKey___");
        }
    }
}
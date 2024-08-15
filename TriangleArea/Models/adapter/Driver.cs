using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TriangleArea.Models.adapter;

namespace TriangleArea.Models
{
    public class Driver:Basa<Guid>
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
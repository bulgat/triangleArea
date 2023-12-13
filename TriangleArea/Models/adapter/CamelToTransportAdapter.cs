﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleArea.Models
{
    public class CamelToTransportAdapter : ITransport
    {
        CamelAnimal camel;
        public CamelToTransportAdapter(CamelAnimal c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }

        public void SuperMove()
        {
            throw new NotImplementedException();
        }
    }
}
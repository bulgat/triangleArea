using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TriangleArea.Models.adapter
{
    public class Mersedes
    {
        static IContainer container;
        public Mersedes()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Auto>();
            builder.RegisterType<Beast>().UsingConstructor(typeof(string))
    .WithParameter(new NamedParameter("name","Alien")).PropertiesAutowired(); ;
            /*
            builder.RegisterSource(
  new Auto());
*/
            container = builder.Build();
        
        }
        public IContainer GetAutofacContainer()
        {
            return container;
        }
        
    }
}
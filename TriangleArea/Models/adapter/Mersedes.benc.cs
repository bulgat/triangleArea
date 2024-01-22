using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
    .WithParameter(new NamedParameter("name","Animal")).PropertiesAutowired(); ;
      
            var queriesAssemblyName = Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly();

            System.Diagnostics.Debug.WriteLine(queriesAssemblyName.GetName().Name+"  name = " + queriesAssemblyName.GetName());

            var queriesAssembly = Assembly.Load(queriesAssemblyName.GetName());

            builder.RegisterAssemblyTypes(queriesAssembly)
             .Where(t => t.Name.EndsWith("Animal"))
             .AsImplementedInterfaces().AsSelf();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var types = assemblies.Where(t =>t.GetName().Name.EndsWith("Animal")).FirstOrDefault();


            container = builder.Build();
        
System.Diagnostics.Debug.WriteLine("00==="+ container.IsRegistered(typeof(Auto)));
            System.Diagnostics.Debug.WriteLine("01===" + container.IsRegistered(typeof(CamelAnimal)));

            System.Diagnostics.Debug.WriteLine("02===" + types);
        }
 
        public IContainer GetAutofacContainer()
        {
            return container;
        }
        
    }
}
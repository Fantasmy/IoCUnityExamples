using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

//The unity container manages the lifetime of objects of 
//all the dependencies that it resolves using lifetime managers.
//You can specify lifetime manager in 
//RegisterType() method at the time of registering type-mapping.

namespace LifetimeManagers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer()
            //       .RegisterType<ICar, BMW>(new TransientLifetimeManager());
            //
            //// TransientLifetimeManager
            ////  default lifetime manager. It creates a new object of requested type 
            //// every time you call Resolve() or ResolveAll() method.

            //var container = new UnityContainer()
            //       .RegisterType<ICar, BMW>();

            //var driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            //var driver2 = container.Resolve<Driver>();
            //driver2.RunCar();


            //
            //// ContainerControlledLifetimeManager
            //// Used when you want to create a singleton instance.
            //var container = new UnityContainer()
            //       .RegisterType<ICar, BMW>(new ContainerControlledLifetimeManager()); // unity container will create a single instance of BMW class and inject it in all the instances of Driver.

            //var driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            //var driver2 = container.Resolve<Driver>();
            //driver2.RunCar();


            //
            // HierarchicalLifetimeManager
            // same as ContainerControlledLifetimeManager except that 
            // if you create a child container then it will create 
            // its own singleton instance of registered type and 
            // will not share instance with parent container.
            var container = new UnityContainer()
                   .RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());

            var childContainer = container.CreateChildContainer();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            var driver3 = childContainer.Resolve<Driver>();
            driver3.RunCar();

            var driver4 = childContainer.Resolve<Driver>();
            driver4.RunCar();

            // container and childContainer have their own singleton instance of BMW.

        }
    }
}

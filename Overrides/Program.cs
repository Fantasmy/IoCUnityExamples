using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace Overrides
{
    public class Program
    {
        static void Main(string[] args)
        {

            //
            //// ParameterOverride
            //var container = new UnityContainer()
            //    .RegisterType<ICar, BMW>();

            //var driver1 = container.Resolve<Driver>(); // Injects registered ICar type
            //driver1.RunCar();

            //// Override registered ICar type 
            //// The first parameter is the name of the constructor parameter 
            //// and second is the value of a parameter.
            //var driver2 = container.Resolve<Driver>(new ParameterOverride("car", new Ford()));
            //driver2.RunCar();


            // 
            //// Override Multiple Parameters
            //var container = new UnityContainer()
            //    .RegisterType<ICar, BMW>();

            //var driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            //var driver2 = container.Resolve<Driver>(new ResolverOverride[] {
            //    new ParameterOverride("car1", new Ford()),
            //    new ParameterOverride("car2", new BMW()),
            //    new ParameterOverride("car3", new Audi())
            //});
            //driver2.RunCar();

            //
            //// PropertyOverride
            //// You can override registered property injection 
            //// and provide different property value when you resolve it.
            //var container = new UnityContainer();

            ////Configure default value of Car property
            //container.RegisterType<Driver>(new InjectionProperty("Car", new BMW()));

            //var driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            ////Override default value of Car property
            //var driver2 = container.Resolve<Driver>( 
            //    new PropertyOverride("Car", new Audi())
            //);
            //driver2.RunCar();

            //
            // DependencyOverride
            // can be used to override the type of dependency and its value, 
            // irrespective of whether dependencies are provided through 
            // constructor, property or a method.
            // You can override registered method injection and 
            // provide different parameter value when you resolve it
            var container = new UnityContainer()
                .RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            //Override dependency
            var driver2 = container.Resolve<Driver>(new DependencyOverride<ICar>(new Audi()));
            driver2.RunCar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace PropertyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {

            //// Dependency attribute
            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();

            ////
            //// Named Mapping
            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();

            //
            // Run-time Configuration
            var container = new UnityContainer();

            //run-time configuration
            // registers Driver class by passing an object of InjectionProperty 
            //that specifies the property name "Car" and the BMW object as a value
            container.RegisterType<Driver>(new InjectionProperty("Car", new BMW())); 

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}

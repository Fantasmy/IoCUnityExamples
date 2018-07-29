using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

// Method injection in unity can be implemented in two ways:
// 1-Using[InjectionMethod] attribute
// 2-Run-time configuration

namespace MethodInjection
{
    public class Program
    {
        static void Main(string[] args)
        {

            //// Method Injection
            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();

            //
            // Run-time Configuration
            // Pass an object of InjectionMethod class in the RegisterType() method 
            // to specify a method name and parameter value.
            var container = new UnityContainer();

            ////run-time configuration
            //container.RegisterType<Driver>(new InjectionMethod("UseCar", new Audi()));

            //to specify multiple parameters values
            // registers Driver class by passing an object of InjectionMethod 
            // that specifies the method name and parameter value.
            container.RegisterType<Driver>(new InjectionMethod("UseCar", new object[] { new Audi() }));

            // unity container will inject an object of Audi 
            // when we resolve it using container.Resolve<Driver>().
            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}

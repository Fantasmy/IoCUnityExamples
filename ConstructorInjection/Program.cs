using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contructor injection

            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();


            //////
            ////// Multiple Parameters
            ////var container = new UnityContainer();

            ////container.RegisterType<ICar, Audi>();
            ////container.RegisterType<ICarKey, AudiKey>();

            ////var driver = container.Resolve<Driver>();
            ////driver.RunCar();

            ////
            //// Multiple constructors

            //var container = new UnityContainer();
            //container.RegisterType<Driver>(new InjectionConstructor(new Ford()));

            //////or 

            ////container.RegisterType<ICar, Ford>();
            ////container.RegisterType<Driver>(new InjectionConstructor(container.Resolve<ICar>()));

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();


            //
            // Primitive Type Parameter

            var container = new UnityContainer();

            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));

            var driver = container.Resolve<Driver>(); // Injects Audi and Steve
            driver.RunCar();
        }
    }
}

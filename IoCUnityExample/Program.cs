using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace IoCUnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(new BMW());

            //driver.RunCar();

            //IUnityContainer container = new UnityContainer();

            ////we register BMW type with ICar
            //container.RegisterType<ICar, BMW>(); // Map ICar with BMW 

            ////Resolves dependencies and returns Driver object 
            ////automatically creates and injects BMW object in it
            //Driver drv = container.Resolve<Driver>();

            //drv.RunCar();

            //Unity container will create new object and inject it 
            //every time whenever we resolve the same type.
            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //Driver driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            //Driver driver2 = container.Resolve<Driver>();
            //driver2.RunCar();


            //
            //Multiple registrations
            //ICar is mapped to both BMW and Audi. But, 
            //unity will inject Audi every time because 
            //it has been registered last.

            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>();

            //Driver driver = container.Resolve<Driver>();
            //driver.RunCar();


            //
            // Register Named Type

            //IUnityContainer container = new UnityContainer();
            //// mapped ICar with both BMW and Audi class. 
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //ICar bmw = container.Resolve<ICar>();  // return BMW object
            //ICar audi = container.Resolve<ICar>("LuxuryCar"); // return Audi object

            //
            // 
            //var container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //// Register Driver type            
            //container.RegisterType<Driver>("LuxuryCarDriver",
            //                new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            //Driver driver1 = container.Resolve<Driver>();// injects BMW
            //driver1.RunCar();

            //Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            //driver2.RunCar();

            //
            // Register Instance
            // Unity container will not create a new instance for the 
            // registered type and will use the same instance every time.

            var container = new UnityContainer();
            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi);

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();  // Running Audi - 1 Mile
            driver1.RunCar(); // Running Audi - 2 Mile

            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar(); // Running Audi - 3 Mile

        }
    }
}

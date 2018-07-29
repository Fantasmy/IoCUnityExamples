using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace MethodInjection
{
    public class Driver
    {
        private ICar _car = null;

        public Driver()
        {
        }

        public void UseCar(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }


        ////
        //// [InjectionMethod] Attribute
        //// we need to tell the unity container 
        //// which method should be used for dependency injection.
        //// we need to decorate a method with the [InjectionMethod] attribute 
        //private ICar _car = null;

        //public Driver()
        //{
        //}
        //[InjectionMethod]
        //public void UseCar(ICar car)
        //{
        //    _car = car;
        //}

        //public void RunCar()
        //{
        //    Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        //}

    }
}

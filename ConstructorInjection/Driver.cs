using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace ConstructorInjection
{
    public class Driver
    {
        //private ICar _car = null;
        //private ICarKey _key = null;

        //public Driver(ICar car, ICarKey key)
        //{
        //    _car = car;
        //    _key = key;
        //}

        ////public void RunCar()
        ////{
        ////    Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        ////}


        //// Multiple parameters
        //public void RunCar()
        //{
        //    Console.WriteLine("Running {0} with {1} - {2} mile ", _car.GetType().Name, _key.GetType().Name, _car.Run());
        //}


        ////
        //// Multiple onstructors
        //// use [InjectionConstructor] attribute to indicate 
        //// which constructor to use for construction injection.
        //// You can configure the same thing as above at run time 
        //// instead of applying [InjectionConstructor] attribute 
        //// by passing InjectionConstructor in the RegisterType() method

        //private ICar _car = null;

        ////[InjectionConstructor]
        //public Driver(ICar car)
        //{
        //    _car = car;
        //}

        //public Driver(string name)
        //{
        //}

        //public void RunCar()
        //{
        //    Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        //}


        //
        // Primitive Type Parameter
        // Pass an object of InjectionConstructor class in the 
        // RegisterType() method to specify a multiple parameters values.


        private ICar _car = null;
        private string _name = string.Empty;

        public Driver(ICar car, string driverName)
        {
            _car = car;
            _name = driverName;
        }

        public void RunCar()
        {
            Console.WriteLine("{0} is running {1} - {2} mile ",
                            _name, _car.GetType().Name, _car.Run());
        }

    }
}

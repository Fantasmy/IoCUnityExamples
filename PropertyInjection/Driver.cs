using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

// Property injection in unity container can be implemented in two ways:
// 1-Using[Dependency] attribute
// 2-Run-time configuration

namespace PropertyInjection
{
    public class Driver
    {
        //public Driver()
        //{
        //}

        //[Dependency]
        //public ICar Car { get; set; }

        //public void RunCar()
        //{
        //    Console.WriteLine("Running {0} - {1} mile ",
        //                        this.Car.GetType().Name, this.Car.Run());
        //}


        ////
        //// Dependency attribute
        //public Driver()
        //{
        //}

        //[Dependency]
        //public ICar Car { get; set; }

        //public void RunCar()
        //{
        //    Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
        //}

        //
        // Named Mapping
        public Driver()
        {
        }

        [Dependency("LuxuryCar")]
        public ICar Car { get; set; }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
        }

    }
}

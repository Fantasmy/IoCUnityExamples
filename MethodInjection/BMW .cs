﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjection
{
    public class BMW : ICar
    {
        private int _miles = 5;

        public int Run()
        {
            return ++_miles;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace opgave_til_p1_programmor
{
    class Furniture
    {
        protected int chash = 5000;
    }

    class Chair : Furniture
    {
        protected int chairPrice = 1500;
    }

    class Computer : Chair
    {
        protected int computerPrice = 3000;
    }

}
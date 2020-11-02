using System;

namespace opgave_til_p1_programmor
{
    class Bil
    {
        public void MotorStart()
        {
            Console.WriteLine("Motoren er Startet.");
        }

        public void MotorSluk()
        {
            Console.WriteLine("Motoren er Slukket.");
        }

        public void FillGas1(double liters)
        {
            Console.WriteLine($"Filed tank with: {liters} liters.");
        }

        public void FillGas2(double liters, bool isDiesel)
        {
            string fuel;

            if (isDiesel == true)
            {
                fuel = "Diesel";
            }
            else
            {
                fuel = "Benzin";
            }
            
            Console.WriteLine($"Filed tank with: {liters} liters of {fuel}.");
        }
        
        public void RemainingGas(double gas)
        {
            Console.WriteLine($"You have {gas} liters left");
        }    
    }
}

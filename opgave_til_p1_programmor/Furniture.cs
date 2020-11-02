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
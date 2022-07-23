using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WitchSaga saga = new WitchSaga();
            saga.Given(10, 12);
            saga.Given(13, 17);
            Console.WriteLine(saga.FindAverage());
            
        }
    }
}

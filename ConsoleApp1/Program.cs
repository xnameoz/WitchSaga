using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WitchSaga saga = new WitchSaga();
            saga.Given(13, 14);
            saga.Given(13, 18);
            saga.FindAverage();
            Console.WriteLine(saga.Average);
            
        }
    }
}

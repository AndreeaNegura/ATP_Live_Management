using System;
using ITF_LiveManagement;
namespace testClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var tennisEvent = new tennisCompetition();
            tennisEvent.betradarId = "1234";
            tennisEvent.playerOne = "1234";

            Console.WriteLine(tennisEvent.betradarId);
        }
    }
}

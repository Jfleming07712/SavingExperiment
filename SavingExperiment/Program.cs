using System;

namespace SavingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new Bag()
            {
                Name1 = "Fred",
                Full = true
            };

            var gameContext = new GameContext()
            {
                Name = "John",
                Age = 33,
                Bag = bag
            };


            // Trying to save the gameContext




            Console.WriteLine(gameContext.Name + "  " + gameContext.Age + "  " + gameContext.Bag + "  " + gameContext.Bag.Name1 + "  " + gameContext.Bag.Full);

        }
    }
}

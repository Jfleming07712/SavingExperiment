using Newtonsoft.Json;
using System;
using System.IO;


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

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"c:\CelestialTravels\Save\GameSave.json", JsonConvert.SerializeObject(gameContext));

            // Trying to Load the saved gameContext

            // read file into a string and deserialize JSON to a type
            GameContext gameContextLoad = JsonConvert.DeserializeObject<GameContext>(File.ReadAllText(@"c:\CelestialTravels\Save\GameSave.json"));




            Console.WriteLine(gameContextLoad.Name + "  " + gameContextLoad.Age + "  " + gameContextLoad.Bag + "  " + gameContextLoad.Bag.Name1 + "  " + gameContextLoad.Bag.Full);

        }
    }
}

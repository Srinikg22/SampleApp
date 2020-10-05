using System;
using System.Collections;

namespace CricketGame
{
    class Program : ParallelProgramming
    {
        static void Main(string[] args)
        {
            //Players players = new Players();

            //Action DisplayPlayers = () =>
            //{
            //    for (int i=0; i < players.PlayersList.Length; i++)
            //    {
            //        Console.WriteLine(players.PlayersList[i]);
            //    }
            //};

            //var task = Task.Factory.StartNew(() => DisplayPlayers());

            //Console.ReadLine();

            ParallelProgramming parallelPrg = new ParallelProgramming();

            IEnumerable prodDesc = parallelPrg.GetDataFromDB();

            parallelPrg.InsertIntoDBValues(prodDesc);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main()
        {
            List<int> firstPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[0] > secondPlayer[0])  
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                   
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            PrintWinner(firstPlayer, secondPlayer);
        }
        static void PrintWinner(List<int> player1, List<int> player2)
        {
            int sum = 0;
            string winner = "";
            if (player1.Count > 0)
            {
                foreach (var item in player1)
                {
                    sum += item;
                }
                winner = "First player";
            }
            else
            {
                foreach (var item in player2)
                {
                    sum += item;
                }
                winner = "Second player";
            }
            Console.WriteLine($"{winner} wins! Sum: {sum}");
        }
    }
}

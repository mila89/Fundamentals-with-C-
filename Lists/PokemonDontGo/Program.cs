using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main()
        {
            List<int> pokemonList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int commandIndex = 0;
            int sum = 0;
            bool isRemoved = false;
            int changedValue = 0;
            
            while (pokemonList.Count > 0)
            {
                commandIndex = int.Parse(Console.ReadLine());
                if (commandIndex < 0)
                {
                    commandIndex = 0;
                    sum += pokemonList[commandIndex];
                    changedValue = pokemonList[commandIndex];
                    pokemonList.RemoveAt(commandIndex);
                    pokemonList.Insert(0, pokemonList[pokemonList.Count - 1]);
                    isRemoved = true;
                }
                else if (commandIndex >= pokemonList.Count)
                {
                    commandIndex = pokemonList.Count - 1;
                    sum += pokemonList[commandIndex];
                    changedValue = pokemonList[commandIndex];
                    pokemonList.RemoveAt(commandIndex);
                    pokemonList.Add(pokemonList[0]);
                    isRemoved = true;
                }
                else
                {
                    sum += pokemonList[commandIndex];
                    changedValue = pokemonList[commandIndex];
                }

                for (int i = 0; i < pokemonList.Count; i++)
                {
                    if (i == commandIndex && !isRemoved)
                        continue;
                    if (pokemonList[i] > changedValue)
                    {
                        pokemonList[i] -= changedValue;
                    }
                    else
                    {
                        pokemonList[i] += changedValue;
                    }
                }
                if (!isRemoved)
                    pokemonList.RemoveAt(commandIndex);
                isRemoved = false;
            }
            Console.WriteLine(sum);
        }
    }
}

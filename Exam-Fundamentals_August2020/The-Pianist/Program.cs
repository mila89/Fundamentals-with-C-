using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<PianoPieces> listPieces = new List<PianoPieces>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                PianoPieces currentPiece = new PianoPieces();
                if (!IsExist(listPieces, input[0]))
                {
                    currentPiece.Name = input[0];
                    currentPiece.Composer = input[1];
                    currentPiece.Key = input[2];
                    listPieces.Add(currentPiece);
                }
            }

            string inputCommand = Console.ReadLine();
            while (inputCommand != "Stop")
            {
                PianoPieces curPiece = new PianoPieces();
                string[] command = inputCommand.Split("|");
                string currentCommand = command[0];
                string pieceName = command[1];
                if (currentCommand.StartsWith("Add"))
                {
                    if (IsExist(listPieces, pieceName))
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    else
                    {
                        curPiece.Name = pieceName;
                        curPiece.Composer = command[2];
                        curPiece.Key = command[3];
                        listPieces.Add(curPiece);
                        Console.WriteLine($"{pieceName} by {curPiece.Composer} in {curPiece.Key} added to the collection!");
                    }

                }
                else if (currentCommand.StartsWith("Remove"))
                {
                    if (IsExist(listPieces, pieceName))
                    {
                        listPieces.RemoveAll(x => x.Name == pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                }
                else if (currentCommand.StartsWith("ChangeKey"))
                {
                    if (IsExist(listPieces, pieceName))
                    {
                        listPieces = ChangePiece(listPieces, pieceName, command[2]);
                        Console.WriteLine($"Changed the key of {pieceName} to {command[2]}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                }
                    inputCommand = Console.ReadLine();
                
            }

            foreach (var item in listPieces.OrderBy(x=>x.Name).ThenBy(x=>x.Composer))
            {
                Console.WriteLine($"{item.Name} -> Composer: {item.Composer}, Key: {item.Key}");
            }
            static List<PianoPieces> ChangePiece(List<PianoPieces> list, string name, string key)
            {
                foreach (var item in list)
                {
                    if (item.Name == name)
                    {
                        item.Key = key;
                        return list;
                    }
                }
                return list;
            }
            static bool IsExist(List<PianoPieces> list, string name)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == name)
                        return true;
                }
                return false;
            }
        }
    }

    class PianoPieces
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}

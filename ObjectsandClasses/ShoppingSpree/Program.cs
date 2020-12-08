using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPerson = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] inputProduct = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> listPeople = new List<Person>();
            List<Product> productList = new List<Product>();
            for (int i = 0; i < inputPerson.Length; i++)
            {
                string[] dataPerson = inputPerson[i].Split("=").ToArray();
                string name = dataPerson[0];
                int money = int.Parse(dataPerson[1]);
                Person currentPerson = new Person(name, money);
                listPeople.Add(currentPerson);
            }
            for (int i = 0; i < inputProduct.Length; i++)
            {
                string[] dataProduct = inputProduct[i].Split("=").ToArray();
                string name = dataProduct[0];
                int cost = int.Parse(dataProduct[1]);
                Product currentProduct = new Product(name,cost);
                productList.Add(currentProduct);
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                string commandName = command[0];
                string purchaseProduct = command[1];
                int index = listPeople.FindIndex(x => x.Name == commandName);
                int indexProduct = productList.FindIndex(x => x.Name == purchaseProduct);
                if (productList[indexProduct].Cost > listPeople[index].Money)
                    Console.WriteLine($"{commandName} can't afford {purchaseProduct}");
                else
                {
                    listPeople[index].Bag.Add(productList[indexProduct]);
                    listPeople[index].Money -= productList[indexProduct].Cost;
                    Console.WriteLine($"{commandName} bought {purchaseProduct}");
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < listPeople.Count; i++)
            {
                Console.Write($"{listPeople[i].Name} - ");
                if (listPeople[i].Bag.Count == 0)
                    Console.WriteLine("Nothing bought");
                else
                {
                    for (int j = 0; j < listPeople[i].Bag.Count; j++)
                    {
                        if (j == listPeople[i].Bag.Count - 1)
                            Console.Write($"{listPeople[i].Bag[j].Name}");
                        else
                            Console.Write($"{listPeople[i].Bag[j].Name}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Product
    {
        public Product()
        {

        }
        public Product(string name, int amount)
        {
            this.Name = name;
            this.Cost = amount;
        }
        public string Name { get; set; }
        public int Cost { get; set; }
    }

    class Person
    {
        public Person(string name, int amount)
        {
            this.Name = name;
            this.Money = amount;
            List <Product> bag= new List<Product>();
            this.Bag = bag;
        }
        public string Name{ get; set; }

        public int Money { get; set; }
        public List<Product> Bag { get; set; }
    }
}

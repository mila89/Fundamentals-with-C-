using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());
            Article book = new Article();
            book.Title = input[0];
            book.Content = input[1];
            book.Autor = input[2];
            for (int i = 0; i < n; i++)
            {
                List<string> commands= Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (commands[0])
                {
                    case "Edit":
                        book.Content = commands[1];
                        break;
                    case "ChangeAuthor":
                        book.Autor = commands[1];
                        break;
                    case "Rename":
                        book.Title = commands[1];
                        break;
                }
            }
            Console.WriteLine(book.ToString()); 
        }

        class Article
        {
            public Article() { }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Autor { get; set; }

            public void Edit(string text)
            {
                this.Content = text;
            }
            public void ChangeAuthor(string name)
            {
                this.Autor = name;
            }
            public void Rename(string title)
            {
                this.Title = title;
            }
            public string ToString()
            {
                return ($"{this.Title} - {this.Content}: {this.Autor}");
            }
        }
    }
}

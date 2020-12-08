using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> books = new List<Article>();
            
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Article book = new Article();
                book.Title = input[0];
                book.Content = input[1];
                book.Autor = input[2];
                books.Add(book);
            }
            string propertyWord = Console.ReadLine();
            switch (propertyWord)
            {
                case "title":
                    books= books.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    books=books.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    books=books.OrderBy(a => a.Autor).ToList();
                    break;
            }
            for (int i=0; i<books.Count; i++)
            {
                Console.WriteLine(books[i].ToString());
            }
        }
    }
    class Article
    {
        public Article() { }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public string ToString()
        {
            return ($"{this.Title} - {this.Content}: {this.Autor}");
        }
    }

}

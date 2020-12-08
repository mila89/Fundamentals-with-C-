using System;

namespace HTML
{
    class Program
    {
        static void Main()
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {articleTitle}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {articleContent}");
            Console.WriteLine("</article>");
            string input= Console.ReadLine();
            while (input!= "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {input}");
                Console.WriteLine("</div>");
                input = Console.ReadLine();
            }
        }
    }
}

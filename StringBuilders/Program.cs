using System;
using StringBuilders.Entities;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do 
              terminal
            */

            Coment c1 = new Coment("Have a nice trip!");
            Coment c2 = new Coment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("01/04/2022 20:43:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Coment c3 = new Coment("Good night");
            Coment c4 = new Coment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("01/04/2022 23:14:19"),
                "Good Night guys",
                "See you tomorrow",
                5);

            p1.AddComment(c3);
            p1.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadLine();

        }
    }
}

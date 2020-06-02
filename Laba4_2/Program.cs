using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Laba4_2
{
    
    class Program
    {
        static void Main(string[] args)
        {



            var cars = new List<Cars>()
            {
                new Cars (){mark = "bmw",numbers = 123123,colors = "red", owner = "Glek" },
                new Cars (){mark = "audi",numbers = 123123,colors = "blue", owner = "Petro" },
                new Cars (){mark = "bmw",numbers = 123123,colors = "red", owner = "Glek" },
                new Cars (){mark = "audi",numbers = 123123,colors = "blue", owner = "Glek" },
                new Cars (){mark = "bmw", numbers = 123123,colors = "red", owner = "Vasya" },
                new Cars (){mark = "audi",numbers = 123123,colors = "blue", owner = "Glek" },



            };

            foreach(Cars car in cars)
            {
                Console.Write(car.mark+"\t" +car.numbers+"\t"+car.colors+"\t"+car.owner+"\n");
            }


            Console.WriteLine("Mark / color");
            string s = Console.ReadLine();
            Console.WriteLine("Задайте колір або марку машини,щоб отримати дані про власника");


            string s1 = Console.ReadLine();
           
            switch (s)
            {
            case "mark":
            case "Mark":
                    foreach (Cars c in cars)
            {
                if (c.mark == s1)
                {
                    Console.Write("\t" + "Owner");
                    Console.WriteLine("\t" + c.owner);
                }

            }
                    break;
                case "color":
                case "Color":
                    foreach (Cars c in cars)
            {
                if (c.colors == s1)
                {
                    Console.Write("\t" + "Owner");
                    Console.WriteLine("\t" + c.owner);
                }
            }
                    break;
        }

        }
    }
}
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Howdy Y'all!!"); 
            Console.ReadKey(); //What happens if you run the app without this line?- If I run the app without this line then the console prints out "Howdy Y'all".

            Console.WriteLine("Please enter your name and press enter");
            var username = Console.ReadLine();
            Console.WriteLine($"It's nice to meet you {username}.");
            Console.ReadLine();

            Console.WriteLine($"Hey {username}, what's your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {favColor} triceratops?");
            Console.ReadLine();
            //var animals = new string[] { "Tricertops", "Gorilla", "Corgi", "Toucan" };
            //foreach (var animal in animals)          
            //    {
            //    var numOfVowels = 0;
            //    foreach (var currentChar in animal)
            //    {
            //        if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'y')
            //        {
            //            numOfVowels++;
            //        }
            //    }
            //    if (numOfVowels >= 2)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //}

            Console.WriteLine("enter string");
            var userResponse = Console.ReadLine();
            var builder = "";

            for (int i = 0; i < userResponse.Length; i++)
            {
                var position = i + 1;
                for (int k = 0; k < position; k++)
                {
                    builder += userResponse[i];
                }
                builder += "-";
            }
            char[] charToTrim = { '-' };
            var output = builder.TrimEnd(charToTrim);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}


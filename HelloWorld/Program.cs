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
            var animals = new string[] { "Tricertops", "Gorilla", "Corgi", "Toucan" };
            foreach (var animal in animals)          
                {
                var numOfVowels = 0;
                foreach (var currentChar in animal)
                {
                    if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'y')
                    {
                        numOfVowels++;
                    }
                }
                if (numOfVowels >= 2)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}

    //     var numOfVowelsInWord = 0;
    //  foreach (var currentChar in animal)
    // {
    //(currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar 'y')
                   // {
                       // numOfVowelsInWord++;
                   // }
                //}
               // if (numOfVowelsInWord >= 2)
              //  {
                //    Console.WriteLine(animal);
             //   }
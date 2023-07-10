using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using APICaller.Cats;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Select..");
            int chooseNum = Convert.ToInt32(Console.ReadLine());
                switch (chooseNum)
                {
                    case 1:
                        GetCatBreed getCatBreed = new GetCatBreed();                    
                        Console.WriteLine("Enter limit: ");
                        int numLimit = Convert.ToInt32(Console.ReadLine());
                        await getCatBreed.BreedCaller(numLimit);

                        Console.ReadLine();
                        break;
                    case 2:
                        GetCatFacts getCatFacts = new GetCatFacts();
                        Console.WriteLine("Enter facts lenght: ");
                        int factsLenght = Convert.ToInt32(Console.ReadLine());
                        await getCatFacts.FactsCaller(factsLenght);
                   
                         Console.ReadLine();
                        break;
                default:
                        Console.WriteLine("Select meow meow");
                        break;
                }
        }
    }
}

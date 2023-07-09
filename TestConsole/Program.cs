using System;
using System.Threading.Tasks;
using APICaller;

namespace TestConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            GetCatBreed getCatBreed = new GetCatBreed();
            Console.WriteLine("Enter limit: ");
            int numLimit = Convert.ToInt32(Console.ReadLine());


            await getCatBreed.BreedCaller(numLimit);

            Console.ReadLine();
        }
    }
}

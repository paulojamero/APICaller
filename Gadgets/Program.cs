using System;
using System.Text.Json;

namespace Gadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object to represent your data
            var data = new
            {
                Name = "John Doe",
                Age = 30,
                Email = "johndoe@example.com"
            };

            // Configure the JSON serialization options
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Format the JSON with indentation
            };

            // Convert the object to JSON
            string json = JsonSerializer.Serialize(data, options);

            // Store the JSON in a string variable
            string result = json;

            // Use the result as needed
            Console.WriteLine(data.Name);
            Console.WriteLine($"age is: {data.Age}");
            Console.WriteLine(result);

            // Wait for user input before exiting (optional)
            Console.ReadLine();
        }
    }
}

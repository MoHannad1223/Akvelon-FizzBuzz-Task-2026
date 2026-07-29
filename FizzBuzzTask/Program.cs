using FizzBuzzTask.Models;

namespace FizzBuzzTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var detector = new FizzBuzzDetector();

            string? input =Console.ReadLine();


            Result result = detector.GetOverlappings(input);


            //output string
            Console.WriteLine(result.OutputString);


            Console.WriteLine();

            //count
            Console.WriteLine(result.Count);
        }
    }
}

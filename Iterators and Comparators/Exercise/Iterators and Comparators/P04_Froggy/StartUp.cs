namespace P04_Froggy
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var lake = new Lake(Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}

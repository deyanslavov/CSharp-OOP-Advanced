namespace P05_GenericCountMethodString
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            var elementToCompare = Console.ReadLine();

            Console.WriteLine(box.FindGreaterElementsCount(elementToCompare));
        }
    }
}

namespace P06_GenericCountMethodDouble
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var box = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            var elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.FindGreaterElementsCount(elementToCompare));
        }
    }
}

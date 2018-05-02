namespace P01_GenericBoxOfString
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>();
                box.Value = Console.ReadLine();
                Console.WriteLine(box);
            }
        }
    }
}

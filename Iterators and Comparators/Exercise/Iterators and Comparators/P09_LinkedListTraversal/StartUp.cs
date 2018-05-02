namespace P09_LinkedListTraversal
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var list = new MyList<int>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Add")
                {
                    list.Add(int.Parse(input[1]));
                }
                else
                {
                    list.Remove(int.Parse(input[1]));
                }
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

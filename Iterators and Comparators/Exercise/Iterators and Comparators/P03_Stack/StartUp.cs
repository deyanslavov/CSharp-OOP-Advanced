namespace P03_Stack
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var stack = new Stack<int>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var tokens = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                switch (command)
                {
                    case "Push":
                        stack.Push(tokens.Skip(1).Select(int.Parse).ToArray());
                        break;
                    case "Pop":
                        Console.WriteLine(stack.Pop());
                        break;
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

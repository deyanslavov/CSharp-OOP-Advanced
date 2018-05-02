namespace P01_ListyIterator
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var items = new ListyIterator<string>(Console.ReadLine().Split().Skip(1).ToArray());

            try
            {
                string line;
                while ((line = Console.ReadLine()) != "END")
                {
                    var tokens = line.Split();

                    switch (tokens[0])
                    {
                        case "HasNext":
                            Console.WriteLine(items.HasNext());
                            break;
                        case "Move":
                            Console.WriteLine(items.Move());
                            break;
                        case "Print":
                            items.Print();
                            break;
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

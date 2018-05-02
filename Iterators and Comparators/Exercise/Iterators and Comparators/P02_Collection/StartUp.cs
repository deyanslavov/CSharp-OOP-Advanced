namespace P02_Collection
{
    using System;
    using System.Linq;
    using System.Text;

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
                        case "PrintAll":
                            var sb = new StringBuilder();
                            foreach (var item in items)
                            {
                                sb.Append(item + " ");
                            }
                            Console.WriteLine(sb.ToString().TrimEnd());
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

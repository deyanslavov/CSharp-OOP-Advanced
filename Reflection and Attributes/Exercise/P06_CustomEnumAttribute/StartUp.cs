namespace P06_CustomEnumAttribute
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var enumTypeToBeDescribed = Console.ReadLine();


            var type = enumTypeToBeDescribed == "Rank" ? typeof(Ranks) : typeof(Suits);

            Console.WriteLine(type.GetCustomAttributes(false).First());
        }
    }
}

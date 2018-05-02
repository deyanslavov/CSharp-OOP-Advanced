namespace CreateCustomClassAttribute
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var testAttribute = typeof(Weapon);
            var atr = testAttribute.GetCustomAttributes(false).FirstOrDefault();
            WeaponAttribute a = (WeaponAttribute)atr;

            while (input != "END")
            {
                Console.WriteLine(a.PrintInfo(input));

                input = Console.ReadLine();
            }
        }
    }
}

namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var classType = typeof(BlackBoxInt);

            var boxInstance = (BlackBoxInt)Activator.CreateInstance(classType, true);

            var innerValueField = classType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);

            var allMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            string line;
            while((line = Console.ReadLine()) != "END")
            {
                var commandName = line.Split('_')[0];
                var value = int.Parse(line.Split('_')[1]);

                //var method = 
                allMethods.First(m => m.Name == commandName).Invoke(boxInstance, new object[] { value });
                sb.AppendLine(innerValueField.GetValue(boxInstance).ToString());
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

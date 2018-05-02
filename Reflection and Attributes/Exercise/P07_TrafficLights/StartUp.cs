namespace P07_TrafficLights
{
    using System;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var initialLights = Console.ReadLine().Split();
            var numberOfLightChanges = int.Parse(Console.ReadLine());
            var lastColor = initialLights.Last();

            var lightAsEnum = (Lights)Enum.Parse(typeof(Lights), lastColor);

            var sb = new StringBuilder();

            for (int i = 0; i < numberOfLightChanges; i++)
            {
                sb.AppendLine(AppendNext3Lights((int)lightAsEnum, lastColor));
                lastColor = sb.ToString().Split(new string[] { " " , Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Last();
                lightAsEnum = (Lights)Enum.Parse(typeof(Lights), lastColor);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static string AppendNext3Lights(int lightAsInt, string lastColor)
        {
            var sb = new StringBuilder();
            sb.Append(lastColor + " ");
            for (int i = 0; i < 2; i++)
            {
                var lightIntValue = GetLightValue(ref lightAsInt);
                sb.Append(GetNextLight(lightIntValue) + " ");
                lastColor = GetNextLight(lightIntValue);
            }
            return sb.ToString().TrimEnd();
        }

        private static int GetLightValue(ref int lightAsInt)
        {
            if (lightAsInt == 2)
            {
                lightAsInt = 0;
                return 0;
            }
            else if(lightAsInt == 1)
            {
                lightAsInt = 2;
                return 2;
            }
            else
            {
                lightAsInt = 1;
                return 1;
            }
        }

        private static string GetNextLight(int lightAsInt)
        {
            if (lightAsInt == 0)
            {
                return Enum.GetName(typeof(Lights), 0);
            }
            else if(lightAsInt == 1)
            {
                return Enum.GetName(typeof(Lights), 1);
            }
            else
            {
                return Enum.GetName(typeof(Lights), 2);
            }
        }
    }
}

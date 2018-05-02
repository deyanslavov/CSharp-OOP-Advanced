namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var classType = typeof(HarvestingFields);
            var allFields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            string line;
            while ((line = Console.ReadLine()) != "HARVEST")
            {
                sb.AppendLine(GetFields(allFields, line));
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static string GetFields(FieldInfo[] allFields, string line)
        {
            var sb = new StringBuilder();

            switch (line)
            {
                case "public":
                    allFields = allFields.Where(f => f.IsPublic).ToArray();
                    break;
                case "private":
                    allFields = allFields.Where(f => f.IsPrivate).ToArray();
                    break;
                case "protected":
                    allFields = allFields.Where(f => f.IsFamily).ToArray();
                    break;
            }

            foreach (var field in allFields)
            {
                var modifier = field.Attributes.ToString();
                if (field.IsFamily)
                {
                    modifier = "protected";
                }
                sb.AppendLine($"{modifier.ToLower()} {field.FieldType.Name} {field.Name}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}

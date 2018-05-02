using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fields)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {className}");

        var classType = Type.GetType(className);

        var fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public).Where(fi => fields.Contains(fi.Name));

        var hacker = new Hacker();

        foreach (FieldInfo field in fieldsInfo)
        {
            var fieldName = field.Name;
            var fieldValue = field.GetValue(hacker);

            sb.AppendLine($"{fieldName} = {fieldValue}");
        }

        return sb.ToString().TrimEnd();
    } 
}

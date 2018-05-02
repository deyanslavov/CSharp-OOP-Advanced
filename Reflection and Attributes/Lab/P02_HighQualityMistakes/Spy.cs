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

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        var sb = new StringBuilder();

        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        var privateGetters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var publicSetters = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        foreach (var field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (var privateGetter in privateGetters.Where(pg => pg.Name.StartsWith("get")))
        {
            sb.AppendLine($"{privateGetter.Name} have to be public!");
        }
        foreach (var publicSetter in publicSetters.Where(ps => ps.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicSetter.Name} have to be private!");
        }

        return sb.ToString().TrimEnd();
    }
}

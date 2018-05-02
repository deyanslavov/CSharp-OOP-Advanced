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

    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);

        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}")
            .AppendLine($"Base Class: {classType.BaseType.Name}");

        var privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var method in privateMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().TrimEnd();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        var getters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(g => g.Name.StartsWith("get"));
        var setters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(s => s.Name.StartsWith("set"));

        var sb = new StringBuilder();

        foreach (var getter in getters)
        {
            sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
        }
        foreach (var setter in setters)
        {
            sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
        }

        return sb.ToString().TrimEnd();
    }
}

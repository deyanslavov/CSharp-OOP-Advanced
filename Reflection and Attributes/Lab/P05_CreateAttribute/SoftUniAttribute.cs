using System;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple =true)]
public class SoftUniAttribute : Attribute
{
    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }
}

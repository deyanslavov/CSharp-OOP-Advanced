using System;

public class Person :IEquatable<Person>, IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public override bool Equals(object other)
    {
        return this.Equals(other as Person);
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }

    public override int GetHashCode()
    {
        return this.Age.GetHashCode() + this.Name.GetHashCode();
    }

    public bool Equals(Person other)
    {
        return other != null && this.Age == other.Age && this.Name == other.Name;
    }

    public int CompareTo(Person other)
    {
        int result = this.Name.CompareTo(other.Name);
        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }
        return result;
    }
}

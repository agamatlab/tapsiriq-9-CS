abstract class Person
{
    protected Person(string name, string surname, byte age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    protected Person() { }
    public abstract string? Name{ get; set; }
    public abstract string? Surname{ get; set; }
    public abstract byte Age{ get; set; }

    public override string ToString() => $"{Name} {Surname} {Age}";
}

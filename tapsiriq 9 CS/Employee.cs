abstract class Employee : Person
{
    public abstract string? Postion { get; set; }
    public abstract uint Salary{ get; set; }
    protected Employee() { }
    protected Employee(string name, string surname, byte age, string position, uint salary)
        : base(name, surname, age) { Postion = position; Salary = salary; }

    public override string ToString() => $"{base.ToString()}\n\t{Postion} => {Salary}";
}

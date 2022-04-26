class Manager : Employee, IUnique, IOrganize
{
    public override string ToString() => $"{base.ToString()}\n\tManager : {ID}";

    public Manager() { }
    public Manager(string name, string surname, byte age, string position, uint salary) 
        : base(name, surname, age, position, salary) { }

    public override string? Postion { get; set; }
    public override uint Salary { get; set; }
    public override string? Name { get; set; }
    public override string? Surname { get; set; }
    public override byte Age { get; set; }
    public Guid ID { get; } = Guid.NewGuid();


    public void Organize() => Console.WriteLine("Manager Organize...");
    public static uint CalculateSalaries(Employee[] employees)
    {
        uint total = default;
        foreach (var employee in employees)
            total += employee.Salary;
        return total;
    }
}

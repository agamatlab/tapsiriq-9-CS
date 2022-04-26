class CEO : Employee, IUnique, IOrganize
{
    public override string ToString() => $"{base.ToString()}\n\tCEO : {ID}";

    public Guid ID { get; } = Guid.NewGuid();
    public override string? Name { get; set; }
    public override string? Surname { get; set; }
    public override byte Age { get; set; }
    public override string? Postion { get; set; }
    public override uint Salary { get; set; }

    public CEO() { }
    protected CEO(string name, string surname, byte age, string position, uint salary)
    : base(name, surname, age, position, salary) {  }

    public void Organize() => Console.WriteLine("CEO Organizing...");
    public void MakeMeeting() => Console.WriteLine("Making Meeting...");
     // public void ChangePercentage(byte percent) 
        // Onsuz da, setter var. 
}

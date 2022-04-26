class Client : Employee, IUnique
{
    public Client(string name, string surname, byte age, string position, uint salary, string workAddress, string liveAddress) 
        : base(name, surname, age, position, salary) { WorkAddress = workAddress; LiveAddress = liveAddress; }

    public Client() { }

    public override string? Postion { get; set; }
    public override uint Salary { get; set; }
    public override string? Name { get; set; }
    public override string? Surname { get; set; }
    public override byte Age { get; set; }
    public Guid ID { get; } = Guid.NewGuid();
    public string WorkAddress { get; set; }
    public string LiveAddress { get; set; }
    public Credit? Credit { get; set; } = null;

    public static bool operator ==(Client c1, Client c2)
        => c1.ID == c2.ID;
    public static bool operator !=(Client c1, Client c2)
        => c1.ID != c2.ID;


}

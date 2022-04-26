
class Worker : Employee, IUnique
{
    public override string ToString() => $"{base.ToString()}\n\tWorker : {ID}\n\t{StartTime} => {EndTime}";
    public Worker() { }
    public Worker(string name, string surname, byte age, string position, uint salary, TimeOnly startTime, TimeOnly endTime, Operation[]? operations = null) 
        : base(name, surname, age, position, salary)
    {
        StartTime = startTime;
        EndTime = endTime;
        Operations = operations;
    }

    public override string? Postion { get; set; }
    public override string? Name { get; set; }
    public override string? Surname { get; set; }
    public override byte Age { get; set; }
    public Guid ID { get; } = Guid.NewGuid();
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public Operation[]? Operations { get; set; } = null;
    public override uint Salary { get; set; }

    public void AddOperation(Operation operation)
    {
        if (operation == null) Operations = Extra.AddElement(Operations, operation);
        else throw new ArgumentNullException();
    }

}

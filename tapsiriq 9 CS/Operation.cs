class Operation : IUnique
{
    public Guid ID { get; } = Guid.NewGuid();
    public string ProcessName { get; set; } = string.Empty;
    public DateTime Time { get; set; }
}

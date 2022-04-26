class Credit : IUnique
{
    public Credit() { }
    public Credit(uint amount, byte percent, byte months, uint payment)
    {
        Amount = amount;
        Percent = percent;
        Months = months;
        Payment = CalculatePercent(amount,percent);
    }

    public Guid ID { get; } = Guid.NewGuid();
    public uint Amount { get; set; }
    public byte Percent { get; set; }
    public byte Months { get; set; }
    public uint Payment { get; set; }


    public static uint CalculatePercent(uint amount, byte percent)
        => Convert.ToUInt32(amount + (amount * percent / 100.0));

    public override string ToString()
        => $"Credit : {ID}\n\tAmount : {Amount} + {Percent}% => {Payment}";
}

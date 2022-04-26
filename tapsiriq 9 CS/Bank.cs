class Bank
{
    public string Name{ get; set; }
    public uint Budget{ get; set; }
    public Guid ID { get; } = Guid.NewGuid();
    public Manager[]? Managers{ get; set; }
    public Worker[]? Workers{ get; set; }
    public Client[]? Clients{ get; set; }
    public CEO? CEO { get; set; }

    public int CalculateProfit()
    {
        int profit = default;
        if (Clients != null) foreach (var client in Clients)
            profit += Convert.ToInt32
                    (client.Credit.Amount * client.Credit.Percent / 100.0);

        if(Managers != null)foreach (var manager in Managers)
            profit -= Convert.ToInt32(manager.Salary);

        if (Workers != null) foreach (var worker in Workers)
            profit -= Convert.ToInt32(worker.Salary);
        profit -= Convert.ToInt32(CEO?.Salary);
        return profit;
    }

    public void ShowClientCredit(string name, string surname)
    {
        if (Clients != null) foreach (var client in Clients)
                if (client.Name == name && client.Surname == surname)
                { Console.WriteLine(client.Credit); return; }
    }

    public void ShowAllCredit()
    {
        if (Clients != null) foreach (var client in Clients)
                    Console.WriteLine(client.Credit);
    }

    public void PayCredit(Client clientIn, uint money)
    {
        if (Clients != null) foreach (var client in Clients)
                if (clientIn == client) 
                { client.Credit.Payment -= money; return; }
    }
}

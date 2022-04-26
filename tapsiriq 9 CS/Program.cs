
class Program
{

    public static string[] positions = { "Software Engineer", "Hardware Engineer", "Full-Stack Developer", "Cleaner" };

    static CEO FakerCEO()
    {
        Random rand = new Random();
        CEO ceo = new CEO()
        {
            Age = Convert.ToByte(rand.Next(18, 100)),
            Salary = (uint)(rand.Next(1000, 10000)),
            Name = Faker.NameFaker.Name(),
            Surname = Faker.NameFaker.LastName(),
            Postion = positions[rand.Next(0, 4)],
        };
        return ceo;
    }

    static Manager FakerManager()
    {
        Random rand = new Random();
        Manager manager = new Manager()
        {
            Age = Convert.ToByte(rand.Next(18, 100)),
            Salary = (uint)(rand.Next(1000, 10000)),
            Name = Faker.NameFaker.Name(),
            Surname = Faker.NameFaker.LastName(),
            Postion = positions[rand.Next(0, 4)],
        };
        return manager;
    }

    static Operation FakerOperation()
    {
        Random random = new Random();
        Operation operation = new Operation()
        {
            ProcessName = "Lending Money...",
            Time = Faker.DateTimeFaker.DateTimeBetweenYears(2020, 2023)
        };

        return operation;
    }

    static Worker FakerWorker()
    {
        Random random = new Random();
        Worker worker = new Worker()
        {
            Age = Convert.ToByte(random.Next(18, 100)),
            Salary = (uint)(random.Next(1000, 10000)),
            Name = Faker.NameFaker.Name(),
            Surname = Faker.NameFaker.LastName(),
            Postion = positions[random.Next(0, 3)],
            EndTime = new TimeOnly(09,00),
            StartTime = new TimeOnly(17, 00),
            Operations = new Operation[] { FakerOperation() }
        };
        return worker;
    }

    static Credit FakerCredit()
    {
        Random random = new Random();
        Credit credit = new Credit()
        {
            Amount = (uint)random.Next(1000, 100000),
            Percent = (byte)random.Next(1, 100),
            Months = (byte)(random.Next(1, 6) * 12),
        };

        return credit;
    }

    static Client FakerClient()
    {
        Random rand = new Random();
        Client client = new Client()
        {
            Age = Convert.ToByte(rand.Next(18, 100)),
            Salary = (uint)(rand.Next(1000, 10000)),
            Name = Faker.NameFaker.Name(),
            Surname = Faker.NameFaker.LastName(),
            Postion = positions[rand.Next(0, 4)],
            WorkAddress = Faker.LocationFaker.Street(),
            LiveAddress = Faker.LocationFaker.Street(),
            Credit = FakerCredit()
        };
        return client;
    }

    static Bank FakerBank()
    {
        Random rand = new Random();
        Bank bank = new Bank()
        {
            Name = Faker.CompanyFaker.Name(),
            Budget = (uint)rand.Next(100000, 1000000),
            CEO = FakerCEO(),
        };
        return bank;

    }

    static void Main()
    {
        Bank bank = FakerBank();
        for (int i = 0; i < 20; i++)
            bank.Clients = Extra.AddElement(bank.Clients, FakerClient());

        for (int i = 0; i < 10; i++)
            bank.Workers = Extra.AddElement(bank.Workers, FakerWorker());

        for (int i = 0; i < 5; i++)
            bank.Managers = Extra.AddElement(bank.Managers, FakerManager());
        bank.CEO = FakerCEO();

        foreach (var worker in bank.Workers)
            Console.WriteLine(worker);

        Console.ReadKey();
        Console.Clear();

        foreach (var client in bank.Clients)
            Console.WriteLine(client);

        Console.ReadKey();
        Console.Clear();

        foreach (var manager in bank.Managers)
            Console.WriteLine(manager);

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine(bank.CalculateProfit());
    }
}
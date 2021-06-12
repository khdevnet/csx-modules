#r "nuget: CommandLineParser, 2.8.0"
#r "nuget: System.Net.Http.Json, 5.0.0"
#r "nuget: AutoFixture, 4.17.0"
#r "nuget: Faker.Net, 1.5.138"

using AutoFixture;

public interface ILogger
{
    void WriteLine(string value);
}

public class ConsoleLogger : ILogger
{
    public static ConsoleLogger Instance => new ConsoleLogger();
    public void WriteLine(string value)
    {
        Console.WriteLine(value);
    }

    public void WriteHeader(string value)
    {
        Console.WriteLine("");
        Console.WriteLine("############################################");
        Console.WriteLine(value);
        Console.WriteLine("############################################");
    }
}

public class MyFixture : Fixture
{
    public MyFixture()
    {
        this.Register<string>(() => new Fixture().Create<string>().Substring(0, 10));
    }
}

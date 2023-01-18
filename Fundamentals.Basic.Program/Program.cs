class Program
{
    static async Task<int> Main(string[] args)
    {
        if (args.Length == 0)
        {
            return -1;
        }

        foreach (var arg in args)
        {
            Console.WriteLine($"The arg is: {arg}");
        }

        await Task.Delay(1000);

        Console.WriteLine($"The number of args is: {args.Length}");

        return args.Length;
    }
}

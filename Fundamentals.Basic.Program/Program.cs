class Program
{
    static void Main()
    {
        System.Collections.Generic.List<int> list = new List<int>();

        list.Add(1);
        list.Add(2);
        list.Add(3);

        foreach(int item in list)
        {
            Console.WriteLine(item);
        }
    }
}

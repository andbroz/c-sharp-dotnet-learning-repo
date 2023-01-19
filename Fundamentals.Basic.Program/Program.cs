class Program
{
    static void Main()
    {

        Point p1 = new Point(1,2);
        Point p2;

        p2 = p1;
        p2.y = 3;

        
        Console.WriteLine($"p1 is {p1.y} and p2 is {p2.y}");
      
        
    }

    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

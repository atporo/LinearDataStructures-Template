namespace DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Point<int> intPoint = new Point<int>();
            Point<double> doublePoint = new Point<double>();

            Console.WriteLine($"TYP von X: {doublePoint.x.GetType().Name}"); ;
            
        }
    }
}

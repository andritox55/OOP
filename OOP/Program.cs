namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // skapa instansen med värdet
            Circle circle = new Circle(5);

            // beräkna arean med att anropa metoden
            int area = circle.GetArea();

            Console.WriteLine(area);
        }
    }
}
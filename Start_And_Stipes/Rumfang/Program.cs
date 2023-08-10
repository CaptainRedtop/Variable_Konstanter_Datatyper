namespace Rumfang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rumfang";

            Console.WriteLine("Indtast en højde:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIndtast en længde:");
            double lenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIndtast en bredde:");
            double width = Convert.ToDouble(Console.ReadLine());
            double rumfang = height * width * lenght;
            
            Console.WriteLine($"\nRumfanget er: {rumfang}");
            Console.ReadKey();
        }
    }
}
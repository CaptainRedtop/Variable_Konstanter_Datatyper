namespace TemperaturBeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Temperatur Beregner";
            Console.WriteLine("Indtast temperatur i celsius");
            float celsius = float.Parse(Console.ReadLine());

            float fahrenheit = (celsius * 1.8F) + 32F;
            float reamur = celsius * 0.8F;

            Console.WriteLine($"\n{celsius} grader celsius er det samme som:\n{fahrenheit} grader fahrenheit\n{reamur} grader reamur");
            Console.ReadLine();
        }
    }
}
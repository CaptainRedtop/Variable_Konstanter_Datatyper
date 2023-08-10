namespace Fødselsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fødselsdag";
            //User input
            Console.Write("Hvilket år er du født?: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHvilken månede er du født i?: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPå hvilken dag blev du født?: ");
            int day = Convert.ToInt32(Console.ReadLine());

            //Calculations
            DateTime birthday = new DateTime(year, month, day);
            DateTime now = DateTime.Now;

            TimeSpan difference = now - birthday;
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            birthday = birthday.AddYears(years);
            difference = now - birthday;

            int days = (int)Math.Floor(difference.TotalDays);


            //Output
            Console.WriteLine($"\nDu er {years} år og {days} dage gammel");
            Console.ReadKey();
        }
    }
}
namespace Start_And_Stipes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6 ; i++)
            {
                Red();
                White();
            }
            Red();
            Blue();
            Console.ReadLine();

        }
        static void Red()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                for (int red = 0; red < 38; red++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\r");
            }
        }
        static void White()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                for (int white = 0; white < 38; white++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\r");
            }
        }
        static void Blue()
        {
                        Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 11; i++)
            {
                byte cursor_x = 0;
                byte cursor_y = 0;

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                for (int blue = 0; blue < 23; blue++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\r");
            }
        }
    }
}
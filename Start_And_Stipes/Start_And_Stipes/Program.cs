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
            Stars();
            Console.ReadLine();

        }
        static void Red()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                for (int red = 0; red < 32; red++)
                {
                    Console.Write("   ");
                }
                Console.WriteLine("\r");
            }
        }
        static void White()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                for (int white = 0; white < 32; white++)
                {
                    Console.Write("   ");
                }
                Console.WriteLine("\r");
            }
        }
        static void Blue()
        { 
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 11; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                for (int blue = 0; blue < 23; blue++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("\r");
            }
        }
        static void Stars()
        {
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("*       *       *       *       *       *");
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("*       *       *       *       *");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("*       *       *       *       *       *");
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("*       *       *       *       *");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("*       *       *       *       *       *");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("*       *       *       *       *");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("*       *       *       *       *       *");
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("*       *       *       *       *");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("*       *       *       *       *       *");
        }
    }
}
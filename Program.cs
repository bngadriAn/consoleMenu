using System.Security.Principal;

namespace _1003_órai_console_léptetés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write('┌');
            for (int i = 1; i <= Console.WindowWidth - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┐');
            for (int i = 1; i <= Console.WindowHeight - 2; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('│');
            }
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write('└');
            for (int i = 1; i <= Console.WindowWidth - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┘');
            for (int i = 1; i <= Console.WindowHeight - 2; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write('│');
            }

            Console.SetCursorPosition(0, 0);
            Console.ReadLine();
        }
    }
}

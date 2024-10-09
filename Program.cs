using System.Security;
using System.Security.Principal;

namespace _1003_órai_console_léptetés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int activeButton = 1;
            ConsoleKeyInfo input;
            DrawBorder();
            DrawButtons(activeButton);
            do
            {
                input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (activeButton > 1)
                        {
                            activeButton--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (activeButton < 3)
                        {
                            activeButton++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(0, Console.WindowHeight - 2);
                        Console.WriteLine($"{activeButton}. opció kiválasztva");
                        switch(activeButton)
                        {
                            case 1:
                                //draw
                                break;
                            case 2:
                                //open previously saved
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        break;
                }
                DrawButtons(activeButton);
            } while (input.Key != ConsoleKey.Escape);

        }

        static void DrawBorder()
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
            for (int i = 0; i <= Console.WindowHeight - 3; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write('│');
            }
        }

        static void DrawButtons(int activeButton)
        {
            string[] options = { "Új rajz", "Korábbi megnyitása", "Kilépés" };
            int buttonHeght = 6;
            int buttonWidth = 40;
            int verticalOffset = 5;

            int posX = (Console.WindowWidth - buttonWidth) / 2;
            int posy = (Console.WindowHeight - ((buttonHeght + verticalOffset)*options.Length)) / 2;
            posy = Math.Max(0, posy);
            for (int i = 0; i < options.Length; i++)
            {
                int buttonPosY = posy + i * (buttonHeght + verticalOffset);
                Console.SetCursorPosition(posX, buttonPosY);
                Console.Write('┌');
                for(int j = 1; j<= buttonWidth - 2; j++)
                {
                    Console.Write('─');
                }
                Console.WriteLine('┐');
                Console.SetCursorPosition(posX, buttonPosY + 1);
                Console.Write('│');
                if (i + 1 == activeButton)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else { Console.ResetColor(); }

                int buttonPadding = (buttonWidth - options[i].Length-2) / 2;
                Console.Write(new string(' ', buttonPadding) + options[i] + new string(' ', buttonWidth - options[i].Length - 2 - buttonPadding));
                Console.ResetColor();
                Console.Write('│');

                Console.SetCursorPosition(posX, buttonPosY + 2);
                Console.Write('└');
                for (int j = 1; j <= buttonWidth - 2; j++)
                {
                    Console.Write('─');
                }
                Console.Write('┘');
            }
        }
    }
}

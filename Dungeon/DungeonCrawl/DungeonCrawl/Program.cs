using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {

            int CharHpCurrent = 20;
            int CharHpFull = 100;
            int CharXpCurrent = 10;
            int CharXpFull = 100;
            int CharLevelCurrent = 1;

            int CharLeftRight = 10;
            int CharUpDown = 10;
            int Dead = 0;

            //String
            string CharName = "Jason";

            do
            {
                //DRAW GUI

                //STATS
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(" ______________________________________________________________________________________________________________________");
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Name: {0}", CharName);
                Console.SetCursorPosition(45, 1);
                Console.WriteLine("HP: {0}/{1}", CharHpCurrent, CharHpFull);
                Console.SetCursorPosition(85, 1);
                Console.WriteLine("Experience: {0}/{1}", CharXpCurrent, CharXpFull);
                Console.WriteLine("|______________________________________________________________________________________________________________________|");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("|");
                Console.SetCursorPosition(119, 1);
                Console.WriteLine("|");
                //GAME SCREEN

                for (int a = 3; a <= 27; a++)
                {
                    Console.SetCursorPosition(0, a);
                    Console.Write("|");
                    Console.SetCursorPosition(119, a);
                    Console.Write("|");
                }
                Console.WriteLine("|______________________________________________________________________________________________________________________|");

                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        CharLeftRight++;
                        Console.SetCursorPosition(CharLeftRight, CharUpDown);
                        Console.WriteLine("X");
                        break;
                    case ConsoleKey.Tab:
                        break;
                    case ConsoleKey.Clear:
                        break;
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Pause:
                        break;

                    default:
                        break;
                }

            } while (Dead == 0);

   




        }
    }
}

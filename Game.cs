using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;

namespace NadyNeUbivai
{
    internal class Game
    {
        public static void SerchAndSend(char[] chars, char[]puzzle, string word)
        {
            string tabulate = "     ";
            for (int count = 10; count > 0;)
            {
                string symbol = Console.ReadLine();

                if (symbol.Length > 1)
                {
                    Console.WriteLine("Мы так не играем!");
                    break;
                }
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == symbol[0])
                    {
                        puzzle[i] = symbol[0];
                    }
                    int checker = word.IndexOf(symbol[0]);
                    if (checker < 0)
                    {
                        count--;
                        break;
                    }
                }
                Console.Clear();
                Drawyer.Draw(count);
                Console.Write(tabulate);
                Console.WriteLine( puzzle); 
            }
            Console.Write(tabulate);
            Console.WriteLine("GameOver");
            Console.WriteLine(word);
        }
    }
}

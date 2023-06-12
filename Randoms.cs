using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Diagnostics.Tracing;

namespace NadyNeUbivai
{
    internal class Randoms
    {
        public static void Word(int b)
        {
            int a = 0;
            Random rnd = new Random();
            //рандомное число
            int value = rnd.Next(a, b);
            //слово по рандомному адрессу
            string word = File.ReadAllLines("File\\russian_nouns.txt").Skip(value - 1).First();
            //массив из чаров, слово
            char[] chars = word.ToCharArray();
            int lenght = chars.Length; 
            int k = 0;
            char[] puzzle = new char[lenght];
            foreach (char simbol in chars)
            {
                puzzle[k] = '-'; 
                k++;
            }
            Console.WriteLine(puzzle);
            Game.SerchAndSend(chars, puzzle, word );
            
        }
    }
}

using NadyNeUbivai;
using System;

namespace NadyNeUbivai
{
    class Program
    {
        public static void Main()
        {
            String line;
            int i = 0;

            StreamReader sr = new StreamReader("File\\russian_nouns.txt");
            line = sr.ReadLine();

            while (line != null)
            {
                i++;
                line = sr.ReadLine();
            }
            int value = i;
            Console.WriteLine("Всего слов: " + i.ToString());//вывел число слов максимальное
            Randoms.Word(i);

            sr.Close();

        }

    }
}
   



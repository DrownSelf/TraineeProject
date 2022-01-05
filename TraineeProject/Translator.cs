using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal static class Translator
    {
        public static string LatinConverter(int[,] translationed)
        {
            string translated = "";
            for (int i = 0; i < translationed.GetLength(0); i++)
            {
                for (int j = 0; j < translationed.GetLength(1); j++)
                    translated += char.ConvertFromUtf32(translationed[i, j] + 97);
                //int a = 5;
                //object b = a;
                //char c = (char)(int)b;
                //Console.WriteLine(c); Доп.метод
                translated += '\n';
            }
            return translated;
        }
    }
}
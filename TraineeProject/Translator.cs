using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class Translator : ITranslator
    {
        public MatrixType args { get; set; }

        public string LatinConverter()
        {
            string translated = "";
            for (int i = 0; i < args.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < args.matrix.GetLength(1); j++)
                    translated += char.ConvertFromUtf32(args.matrix[i, j] + 97);
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
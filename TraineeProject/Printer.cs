using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class MatrixIO : IOutIn
    {
        public MatrixType args { get; set; }

        public void Enter()
        {
            Console.WriteLine("Enter m: ");
            args.m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            args.n = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < args.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < args.matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", args.matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }

    internal class ValueIo<T> : IOutIn
    {
        public T value { get; set; }


        public void Print()
        {
            Console.WriteLine(value);
        }

        public void Enter()
        {
            object buffer = Console.ReadLine();
            value = (T)buffer;
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class MatrixFiller : IFiller
    {
        public MatrixType args { get; set; }


        public void Fill()
        {
            args.matrix = new int[args.n, args.m];
            var rnd = new Random();
            for (int i = 0; i < args.matrix.GetLength(0); i++)
                for (int j = 0; j < args.matrix.GetLength(1); j++)
                    args.matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

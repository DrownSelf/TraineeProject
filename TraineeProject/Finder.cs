using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class MatrixFinder : IFinder
    {
        public MatrixType args { get; set; }

        public int FindMin()
        {
            return Find(args.matrix, (compared, picked) => compared > picked);
        }

        public int FindMax()
        {
            return Find(args.matrix, (compared, picked) => compared < picked);
        }

        private int Find(int[,] translationed, Func<int,int,bool> compare)
        {
            int compared = translationed[0, 0];
            for (int row = 0; row < translationed.GetLength(0); row++)
                for (int col = 0; col < translationed.GetLength(1); col++)
                    if (compare(compared, translationed[row, col]))
                        compared = translationed[row,col];
            return compared;
        }
    }
}
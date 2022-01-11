using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class MatrixType : IWorkType
    {
        public object workType { get; set; }
        public int[,] matrix { get; set; }
        public int m { get; set; }
        public int n { get; set; }

        public void Box()
        {
            this.workType = (object)matrix;
        }

        public void UnBox()
        {
            this.matrix = (int[,])workType;
        }
    }
}

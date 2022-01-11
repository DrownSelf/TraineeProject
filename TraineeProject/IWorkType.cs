using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal interface IWorkType
    {
        object workType { get; set; }
        void Box();
        void UnBox();
    }
}

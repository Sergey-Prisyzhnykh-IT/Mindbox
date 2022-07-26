using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheArea
{
    public interface IFigure
    {
        double Area { get; }
        void ShowArea();
    }
}

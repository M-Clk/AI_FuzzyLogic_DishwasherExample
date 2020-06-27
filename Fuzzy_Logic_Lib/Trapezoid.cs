using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Lib
{
    public class Trapezoid :Shape
    {
        public override string Name => "Yamuk";
        public Trapezoid(double corner1, double corner2, double corner3, double corner4)
        {
            Corners = new List<double> { corner1, corner2, corner3, corner4 };
        }

        public override double GetDegree(double value)
        {
            if(Corners[1] <= value && Corners[2] >= value) //Yamugun dikdortgen oldugu kisimda ise derecesi 1 dir.
                return 1;
            if(Corners[1] > value) //yamugun soldaki ucgen tarafinda mi
                return (value - Corners[0]) / (Corners[1] - Corners[0]);
            else//o zaman yamugun sagdaki ucgen tarafindadir
                return (Corners[3] - value) / (Corners[3] - Corners[2]);
        }

    }
}

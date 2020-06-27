using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Lib
{
    public class Triangle :Shape
    {
        public override string Name { get => "Üçgen"; }
        public Triangle(double corner1, double corner2, double corner3)
        {
            Corners = new List<double> { corner1, corner2, corner3 };
        }

        public override double GetDegree(double value)
        {
            if(Corners[1] > value) //ucgenin sol tarafinda mi
                return (value - Corners[0]) / (Corners[1] - Corners[0]);
            else if(Corners[1] < value)//ucgenin sag tarafinda mi
                return (Corners[2] - value) / (Corners[2] - Corners[1]);
            else //o zaman ucgenin tepe noktkasidir
                return 1;
        }
    }
}

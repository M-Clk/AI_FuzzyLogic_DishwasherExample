using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy_Logic_Lib
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public double H { get; set; }
        private List<double> corners;
        public List<double> Corners
        {
            get { return corners; }
            protected set { corners = value.OrderBy(c => c).ToList(); }//koseler nasil gelirse gelsin derece hesabi icin kucukten buyuge siralayip property e esitler.
        }
        public abstract double GetDegree(double value);
    }
}

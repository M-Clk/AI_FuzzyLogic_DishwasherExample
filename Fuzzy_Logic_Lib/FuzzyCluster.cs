using System;
using System.Linq;

namespace Fuzzy_Logic_Lib
{
    public class FuzzyCluster
    {
        public MembershipFunction Function { get; private set; }
        public double OutputDegree { get; set; } = 0;
        public double Value { get; set; } = 0;
        public string Name { get; }
        public Shape FuzzyClusterShape { get; set; }
        public bool HasDegree { get => Value > FuzzyClusterShape.Corners.Min() && Value < FuzzyClusterShape.Corners.Max(); }
        public double Degree { get => HasDegree ? FuzzyClusterShape.GetDegree(Value) : 0; }
        public double MiddlePointOfCorners
        {
            get
            {
                var first = FuzzyClusterShape.Corners.FirstOrDefault() < Function.MinLimit ? Function.MinLimit : FuzzyClusterShape.Corners.FirstOrDefault();
                var last =  FuzzyClusterShape.Corners.LastOrDefault() >  Function.MaxLimit ? Function.MaxLimit : FuzzyClusterShape.Corners.LastOrDefault();
                return (first + last) / 2;
            }

        }
        public FuzzyCluster(string name, Shape fuzzyClusterShape, MembershipFunction function)
        {
            Name = name;
            FuzzyClusterShape = fuzzyClusterShape;
            Function = function;
        }
    }
}

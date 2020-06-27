using System.Collections.Generic;
using System.Linq;

namespace Fuzzy_Logic_Lib
{
    public class MembershipFunction
    {
        public double MaxLimit { get; }
        public double MinLimit { get; }

        private double _value;
        public double Value
        {
            get { return _value; }
            set
            {
                _value = value > MaxLimit ? MaxLimit : value < MinLimit ? MinLimit : value;
                FuzzyClusters.ForEach(fuzzy =>
                {
                    fuzzy.Value = _value;
                    fuzzy.FuzzyClusterShape.H = _value;
                });
            }
        }
        public string Name { get; }
        public List<FuzzyCluster> FuzzyClusters { get; set; } = new List<FuzzyCluster>();
        public MembershipFunction(string name, double minLimit, double maxLimit)
        {
            Name = name;
            MaxLimit = maxLimit;
            MinLimit = minLimit;
            Value = MinLimit;
        }
        public string GetFuzzyValueString()
        {
            var str = "";
            if(Value == 0)
                return FuzzyClusters.FirstOrDefault().Name;
            FuzzyClusters.ForEach(cluster => str += cluster.HasDegree ? $"{cluster.Name}, " : "");
            return str.Substring(0, str.Length - 2);
        }
        public string GetFuzzyOutputString()
        {
            var str = "";
            FuzzyClusters.ForEach(cluster => str += cluster.OutputDegree > 0 ? $"{cluster.Name}, " : "");
            return str.Substring(0, str.Length - 2);
        }
        public double GetWeightedAverage()
        {
            double up = 0;
            double down = 0;
            FuzzyClusters.ForEach(fuzzy =>
            {
                up += fuzzy.MiddlePointOfCorners * fuzzy.OutputDegree;
                down += fuzzy.OutputDegree;
            });
            return up / down;
        }
        public void ResetFuzzyClusters()
        {
            FuzzyClusters.ForEach(fuzzy =>
            {
                fuzzy.OutputDegree = 0;
                fuzzy.Value = 0;
            });
        }
    }
}

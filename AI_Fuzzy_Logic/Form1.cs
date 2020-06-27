using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Fuzzy_Logic_Lib;

namespace AI_Fuzzy_Logic
{
    public partial class Form1 :Form
    {


        List<MembershipFunction> inputMembershipFunctions = new List<MembershipFunction>(3);
        List<MembershipFunction> outputMembershipFunctions = new List<MembershipFunction>(3);
        public Form1()
        {
            InitializeComponent();

            lblKirlilik.Tag = lblKirlilikEtiket;
            lblMiktar.Tag = lblMiktarEtiket;
            lblHassaslik.Tag = lblHassaslikEtiket;
            FillDataGrid();

            LoadRulesForSensitive();
            LoadRulesForQuantity();
            LoadRulesForDirty();
            LoadRulesForRotateSpeed();
            LoadRulesForTime();
            LoadRulesForDetergentAmount();
        }

        void LoadRulesForSensitive()
        {
            var hassaslik = new MembershipFunction("Hassaslık", 0, 10);
            var hassaslikFuzzyClusters = new List<FuzzyCluster>
                {
                    new FuzzyCluster("Sağlam", new Trapezoid(-4, -1.5, 2, 4), hassaslik),
                    new FuzzyCluster("Orta", new Triangle(3, 5, 7), hassaslik),
                    new FuzzyCluster("Hassas", new Trapezoid(5.5, 8, 12.5, 14), hassaslik)
                };
            hassaslik.FuzzyClusters.AddRange(hassaslikFuzzyClusters);

            numHassaslik.Tag = hassaslik;
            lblHassaslik.Text = hassaslik.GetFuzzyValueString();
            inputMembershipFunctions.Add(hassaslik);
        }
        void LoadRulesForDirty()
        {
            var kirlilik = new MembershipFunction("Kirlilik", 0, 10);
            var kirlilikFuzzyClusters = new List<FuzzyCluster>
                {
                   new FuzzyCluster("Küçük", new Trapezoid(-4.5, -2.5, 2, 4.5), kirlilik),
                    new FuzzyCluster("Orta", new Triangle(3, 5, 7), kirlilik),
                    new FuzzyCluster("Büyük", new Trapezoid(5.5, 8, 12.5, 15), kirlilik)
                };
            kirlilik.FuzzyClusters.AddRange(kirlilikFuzzyClusters);

            numKirlilik.Tag = kirlilik;
            lblKirlilik.Text = kirlilik.GetFuzzyValueString();
            inputMembershipFunctions.Add(kirlilik);
        }
        void LoadRulesForQuantity()
        {
            var miktar = new MembershipFunction("Miktar", 0, 10);
            var miktarFuzzyClusters = new List<FuzzyCluster>
                {
                    new FuzzyCluster("Küçük", new Trapezoid(-4, -1.5, 2, 4), miktar),
                    new FuzzyCluster("Orta", new Triangle(3, 5, 7), miktar),
                    new FuzzyCluster("Büyük", new Trapezoid(5.5, 8, 12.5, 14), miktar)
                };
            miktar.FuzzyClusters.AddRange(miktarFuzzyClusters);

            numMiktar.Tag = miktar;
            lblMiktar.Text = miktar.GetFuzzyValueString();
            inputMembershipFunctions.Add(miktar);
        }

        void LoadRulesForTime()
        {
            var sure = new MembershipFunction("Süre", 0, 100);
            var sureFuzzyClusters = new List<FuzzyCluster>
                {
                    new FuzzyCluster("Kısa", new Trapezoid(-46.5, -25.28, 22.3, 39.9), sure),
                    new FuzzyCluster("Normal Kısa", new Triangle(22.3, 39.9, 57.5), sure),
                    new FuzzyCluster("Orta", new Triangle(39.9, 57.5, 75.1), sure),
                    new FuzzyCluster("Normal Uzun", new Triangle(57.5, 75.1, 92.7), sure),
                    new FuzzyCluster("Uzun", new Trapezoid(75, 92.7, 111.6, 130), sure)
                };
            sure.FuzzyClusters.AddRange(sureFuzzyClusters);

            outputMembershipFunctions.Add(sure);
        }
        void LoadRulesForDetergentAmount()
        {
            var detergentAmount = new MembershipFunction("Deterjan Miktarı", 0, 300);
            var detergentAmountFuzzyClusters = new List<FuzzyCluster>
                {
                    new FuzzyCluster("Çok Az", new Trapezoid(0, 0, 20, 85), detergentAmount),
                    new FuzzyCluster("Az", new Triangle(20, 85, 150), detergentAmount),
                    new FuzzyCluster("Orta", new Triangle(85, 150, 215), detergentAmount),
                    new FuzzyCluster("Fazla", new Triangle(150, 215, 280), detergentAmount),
                    new FuzzyCluster("Çok Fazla", new Trapezoid(215, 280, 300, 300), detergentAmount)
                };
            detergentAmount.FuzzyClusters.AddRange(detergentAmountFuzzyClusters);

            outputMembershipFunctions.Add(detergentAmount);
        }
        void LoadRulesForRotateSpeed()
        {
            var rotateSpeed = new MembershipFunction("Dönüş Hızı", 0, 10);
            var rotateSpeedFuzzyClusters = new List<FuzzyCluster>
                {
                    new FuzzyCluster("Hassas", new Trapezoid(5.8, -2.8, 0.5, 1.5), rotateSpeed),
                    new FuzzyCluster("Normal Hassas", new Triangle(0.5, 2.75, 5), rotateSpeed),
                    new FuzzyCluster("Orta", new Triangle(2.75, 5, 7.25), rotateSpeed),
                    new FuzzyCluster("Normal Güçlü", new Triangle(5, 7.25, 9.5), rotateSpeed),
                    new FuzzyCluster("Güçlü", new Trapezoid(8.5, 9.5, 12.8, 15.2), rotateSpeed)
                };
            rotateSpeed.FuzzyClusters.AddRange(rotateSpeedFuzzyClusters);

            outputMembershipFunctions.Add(rotateSpeed);
        }

        void LoadLastOutputResult()
        {
            var deterjanMiktari = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Deterjan Miktarı");
            var sure = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Süre");
            var donusHizi = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Dönüş Hızı");

            lblDeterjanSozelSonuc.Text = deterjanMiktari.GetFuzzyOutputString();
            lblDeterjanAgirlikliOrtalama.Text = deterjanMiktari.GetWeightedAverage().ToString("0.##");

            lblSureSozelSonuc.Text = sure.GetFuzzyOutputString();
            lblSureAgirlikliOrtalama.Text = sure.GetWeightedAverage().ToString("0.##");

            lblDonusHiziSozelSonuc.Text = donusHizi.GetFuzzyOutputString();
            lblDonusHiziAgirlikliOrtalama.Text = donusHizi.GetWeightedAverage().ToString("0.##");
        }

        void ResetOutputFunctions() => outputMembershipFunctions.ForEach(func => func.ResetFuzzyClusters());

        void CalculateRulesWithMamdani()
        {
            lbMamdani.Items.Clear();
            dgKuralTabani.MultiSelect = false;
            dgKuralTabani.MultiSelect = true;
            var dgRowIndex = 0;
            ResetOutputFunctions();
            foreach(var rulePair in RulesBase.Rules)
            {
                var inputs = rulePair.Key.Split(',');
                var outputs = rulePair.Value.Split(',');

                var hassaslik = inputMembershipFunctions.FirstOrDefault(func => func.Name == "Hassaslık").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == inputs[(int)RulesBase.InputFunctionIndexesInRuleFormat.Hassaslik]);
                var miktar = inputMembershipFunctions.FirstOrDefault(func => func.Name == "Miktar").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == inputs[(int)RulesBase.InputFunctionIndexesInRuleFormat.Miktar]);
                var kirlilik = inputMembershipFunctions.FirstOrDefault(func => func.Name == "Kirlilik").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == inputs[(int)RulesBase.InputFunctionIndexesInRuleFormat.Kirlilik]);

                if(hassaslik.HasDegree && miktar.HasDegree && kirlilik.HasDegree)
                {
                    var minDegree = Math.Min(Math.Min(hassaslik.Degree, miktar.Degree), kirlilik.Degree);
                    var donusHizi = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Dönüş Hızı").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == outputs[(int)RulesBase.OutputFunctionIndexesInRuleFormat.DonusHizi]);
                    donusHizi.OutputDegree = minDegree > donusHizi.OutputDegree ? minDegree : donusHizi.OutputDegree;

                    var sure = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Süre").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == outputs[(int)RulesBase.OutputFunctionIndexesInRuleFormat.Sure]);
                    sure.OutputDegree = minDegree > sure.OutputDegree ? minDegree : sure.OutputDegree;

                    var deterjan = outputMembershipFunctions.FirstOrDefault(func => func.Name == "Deterjan Miktarı").FuzzyClusters.FirstOrDefault(fuzzy => fuzzy.Name == outputs[(int)RulesBase.OutputFunctionIndexesInRuleFormat.DeterjanMiktari]);
                    deterjan.OutputDegree = minDegree > deterjan.OutputDegree ? minDegree : deterjan.OutputDegree;

                    lbMamdani.Items.Add(minDegree);
                    dgKuralTabani.Rows[dgRowIndex].Selected = true;
                }
                dgRowIndex++;
            }
            LoadLastOutputResult();
        }
        void FillDataGrid()
        {
            dgKuralTabani.Rows.Clear();
            foreach(var rulePair in RulesBase.Rules)
            {
                var inputs = rulePair.Key.Split(',');
                var outputs = rulePair.Value.Split(',');
                dgKuralTabani.Rows.Add(inputs.Concat(outputs).ToArray());
            }
        }

        //public PointF FindCentroid()
        //{
        //    // Add the first point at the end of the array.
        //    int num_points = Points.Length;
        //    PointF[] pts = new PointF[num_points + 1];
        //    Points.CopyTo(pts, 0);
        //    pts[num_points] = Points[0];

        //    // Find the centroid.
        //    float X = 0;
        //    float Y = 0;
        //    float second_factor;
        //    for(int i = 0; i < num_points; i++)
        //    {
        //        second_factor =
        //            pts[i].X * pts[i + 1].Y -
        //            pts[i + 1].X * pts[i].Y;
        //        X += (pts[i].X + pts[i + 1].X) * second_factor;
        //        Y += (pts[i].Y + pts[i + 1].Y) * second_factor;
        //    }

        //    // Divide by 6 times the polygon's area.
        //    float polygon_area = PolygonArea();
        //    X /= (6 * polygon_area);
        //    Y /= (6 * polygon_area);

        //    // If the values are negative, the polygon is
        //    // oriented counterclockwise so reverse the signs.
        //    if(X < 0)
        //    {
        //        X = -X;
        //        Y = -Y;
        //    }

        //    return new PointF(X, Y);
        //}

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;
            var lbl = (Label)panelGirisler.Controls.Find(numericUpDown.Name.Replace("num", "lbl"), true)[0];
            lbl.Text = numericUpDown.Value.ToString("0.##");

            var membershipFunction = inputMembershipFunctions.Find(member => member.Name == ((Label)lbl.Tag).Text);
            membershipFunction.Value = (double)numericUpDown.Value;
            lbl.Text = membershipFunction.GetFuzzyValueString();
            CalculateRulesWithMamdani();
        }
    }
}


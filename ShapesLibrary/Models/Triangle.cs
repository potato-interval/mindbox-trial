using ShapesLibrary.Interfaces;

namespace ShapesLibrary.Models
{
    public class Triangle : IMeasurable
    {
        #region Fields & Props
        private double _aSide;
        private double _bSide;
        private double _cSide;

        public double ASide
        {
            get { return _aSide; }
            set
            {
                if (value >= 0)
                    _aSide = value;
            }
        }

        public double BSide
        {
            get { return _bSide; }
            set
            {
                if (value >= 0)
                    _bSide = value;
            }
        }

        public double CSide
        {
            get
            { return _cSide; }
            set
            {
                if (value >= 0)
                    _cSide = value;
            }
        }
        #endregion

        #region Ctor
        public Triangle(double a, double b, double c)
        {
            ASide = a;
            BSide = b;
            CSide = c;
        }
        #endregion

        public double CalculateArea()
        {
            double output = -1;

            if (IsATriangle() == true)
            {
                double semiperimeter = (ASide + BSide + CSide) / 2;
                output = Math.Sqrt(semiperimeter * (semiperimeter - ASide) * (semiperimeter - BSide) * (semiperimeter - CSide));
            }

            return output;
        }

        public bool IsATriangle()
        {
            bool output = false;

            if (ASide + BSide > CSide && ASide + CSide > BSide && BSide + CSide > ASide)
            {
                output = true;
            }

            return output;
        }

        public bool IsARightAngledTriangle()
        {
            bool output = false;

            (double a, double b, double c) = SortValuesAscending();

            if (c * c == a * a + b * b)
            {
                output = true;
            }

            return output;
        }

        private (double min, double mid, double  max) SortValuesAscending()
        {
            double max = Math.Max(ASide, Math.Max(BSide, CSide));
            double min = Math.Min(ASide, Math.Min(BSide, CSide));
            double mid = ASide + BSide + CSide - max - min;

            return (min, mid, max);
        }
    }
}

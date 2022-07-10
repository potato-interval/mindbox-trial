using ShapesLibrary.Interfaces;

namespace ShapesLibrary.Models
{
    public class Circle : IMeasurable
    {
        #region Fields & Props
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set 
            {
                if ( value >= 0)
                    _radius = value; 
            }
        }
        #endregion

        #region Ctor
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion

        public double CalculateArea()
        {
            double output = Math.PI * Radius * Radius;

            return output;
        }
    }
}

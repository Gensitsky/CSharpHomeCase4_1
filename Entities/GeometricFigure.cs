using System;

namespace CSharpHomeCase4_1.Entities
{
    public abstract class GeometricFigure:
        Interfaces.InterfaceFigure
    {
        public abstract double AreaFigures { get; }
        public abstract double PerimeterFigures { get; }

        public double Distance(Point A, Point B)
        {
            return Math.Pow(
                (Math.Pow(Math.Abs((double)B.X - A.X), 2.0)
                + Math.Pow(Math.Abs((double)B.Y - A.Y), 2.0)),
                0.5);
        }
        public abstract override string ToString();
    }
}

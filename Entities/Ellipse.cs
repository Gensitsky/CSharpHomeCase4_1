using System;

namespace CSharpHomeCase4_1.Entities
{
    class Ellipse : Figure
    {
        protected Point first = new Point(0, 0);
        protected Point second = new Point(0, 1);
        protected Point third = new Point(1, 0);

        public Ellipse(Point first, Point second, Point third)
        {
            this.first = first.Duplicate(first);
            this.second = second.Duplicate(second);
            this.third = third.Duplicate(third);
        }
        public virtual double FocusInterval
        {
            get { return Distance(first, second); }
        }
        public virtual double Interval1
        {
            get { return Distance(first, third); }
        }
        public virtual double Interval2
        {
            get { return Distance(third, second); }
        }
        public double A
        {
            get { return (Interval1 + Interval2) / 2; }
        }
        public double B
        {
            get
            {
                return Math.Sqrt(Math.Pow(A, 2)
              - Math.Pow(FocusInterval / 2, 2));
            }
        }
        public override double Area
        {
            get { return Math.PI * A * B; }
        }
        public override double Perimeter
        {
            get
            {
                return Math.PI * (3 * (A + B)
                  - Math.Sqrt((3 * A + B) * (A + 3 * B)));
            }
        }
        public override string ToString()
        {
            return string.Format(
                "\n ____________ ELLIPSE ____________ \n" +
                " Three points : \n" +
                " A{0} B{1} C{2} \n\n" +
                " Focus interval = {3};\n interval1 = {4};\n" +
                " interval2 = {5};\n\n" +
                " Major and minor semi axis = {6}; {7};\n\n" +
                " AREA = {8};\n PERIMETER = {9};",
                first, second, third, FocusInterval,
                Interval1, Interval2, A, B, Area, Perimeter);
        }
    }
}

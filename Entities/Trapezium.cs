using System;

namespace CSharpHomeCase4_1.Entities
{
    class Trapezium : Figure
    {
        protected Point first;
        protected Point second;
        protected Point third;
        protected Point fourth;

        public Trapezium(Point first, Point second, Point third, Point fourth)
        {
            this.first = first.Duplicate(first);
            this.second = second.Duplicate(second);
            this.third = third.Duplicate(third);
            this.fourth = fourth.Duplicate(fourth);
        }
        public double Basis1
        {
            get
            {
                if ((first.Y - second.Y) * (third.X - fourth.X)
                    == (third.Y - fourth.Y) * (first.X - second.X))
                    return Distance(first, second);
                else if ((first.Y - third.Y) * (second.X - fourth.X)
                    == (second.Y - fourth.Y) * (first.X - third.X))
                    return Distance(first, third);
                return Distance(first, fourth);
            }
        }
        public double Basis2
        {
            get
            {
                if ((first.Y - second.Y) * (third.X - fourth.X)
                    == (third.Y - fourth.Y) * (first.X - second.X))
                    return Distance(third, fourth);
                else if ((first.Y - third.Y) * (second.X - fourth.X)
                    == (second.Y - fourth.Y) * (first.X - third.X))
                    return Distance(second, fourth);
                return Distance(third, second);
            }
        }
        public double Side1
        {
            get
            {
                if ((first.Y - second.Y) * (third.X - fourth.X)
                    == (third.Y - fourth.Y) * (first.X - second.X))
                {
                    if (Distance(first, third) > Distance(first, fourth))
                        return Distance(first, fourth);
                    return Distance(first, third);
                }
                else if ((first.Y - third.Y) * (second.X - fourth.X)
                    == (second.Y - fourth.Y) * (first.X - third.X))
                {
                    if (Distance(first, second) > Distance(first, fourth))
                        return Distance(first, fourth);
                    return Distance(first, second);
                }
                return Distance(first, second);
            }
        }
        public double Side2
        {
            get
            {
                if ((first.Y - second.Y) * (third.X - fourth.X)
                    == (third.Y - fourth.Y) * (first.X - second.X))
                {
                    if (Distance(second, fourth) > Distance(second, third))
                        return Distance(second, third);
                    return Distance(second, fourth);
                }
                else if ((first.Y - third.Y) * (second.X - fourth.X)
                    == (second.Y - fourth.Y) * (first.X - third.X))
                {
                    if (Distance(third, fourth) > Distance(second, third))
                        return Distance(second, third);
                    return Distance(third, fourth);
                }
                return Distance(third, fourth);
            }
        }
        public override double Area
        {
            get
            {
                double temp = 0;
                if (Basis1 != Basis2)
                {
                    temp = (Math.Pow((Basis1 - Basis2), 2)
                        + Math.Pow(Side1, 2) - Math.Pow(Side2, 2))
                        / 2 / (Basis1 - Basis2);
                }
                return (Basis1 + Basis2) / 2 * Math.Sqrt(Math.Pow(Side1, 2)
                    - Math.Pow(temp, 2));
            }
        }
        public override double Perimeter
        {
            get { return Basis1 + Basis2 + Side1 + Side2; }
        }
        public override string ToString()
        {
            return string.Format(
                "\n ____________ TRAPEZIUM ____________ \n" +
                " Four points : \n" +
                " A{0} B{1} C{2} D{3} \n\n" +
                " Basis 1 = {4};\n Basis 2 = {5}; \n" +
                " Side 1 = {6};\n Side 2 = {7};  \n\n" +
                " AREA = {8};\n PERIMETER = {9};",
                first, second, third, fourth, Basis1, Basis2,
                Side1, Side2, Area, Perimeter);
        }
    }
}
using System;

namespace CSharpHomeCase4_1.Entities
{
    class Circle : Ellipse
    {
        public Circle(Point first, Point third)
            : base(first, first, third)
        { }
        public override double FocusInterval
        {
            get { return 0; }
        }
        public override string ToString()
        {
            return string.Format(
                "\n ____________ CIRCLE ____________ \n" +
                " Two points : \n" +
                " A{0} B{1} \n\n" +
                " Radius of the Circle = {2}; \n\n" +
                " AREA = {3};\n PERIMETER = {4};",
                first, third, A, Area, Perimeter);
        }
    }
}

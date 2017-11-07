using System;

namespace CSharpHomeCase4_1.Entities
{
    class Rhombus : Parallelogram
    {
        public Rhombus(Point first, Point second, Point third, Point fourth)
            : base(first, second, third, fourth) { }

        public override string ToString()
        {
            return string.Format(
                "\n ____________ RHOMBUS ____________ \n" +
                " Four points : \n" +
                " A{0} B{1} C{2} D{3} \n\n" +
                " Side 1 = {4};\n Side 2 = {5}; \n" +
                " Side 3 = {6};\n Side 4 = {7};  \n\n" +
                " AREA = {8};\n PERIMETER = {9};",
                first, second, third, fourth, Basis1, Basis2, Side1,
                Side2, Area, Perimeter);
        }
    }
}

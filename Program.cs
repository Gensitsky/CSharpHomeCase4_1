/*
    Разработать абстрактный класс «Геометрическая Фигу-
    ра» с методами «Площадь Фигуры» и «Периметр Фигуры».
    Разработать классы-наследники: Треугольник, Квадрат,
    Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг,
    Эллипс. Реализовать конструкторы, которые однозначно
    определяют объекты данных классов.
    Реализовать класс «Составная Фигура», который
    может состоять из любого количества «Геометрических
    Фигур». Для данного класса определить метод нахождения
    площади фигуры. Создать диаграмму взаимоотношений
    классов.
*/
using System;
using CSharpHomeCase4_1.Entities;

namespace CSharpHomeCase4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 8);
            Point C = new Point(8, 0);
            Point D = new Point(8, 8);

            Ellipse ellips = new Ellipse(A, B, C);
            Console.WriteLine(ellips);

            Circle circle = new Circle(A, C);
            Console.WriteLine(circle);

            Trapezium trapezium = new Trapezium(A, B, C, D);
            Console.WriteLine(trapezium);

            Triangle trianle = new Triangle(A, B, C);
            Console.WriteLine(trianle);

            Parallelogram parallelogram = new Parallelogram(A, B, C, D);
            Console.WriteLine(parallelogram);

            Rectangle rectangle = new Rectangle(A, B, C, D);
            Console.WriteLine(rectangle);

            Rhombus rhombus = new Rhombus(A, B, C, D);
            Console.WriteLine(rhombus);

            Square square = new Square(A, B, C, D);
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }
}

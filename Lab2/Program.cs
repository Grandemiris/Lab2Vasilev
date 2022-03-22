using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнил - Заинчковский");
            Console.WriteLine("Задание 1:\n");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник", 
                Width = 12.5, 
                Height = 8.5 
            };

            Circle b = new Circle()
            {
                Name = "Круг",
                radius = 12
            };
            Parallelogram c = new Parallelogram()
            {
                Name = "Параллелограмм",
                a = 12,
                b = 5,
                h = 3
            };
            Rhombus d = new Rhombus()
            {
                Name = "Ромб",
                a = 13,
                h = 6
            };
            Square f = new Square()
            {
                Name = "Квадрат",
                a = 5
            };
            Trapeze g = new Trapeze()
            {
                Name = "Трапеция",
                a = 5,
                b = 6,
                h = 7
            };
            Triangle t = new Triangle()
            {
                Name = "Треугольник",
                a = 4,
                h = 3
            };




            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", a.Name, a.GetArea());
            Console.WriteLine("Задание 2:\n");

            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", b.Name, b.GetArea());
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", c.Name, c.GetArea());
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", d.Name, d.GetArea());
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", f.Name, f.GetArea());
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", g.Name, g.GetArea());
            Console.WriteLine("Название фигуры: {0} | Площадь = {1}", t.Name, t.GetArea());

        }
    }
}

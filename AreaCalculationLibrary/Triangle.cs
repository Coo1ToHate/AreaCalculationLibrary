using System;

namespace AreaCalculationLibrary
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        /// <summary>
        /// Конструктор треугольника с тремя сторонами
        /// </summary>
        /// <param name="a">Сторона</param>
        /// <param name="b">Сторона</param>
        /// <param name="c">Сторона</param>
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует!");
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными!");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Метод возвращает площадь треугольника по трем сторонам
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Метод указывающий является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return Math.Pow(a, 2) - (Math.Pow(b, 2) + Math.Pow(c, 2)) == 0 ||
                   Math.Pow(b, 2) - (Math.Pow(c, 2) + Math.Pow(a, 2)) == 0 ||
                   Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2)) == 0;
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами:\nA = {a}\nB = {b}\nC = {c}";
        }
    }
}

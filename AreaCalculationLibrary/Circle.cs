using System;

namespace AreaCalculationLibrary
{
    public class Circle : Shape
    {
        private double radius;

        /// <summary>
        /// Конструктор круга по радиусу
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга должен быть положительным!");
            }
            this.radius = radius;
        }

        /// <summary>
        /// Метод возвращает площадь круга
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Круг с радиусом {radius}";
        }
    }
}

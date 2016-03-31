using System;

namespace SuppliedLibrary
{
    /// <summary>
    /// Класс, описывающий треугольник.
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Длина первой стороны треугольника.
        /// </summary>
        public Double FirstEdge
        {
            get;
            private set;
        }

        /// <summary>
        /// Длина второй стороны треугольника.
        /// </summary>
        public Double SecondEdge
        {
            get;
            private set;
        }

        /// <summary>
        /// Длина третьей стороны треугольника.
        /// </summary>
        public Double ThirdEdge
        {
            get;
            private set;
        }

        /// <summary>
        /// Периметр треугольника.
        /// </summary>
        public Double Perimeter
        {
            get;
            private set;
        }

        /// <summary>
        /// Площадь треугольника.
        /// </summary>
        public Double Area
        {
            get;
            private set;
        }

        /// <summary>
        /// Конструктор треугольника по значениям длин его сторон.
        /// </summary>
        /// <param name="firstEdge">Длина первой стороны.</param>
        /// <param name="secondEdge">Длина второй стороны.</param>
        /// <param name="thirdEdge">Длина третьей стороны.</param>
        public Triangle(Double firstEdge, Double secondEdge, Double thirdEdge)
        {
            FirstEdge = firstEdge;
            SecondEdge = secondEdge;
            ThirdEdge = thirdEdge;

            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }

        /// <summary>
        /// Вычисляет периметр треугольника.
        /// </summary>
        private Double CalculatePerimeter()
        {
            return FirstEdge + SecondEdge + ThirdEdge;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона.
        /// Возвращает значение, округленное до двух знаков после запятой.
        /// </summary>
        private Double CalculateArea()
        {
            Double firstEdge = FirstEdge;
            Double secondEdge = SecondEdge;
            Double thirdEdge = ThirdEdge;

            Double semiperimeter = Perimeter / 2;

            Double area = Math.Sqrt(semiperimeter * (semiperimeter - firstEdge) * (semiperimeter - secondEdge) * (semiperimeter - thirdEdge));

            return Math.Round(area, 2);
        }

        /// <summary>
        /// Вычисляет периметр треугольника по значению длин его сторон.
        /// </summary>
        /// <param name="firstEdge">Длина первой стороны.</param>
        /// <param name="secondEdge">Длина второй стороны.</param>
        /// <param name="thirdEdge">Длина третьей стороны.</param>
        public static Double CalculatePerimeter(Double firstEdge, Double secondEdge, Double thirdEdge)
        {
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);

            return triangle.Perimeter;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по значению длин его сторон.
        /// </summary>
        /// <param name="firstEdge">Длина первой стороны.</param>
        /// <param name="secondEdge">Длина второй стороны.</param>
        /// <param name="thirdEdge">Длина третьей стороны.</param>
        public static Double CalculateArea(Double firstEdge, Double secondEdge, Double thirdEdge)
        {
            Triangle triangle = new Triangle(firstEdge, secondEdge, thirdEdge);

            return triangle.Area;
        }
    }
}

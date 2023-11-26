using System.Linq.Expressions;

namespace Geometry
{
    /// <summary>
    /// Класс фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Число Пи
        /// </summary>
        protected const double Pi = 3.14;

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public double Perimeter
        {
            get
            {
                return this.CalculatePerimeter();
            }

            private set
            {
                this.Perimeter = value;
            }
        }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square
        {
            get
            {
                return this.CalculateSquare();
            }

            private set
            {
                this.Square = value;
            }
        }

        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double CalculateSquare();

        /// <summary>
        /// Расчет периметр фигуры
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public abstract double CalculatePerimeter();

    }

    public class Circle : Shape
    {
        public double Radius { get; private set; }

        /// <summary>
        /// Контруктор круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Shape.Pi * Math.Pow(this.Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Shape.Pi * this.Radius;
        }
    }

    public class Triangle : Shape
    {
        public double FirstSide { get; private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }

        public bool IsRight 
        { 
            get 
            {
                return this.СheckForRight();
            } 
            private set
            {
                this.IsRight = value;
            } 
        
        }

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.FirstSide = firstSide;

            this.SecondSide = secondSide;

            this.ThirdSide = thirdSide;
        }

        public override double CalculateSquare()
        {
            double semiperimeter = this.CalculatePerimeter() / 2;

            double rootExpression = semiperimeter * (semiperimeter - this.FirstSide) * (semiperimeter - this.SecondSide) * (semiperimeter - this.ThirdSide);

            double square = Math.Sqrt(rootExpression);

            return square;
        }

        public override double CalculatePerimeter()
        {
            return this.FirstSide + this.SecondSide + this.ThirdSide;
        }

        /// <summary>
        /// Проверка треугольника на прямой угол
        /// </summary>
        /// <returns></returns>
        public bool СheckForRight()
        {
            List<double> values = new List<double>() { this.FirstSide, this.SecondSide, this.ThirdSide };

            values = values.OrderByDescending(x => x).ToList();

            bool theoremPythagorean = Math.Pow(values[0], 2) == Math.Pow(values[1], 2) + Math.Pow(values[2], 2);

            return theoremPythagorean;
        }
    }
}
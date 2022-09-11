using Figures.Interfaces;
using static System.Math;

namespace Figures
{
    public class Circle : BaseFigure, ICalculatableArea
    {
        public double Radius { get; init; }

        private Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override bool CanExists()
        {
            if (Radius <= 0.0)
                return false;
            
            return true;
        }

        public double GetArea()
        {
            if (!CanExists())
                return 0;//вывод сообщения пользователю?

            return Round(PI * Radius * Radius, 2);
        }
    }
}

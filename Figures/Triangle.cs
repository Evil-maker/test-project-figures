using Figures.Interfaces;
using static System.Math;

namespace Figures
{
    public class Triangle : BaseFigure, ITriangle, ICalculatableArea
    {
        public double FirstSide { get; init; }

        public double SecondSide { get; init; }

        public double ThirdSide { get; init; }

        public double Semiperimeter { get; private set; }

        private Triangle()
        {
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            Semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2.0;
        }

        //когда, где и зачем должна использоваться эта проверка?
        public bool IsRightTriangle()
        {
            double hypotenuse;

            if (!CanExists())
                return false;//вывод сообщения пользователю?

            if ((FirstSide > SecondSide) && (FirstSide > ThirdSide))
            {
                hypotenuse = FirstSide;
            }
            else if ((SecondSide > FirstSide) && (SecondSide > ThirdSide))
            {
                hypotenuse = SecondSide;
            }
            else
            {
                hypotenuse = ThirdSide;
            }

            if (hypotenuse == FirstSide)
            {
                return (SecondSide * SecondSide + ThirdSide * ThirdSide) == (hypotenuse * hypotenuse);
            }
            else if (hypotenuse == SecondSide)
            {
                return (FirstSide * FirstSide + ThirdSide * ThirdSide) == (hypotenuse * hypotenuse);
            }
            else
            {
                return (SecondSide * SecondSide + FirstSide * FirstSide) == (hypotenuse * hypotenuse);
            }

        }

        public double GetArea()
        {
            if (!CanExists())
                return 0;//вывод сообщения пользователю?
            var area = Sqrt(Semiperimeter * (Semiperimeter - FirstSide) * (Semiperimeter - SecondSide) 
                * (Semiperimeter - ThirdSide));
            return Round(area, 2);
        }

        public override bool CanExists()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
                return false;

            if ((FirstSide + SecondSide > ThirdSide) && (FirstSide + ThirdSide > SecondSide) && (SecondSide + ThirdSide > FirstSide))
                return true;
            
            return false;
        }
    }
}

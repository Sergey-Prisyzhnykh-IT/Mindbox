using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheArea
{
    public class Triangle : IFigure
    {
        double A, B, C, P;
        private string text = string.Empty;
        bool checkTriangl;

        public Triangle(double a, double b, double c)
        {
            if (CheckTriangleSides(a, b, c))
            {
                A = a;
                B = b;
                C = c;
                P = (a + b + c) / 2;
                checkTriangl = true;
            }
            else 
            {
                A = 0;
                B = 0;
                C = 0;
                P = 0;
                text = "Ошибка, сумма длин каждых двух сторон должна быть больше длины третьей стороны.";
                checkTriangl =false;
            }
                
        }
        public double Area => Math.Sqrt(P * (P - A) * (P - B) * (P - C));

        public void ShowArea()
        {
            if (checkTriangl) 
            {
                var type = TypeTriangle(A, B, C);
                text = "Сторона А = " + A + "\r\nСторона B = " + B + "\r\nСторона C = " + C + "\r\nПлощадь " + type + " треугольника = " + Area;
            }

            Console.WriteLine(text);
        }

        public bool CheckTriangleSides(double a, double b, double c) 
        {
            if (a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0)
                return true;
            else
                return false;
        }
        public string TypeTriangle(double a, double b, double c) 
        {
            if ((a == b) && (b == c))
                return "равностороннего";
            if (((a == b) && (b != c)) || ((a == c) && (b != c)) || ((b == c) && (a != c)))
                return "равнобедренного";
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                return "прямоугольного";
            else
                return "";
        }

    }
}

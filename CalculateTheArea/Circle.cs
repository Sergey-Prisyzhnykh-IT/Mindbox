namespace CalculateTheArea
{
    public class Circle : IFigure
    {
        private double radius;
        private string text = string.Empty;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area => Math.PI * radius * radius;

        public void ShowArea()
        {            
            if (CheckRadius(radius))
                text = "Введите корректное значение радиуса круга";
            else
                text = "Круг с радиусом = " + radius + "\r\nПлощадь круга = " +Area;
            Console.WriteLine(text);
        }
        public bool CheckRadius(double radius) 
        {
            if (radius == 0 || radius < 0)
                return false;
            else
                return true;

        }
    }
}
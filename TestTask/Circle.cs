namespace TestTask
{
    /// <summary>
	/// Круг
	/// </summary>
	public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            Radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
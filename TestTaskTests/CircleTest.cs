using TestTask;

namespace TestTaskTests
{
	public class CircleTest
	{
		[SetUp]
		public void Setup()
		{}

		[TestCase(-3)]
		public void NegativeRadiusShouldThrowError(double r)
		{
			Assert.Throws<ArgumentException>(() => new Circle(r));
		}

		[TestCase(4.4)]
		public void CalculateCorrectArea(double r)
		{
			Assert.That(new Circle(r).GetArea(), Is.EqualTo(60.821233773498406));
		}
	}
}
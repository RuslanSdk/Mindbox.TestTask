using TestTask;

namespace TestTaskTests
{
	public class TriangleTest
	{
		[TestCase(-3, 4, 5)]
		[TestCase(-3, -4, -5)]
		[TestCase(4, 5, 10)]
		public void NegativeSidesShouldThrowError(double sideA, double sideB, double sideC)
		{
			Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
		}

		[TestCase(3.3, 2.4, 3.9)]
		public void CalculateCorrectArea(double sideA, double sideB, double sideC)
		{
			Assert.That(new Triangle(sideA, sideB, sideC).GetArea(), Is.EqualTo(3.9436024140371955));
		}

		[TestCase(4, 3, 5)]
		public void IsRectangularShouldReturnTrue(double sideA, double sideB, double sideC)
		{
			var result = new Triangle(sideA, sideB, sideC).IsRectangular();
			Assert.That(result, Is.True);
		}

		[TestCase(4, 3, 6)]
		public void IsRectangularShouldReturnFalse(double sideA, double sideB, double sideC)
		{
			var result = new Triangle(sideA, sideB, sideC).IsRectangular();
			Assert.That(result, Is.False);
		}
	}
}
using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/// Epsilon to use when determining equality of floating point numbers
	private const double EPSILON = 1E-6;

	/// Write a method which finds the sum of a list of numbers.
	public double Sum(double[] numbers) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}


	[Test]
	public void TestSum() {
		Assert.AreEqual(0.0, Sum(new double[]{}), EPSILON);
		Assert.AreEqual(0.0, Sum(new double[]{0.0}), EPSILON);
		Assert.AreEqual(6.0, Sum(new double[]{0.0, 1.0, 2.0, 3.0}), EPSILON);
		Assert.AreEqual(-5.0, Sum(new double[]{1.0, -2.0, 3.0, -4.0, 5.0, -6.0, 7.0, -8.0, 9.0, -10.0}), EPSILON);
		Assert.AreEqual(double.NaN, Sum(new double[]{1.0, 2.0, double.NaN, 3.0}), EPSILON);
	}

}
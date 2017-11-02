using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/// Epsilon to use when determining equality of floating point numbers.
	private const double EPSILON = 1E-6;
	
	/// Write a method which finds the arithmetic mean of a
	/// set of numbers.
	public double ArithmeticMean(double[] numbers) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}
	
	/// Write a method which finds the geometric mean of a
	/// set of numbers.
	public double GeometricMean(double[] numbers) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void TestArithmeticMean() {
		Assert.AreEqual(double.NaN, ArithmeticMean(new double[]{}), EPSILON);
		Assert.AreEqual(0.0,		ArithmeticMean(new double[]{0.0}), EPSILON);
		Assert.AreEqual(10.0,		ArithmeticMean(new double[]{10.0}), EPSILON);
		Assert.AreEqual(-10.0,		ArithmeticMean(new double[]{-10.0}), EPSILON);
		Assert.AreEqual(10.0,		ArithmeticMean(new double[]{10.0, 10.0, 10.0, 10.0, 10.0}), EPSILON);
		Assert.AreEqual(2.0,		ArithmeticMean(new double[]{10.0, -10.0, 10.0, -10.0, 10.0}), EPSILON);
		Assert.AreEqual(-2.0,		ArithmeticMean(new double[]{-10.0, 10.0, -10.0, 10.0, -10.0}), EPSILON);
		Assert.AreEqual(0.0,		ArithmeticMean(new double[]{-10.0, 0.0, 10.0}), EPSILON);
		Assert.AreEqual(5.5,		ArithmeticMean(new double[]{1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0}), EPSILON);
		Assert.AreEqual(-0.5,		ArithmeticMean(new double[]{1.0, -2.0, 3.0, -4.0, 5.0, -6.0, 7.0, -8.0, 9.0, -10.0}), EPSILON);
	}
	
	[Test]
	public void TestGeometricMean() {
		Assert.AreEqual(double.NaN,			GeometricMean(new double[]{}), EPSILON);
		Assert.AreEqual(0.0,				GeometricMean(new double[]{0.0}), EPSILON);
		Assert.AreEqual(10.0,				GeometricMean(new double[]{10.0}), EPSILON);
		Assert.AreEqual(-10.0,				GeometricMean(new double[]{-10.0}), EPSILON);
		Assert.AreEqual(10.0,				GeometricMean(new double[]{10.0, 10.0, 10.0, 10.0, 10.0}), EPSILON);
		Assert.AreEqual(100.0,				GeometricMean(new double[]{1.0, 10.0, 100.0, 1000.0, 10000.0}), EPSILON);
		Assert.AreEqual(100.0,			   	GeometricMean(new double[]{1.0, -10.0, 100.0, -1000.0, 10000.0}), EPSILON);
		Assert.AreEqual(2.605171084697351, 	GeometricMean(new double[]{1.0, 2.0, 3.0, 4.0, 5.0}), EPSILON);
		Assert.AreEqual(2.605171084697351, 	GeometricMean(new double[]{1.0, -2.0, 3.0, -4.0, 5.0}), EPSILON);		
	}
}

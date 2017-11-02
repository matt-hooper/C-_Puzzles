using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	 /// Write a method which finds the the specified Factorial x!
	public long Factorial(int x) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void TestValidInput() {
		Assert.AreEqual(1, Factorial(0));
		Assert.AreEqual(1, Factorial(1));
		Assert.AreEqual(2, Factorial(2));
		Assert.AreEqual(6, Factorial(3));
		Assert.AreEqual(24, Factorial(4));
		Assert.AreEqual(120, Factorial(5));
		Assert.AreEqual(720, Factorial(6));
		Assert.AreEqual(5040, Factorial(7));
		Assert.AreEqual(40320, Factorial(8));
		Assert.AreEqual(362880, Factorial(9));
		Assert.AreEqual(3628800, Factorial(10));
	}
	
	[Test]
	public void TestInvalidInput() {
		try {
			long y = Factorial(-1);
			Assert.Fail();
		} catch(ArgumentOutOfRangeException iae) { /* OK */ iae.ToString(); }
	}
}

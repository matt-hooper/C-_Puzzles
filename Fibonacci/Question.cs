using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/// Write a method which generates the xth
	///  term of the Fibonacci sequence.
	public int Fibonacci(int x) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void testFibonacci() {
		Assert.AreEqual(0, Fibonacci(1));
		Assert.AreEqual(1, Fibonacci(2));
		Assert.AreEqual(1, Fibonacci(3));
		Assert.AreEqual(2, Fibonacci(4));
		Assert.AreEqual(3, Fibonacci(5));
		Assert.AreEqual(5, Fibonacci(6));
		Assert.AreEqual(8, Fibonacci(7));
		Assert.AreEqual(13, Fibonacci(8));
		Assert.AreEqual(21, Fibonacci(9));
		Assert.AreEqual(34, Fibonacci(10));
		Assert.AreEqual(55, Fibonacci(11));
		Assert.AreEqual(89, Fibonacci(12));
	}
}

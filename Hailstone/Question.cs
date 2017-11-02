using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/// Write a method which finds the number of steps required
	/// for the Hailstone sequence starting with x to terminate.
	public int Hailstone(int x) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void testHailstone() {
		Assert.AreEqual(8,   Hailstone(6));	
		Assert.AreEqual(14,  Hailstone(11));
		Assert.AreEqual(9,   Hailstone(12));	
		Assert.AreEqual(9,   Hailstone(13));		
		Assert.AreEqual(17,  Hailstone(14));
		Assert.AreEqual(17,  Hailstone(15));
		Assert.AreEqual(20,  Hailstone(18));
		Assert.AreEqual(20,  Hailstone(19));
		Assert.AreEqual(7,   Hailstone(20));
		Assert.AreEqual(7,   Hailstone(21));
		Assert.AreEqual(15,  Hailstone(22));
		Assert.AreEqual(15,  Hailstone(23));
		Assert.AreEqual(18,  Hailstone(28));
		Assert.AreEqual(18,  Hailstone(29));
		Assert.AreEqual(18,  Hailstone(30));
		Assert.AreEqual(21,  Hailstone(36));
		Assert.AreEqual(21,  Hailstone(37));
		Assert.AreEqual(21,  Hailstone(38));
		Assert.AreEqual(111, Hailstone(27));
	}
	
}

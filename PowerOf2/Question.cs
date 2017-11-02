using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/// Write a method that determines whether a specified number is a non-negative, 
	/// integral power of 2.
	public bool PowerofTwo(double x) {
		// Write your answer here ...
		if (x / 2 == 1)
			return true;
		else if (x / 2 < 1)
			return false;
		else 
			return (PowerofTwo(x / 2));
	}

	[Test]
	public void testPowerofTwo() {
		Assert.AreEqual(true, PowerofTwo(8));
		Assert.AreEqual(true, PowerofTwo(128));
		Assert.AreEqual(true, PowerofTwo(1048576));
		Assert.AreEqual(false, PowerofTwo(10));
		Assert.AreEqual(false, PowerofTwo(0.25));
		Assert.AreEqual(false, PowerofTwo(199));
		Assert.AreEqual(false, PowerofTwo(1050000)); 
		
	}
}

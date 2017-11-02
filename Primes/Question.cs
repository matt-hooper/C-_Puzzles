using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	 /// Write a method which determines if the specified integer
	 /// is a prime number.
	public bool IsPrime(int x) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}

	 /// Counts the number of primes up to integer x
	public int CountPrime(int x) {
		// Write your answer here …
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void testIsPrime() {
		Assert.True(IsPrime(2));
		Assert.True(IsPrime(3));
		Assert.True(IsPrime(7));
		Assert.True(IsPrime(17));
		Assert.True(IsPrime(4567));
		Assert.True(IsPrime(5387));
		Assert.True(IsPrime(6997));
		Assert.True(IsPrime(7901));	
	}
	
	[Test]
	public void testNotPrime() {
		Assert.False(IsPrime(0));
		Assert.False(IsPrime(1));
		Assert.False(IsPrime(4));
		Assert.False(IsPrime(10));
		Assert.False(IsPrime(100));
		Assert.False(IsPrime(256));
		Assert.False(IsPrime(1000));	
	}
	
	[Test]
	public void testCountPrime() {
		Assert.AreEqual(1, CountPrime(2));
		Assert.AreEqual(2, CountPrime(3));
		Assert.AreEqual(3, CountPrime(5));
		Assert.AreEqual(4, CountPrime(10));
		Assert.AreEqual(25, CountPrime(100));
		Assert.AreEqual(168, CountPrime(1000));
		Assert.AreEqual(1229, CountPrime(10000));
		Assert.AreEqual(9592, CountPrime(100000));
		Assert.AreEqual(78498, CountPrime(1000000));	
	}

}

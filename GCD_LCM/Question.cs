using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	 /// Write a method which finds the greatest common divisor
	 /// of two numbers.
	public int GCD(int x, int y) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}
	
	 /// Write a method which finds the least common multiple
	 /// of two numbers.
	public int LCM(int x, int y) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}
	
	/// Write a method which determines if x and y
	/// are co-prime.
	public bool IsCoprime(int x, int y) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}

	[Test]
	public void TestGreatestCommonDenominator() {
		Assert.AreEqual(2,  GCD(532,7374));
		Assert.AreEqual(4,  GCD(100,256));
		Assert.AreEqual(6,  GCD(12,30));
		Assert.AreEqual(6,  GCD(24,54));
		Assert.AreEqual(10, GCD(10,20));	
	}
	
	[Test]
	public void TestLeastCommonMultiple() {
		Assert.AreEqual(120, LCM(5,24));
		Assert.AreEqual(27,  LCM(3,27));
		Assert.AreEqual(20,  LCM(4,5));
		Assert.AreEqual(15,  LCM(3,5));
		Assert.AreEqual(20,  LCM(10,20));	
	}
	
	[Test]
	public void TestIsIsCoprime() {
		Assert.True(IsCoprime(6,35));
		Assert.True(IsCoprime(14,15));
		Assert.True(IsCoprime(15,28));
		Assert.True(IsCoprime(2456,6547));
	}
	
	[Test]
	public void TestNotCoprime() {
		Assert.False(IsCoprime(6,27));
		Assert.False(IsCoprime(14,21));
		Assert.False(IsCoprime(15,60));
		Assert.False(IsCoprime(100,1000));		
	}
}

using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class Question {

	/**
	 * Write a method that takes a list of strings, 
	 * and returns the length of the longest string.
	 */
	public int Longest(List<string> strings) {
		return 999;	// Code your answer here!
	}


	[Test]
	public void TestAnswer() {
		List<string> strings = new List<string>();
		strings.Add("Hi");
		strings.Add("World");
		Assert.AreEqual(5, Longest(strings));
		
		strings.Clear();
		strings.Add("123");
		strings.Add("HugeString");
		strings.Add("12345");
		Assert.AreEqual(10, Longest(strings));

		strings.Clear();
		strings.Add("Chocolate");
		strings.Add("Good");
		Assert.AreEqual(9, Longest(strings));

		strings.Clear();
		strings.Add("1");
		Assert.AreEqual(1, Longest(strings));

		strings.Clear();
		Assert.AreEqual(0, Longest(strings));
	}

}

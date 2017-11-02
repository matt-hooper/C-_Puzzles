using NUnit.Framework;

[TestFixture]
public class Question {

	/**
	 * Write a method that that takes a string e.g. aaabbbbcccaa and returns
	 * a string with adjacent duplicates removed (in this example, abca).
	 */
	public string Compact(string text) {
		return null; // Code your answer here!
	}


	[Test]
	public void TestAnswer() {
		Assert.AreEqual("abca", Compact("aaabbbbcccaa"));
		Assert.AreEqual("abcda", Compact("aaabbbbcccdaa"));
		Assert.AreEqual("abc123", Compact("abbccc111223"));
		Assert.AreEqual("helo", Compact("hello"));
	}

}

using NUnit.Framework;

[TestFixture]
public class Question {

	/**
	 * Write a method to determine if a string is a 
	 * palindrome (reads the same forward as back e.g. "kayak")
	 */
	public bool IsPalindrome(string s) {
		return false; // Code your answer here!
	}


	[Test]
	public void TestAnswer() {
		Assert.IsTrue(IsPalindrome("kayak"));
		Assert.IsTrue(IsPalindrome("madam"));
		Assert.IsTrue(IsPalindrome("racecar"));
		Assert.IsTrue(IsPalindrome("deed"));
		Assert.IsTrue(IsPalindrome("12321"));
		Assert.IsTrue(IsPalindrome("SAIPPUAKUPPINIPPUKAUPPIAS"));

		Assert.IsFalse(IsPalindrome("abc56cba"));
		Assert.IsFalse(IsPalindrome("abc576cba"));
		Assert.IsFalse(IsPalindrome("Hello"));
		Assert.IsFalse(IsPalindrome("hello"));
		Assert.IsFalse(IsPalindrome("bye"));
	}

}

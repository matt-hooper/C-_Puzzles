using NUnit.Framework;

[TestFixture]
public class Question {

	/**
	 * Write a method which accepts two strings and returns
	 * whether the strings are anagrams of each other.
	 */
	public bool IsAnagram(string s1, string s2) {
		return true; // Code your answer here!
	}


	[Test]
	public void testAnswer() {
		Assert.IsTrue(IsAnagram("stipend", "spendit"));
		Assert.IsTrue(IsAnagram("stoneage", "stageone"));
		Assert.IsTrue(IsAnagram("thearticulateperson", "heuttersaclearpoint"));
		Assert.IsTrue(IsAnagram("whatisthesquarerootofnine", "threeforanequationshowsit"));

		Assert.IsFalse(IsAnagram("thisisnotananagram", "isit"));
		Assert.IsFalse(IsAnagram("butmight", "butisnot"));
		Assert.IsFalse(IsAnagram("1234", "43211234"));
		Assert.IsFalse(IsAnagram("onetwothree", "onetwothrow"));
		Assert.IsFalse(IsAnagram("onetwothrow", "onetwothree"));
		Assert.IsFalse(IsAnagram("onetwothree", "onetwothrqq"));
		Assert.IsFalse(IsAnagram("onetwothrqq", "onetwothree"));
	}

}

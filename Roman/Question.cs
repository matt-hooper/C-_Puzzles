using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

[TestFixture]
public class Question {

	 /// Write a method which converts an integer to Roman numerals.
	public String ToRoman(int x) {
		// Write your answer here ...
		throw new NotSupportedException("Answer has not been written yet");
	}


	[Test]
	public void TestAnswer() {
		Assert.AreEqual("XXIV",      ToRoman(24));
		Assert.AreEqual("XXXI",      ToRoman(31));
		Assert.AreEqual("LXIV",      ToRoman(64));
		Assert.AreEqual("CCXXVI",    ToRoman(226));
		Assert.AreEqual("CDXLVIII",  ToRoman(448));
		Assert.AreEqual("CM",        ToRoman(900));
		Assert.AreEqual("CMXCVIII",  ToRoman(998));
		Assert.AreEqual("MDCCXII",   ToRoman(1712));
		Assert.AreEqual("MCMXCVIII", ToRoman(1998));
		Assert.AreEqual("MMDCCLI",   ToRoman(2751));
	}

}

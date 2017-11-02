using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
/// Provide a working implementation of the Complex class
public class Question {

	/// Epsilon to use when determining equality of floating point numbers. 
	private const double EPSILON = 1E-6;
	
	/// Used in tests
	private Complex a = new Complex(5.0, 6.0);
	
	/// Used in tests
	private Complex b = new Complex(-3.0, 4.0);
	
	/// Provide a working implementation of the Complex class
	protected class Complex {
		
		private double real;
		private double imag;
		
		public Complex(double real, double imag) {
			this.real = real;
			this.imag = imag;
		}
		
		public Complex Plus(Complex w) {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public Complex Minus(Complex w) {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public Complex Times(Complex w) {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public Complex Divides(Complex w) {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public Complex Reciprocal() {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public Complex Exp() {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}

		public double Abs() {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public double Phase() {
			// Write your answer here …
			throw new NotSupportedException("Answer has not been written yet");
		}
		
		public double Real {
			get {
				return real;
			}
		}
		
		public double Imag {
			get {
				return imag;
			}
		}		
		
		public override String ToString() {
			if(Math.Abs(real) < EPSILON) return imag + "i";
			if(Math.Abs(imag) < EPSILON) return real + "";
			if(imag < 0.0) {
				return real + "-" + (-imag) + "i";
			}
			return real + "+" + imag + "i";
		}
		
		public override bool Equals(Object obj) {
			if(obj == null) return false;
			if(obj == this) return true;
			Complex w = (Complex)obj;
			return Math.Abs(this.real - w.real) < EPSILON && Math.Abs(this.imag - w.imag) < EPSILON;
		}		
		
		public override int GetHashCode() {
			return (int)Abs();
		}		
	}
	
	[Test]
	public void TestPlus() {
		Assert.AreEqual(new Complex(2.0, 10.0), a.Plus(b));
		Assert.AreEqual(new Complex(2.0, 10.0), b.Plus(a));
	}
	
	[Test]
	public void TestMinus() {
		Assert.AreEqual(new Complex(8.0,  2.0),  a.Minus(b));
		Assert.AreEqual(new Complex(-8.0, -2.0), b.Minus(a));
	}
	
	[Test]
	public void TestTimes() {
		Assert.AreEqual(new Complex(-39.0, 2.0), a.Times(b));
		Assert.AreEqual(new Complex(-39.0, 2.0), b.Times(a));
	}
	
	[Test]
	public void TestDivides() {
		Assert.AreEqual(new Complex(0.36, -1.52), a.Divides(b));
		Assert.AreEqual(new Complex(0.1475409836, 0.6229508197), b.Divides(a));
	}
	
	[Test]
	public void TestExp() {
		Assert.AreEqual(new Complex(142.5019055182, -41.4689367899), a.Exp());
		Assert.AreEqual(new Complex(-0.0325429996,  -0.0376789778),  b.Exp());
	}
	
	[Test]
	public void TestAbs() {
		Assert.AreEqual(7.8102496760, a.Abs(), EPSILON);
		Assert.AreEqual(5.0,          b.Abs(), EPSILON);
	}
	
	[Test]
	public void TestPhase() {
		Assert.AreEqual(0.8760580506, a.Phase(), EPSILON);
		Assert.AreEqual(2.2142974356, b.Phase(), EPSILON);
	}	
}

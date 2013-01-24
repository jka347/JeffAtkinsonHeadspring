using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz_UnitTests
{
    
    
    /// <summary>
    ///This is a test class for FizzBuzzDivisorTest and is intended
    ///to contain all FizzBuzzDivisorTest Unit Tests
    ///</summary>
	[TestClass()]
	public class FizzBuzzDivisorTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for FizzBuzzDivisor Constructor
		///</summary>
		[TestMethod()]
		public void FizzBuzzDivisorConstructorTest()
		{
			int divisor = 7;
			string outputToken = "token";
			FizzBuzzDivisor target = new FizzBuzzDivisor(divisor, outputToken);
			Assert.AreEqual(target.Divisor, divisor);
			Assert.AreEqual(target.OutputToken, outputToken);
		}

		/// <summary>
		///A test for Divisor
		///</summary>
		[TestMethod()]
		public void DivisorTest()
		{
			int divisor = 0; 
			string outputToken = string.Empty; 
			FizzBuzzDivisor target = new FizzBuzzDivisor(divisor, outputToken);
			int expected = 9;
			int actual;
			target.Divisor = expected;
			actual = target.Divisor;
			Assert.AreEqual(expected, actual);			
		}

		/// <summary>
		///A test for OutputToken
		///</summary>
		[TestMethod()]
		public void OutputTokenTest()
		{
			int divisor = 0; 
			string outputToken = string.Empty; 
			FizzBuzzDivisor target = new FizzBuzzDivisor(divisor, outputToken); 
			string expected = "pow"; 
			string actual;
			target.OutputToken = expected;
			actual = target.OutputToken;
			Assert.AreEqual(expected, actual);
		}
	}
}

using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;

namespace FizzBuzz_UnitTests
{
    
    
    /// <summary>
    ///This is a test class for FizzBuzzTest and is intended
    ///to contain all FizzBuzzTest Unit Tests
    ///</summary>
	[TestClass()]
	public class FizzBuzzTest
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
		///A test for CompareDivisors
		///</summary>
		[TestMethod()]
		[DeploymentItem("FizzBuzz.dll")]
		public void CompareDivisorsTest()
		{
			FizzBuzzDivisor x = new FizzBuzzDivisor(3, "Fizz");
			FizzBuzzDivisor y = new FizzBuzzDivisor(3, "Buzz");
			FizzBuzzDivisor z = new FizzBuzzDivisor(5, "Fizz");
			int expected = 0; 
			int actual;
			actual = FizzBuzz_Accessor.CompareDivisors(x, y);
			Assert.AreEqual(expected, actual);

			expected = -1;
			actual = FizzBuzz_Accessor.CompareDivisors(x, z);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException), "A min was incorrectly allowed to be greater than the max")]
		public void PrintFizzBuzzStringTest_InvalidMinMax()
		{
			int min = 6;
			int max = 1;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>();
			divisors.Add(new FizzBuzzDivisor(3, "fizz"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentNullException), "Stream argument was incorrectly allowed to be null")]
		public void PrintFizzBuzzStringTest_NullStream()
		{
			int min = 1;
			int max = 6;
			Stream stream = null;			
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>();
			divisors.Add(new FizzBuzzDivisor(3, "fizz"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentNullException), "Divisor List was incorrectly allowed to be null")]
		public void PrintFizzBuzzStringTest_NullDivisorList()
		{
			int min = 1;
			int max = 6;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzzDivisor> divisors = null;
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException), "A read-only stream was incorrectly allowed")]
		public void PrintFizzBuzzStringTest_InvalidStream()
		{
			int min = 1;
			int max = 6;
			byte[] buffer = new byte[10]; 
			Stream stream = new System.IO.MemoryStream(buffer, false);
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>();
			divisors.Add(new FizzBuzzDivisor(3, "fizz"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException), "An empty divisor list was incorrectly allowed.")]
		public void PrintFizzBuzzStringTest_EmptyDivisorList()
		{
			int min = 1;
			int max = 6;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>(); 
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		public void PrintFizzBuzzStringTest_OneDivisor()
		{
			int min = 1;
			int max = 3;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>();
			divisors.Add(new FizzBuzzDivisor(3, "fizz"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
			string expected = "1 2 fizz ";
			stream.Position = 0;
			StreamReader reader = new StreamReader(stream);
			Assert.AreEqual(expected, reader.ReadLine());
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		public void PrintFizzBuzzStringTest_TwoDivisors()
		{
			int min = -35;
			int max = -12;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzzDivisor> divisors = new List<FizzBuzzDivisor>();
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(-3, "bang"));
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(2, "boom"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
			string expected = "-35 boom bang boom -31 bangboom -29 boom bang boom -25 bangboom -23 boom bang boom -19 bangboom -17 boom bang boom -13 bangboom ";
			stream.Position = 0;
			StreamReader reader = new StreamReader(stream);
			Assert.AreEqual(expected, reader.ReadLine());
		}

		/// <summary>
		///A test for PrintFizzBuzzString
		///</summary>
		[TestMethod()]
		public void PrintFizzBuzzStringTest_ThreeDivisors()
		{
			int min = -12;
			int max = 35;
			Stream stream = new System.IO.MemoryStream();
			List<FizzBuzz.FizzBuzzDivisor> divisors = new List<FizzBuzz.FizzBuzzDivisor>();
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(2, "bang"));
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(3, "pop"));
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(5, "boom"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(min, max, stream, divisors);
			string expected = "bangpop -11 bangboom pop bang -7 bangpop boom bang pop bang -1 bangpopboom 1 bang pop bang boom bangpop 7 bang pop bangboom 11 bangpop 13 bang popboom bang 17 bangpop 19 bangboom pop bang 23 bangpop boom bang pop bang 29 bangpopboom 31 bang pop bang boom ";
			stream.Position = 0;
			StreamReader reader = new StreamReader(stream);			
			Assert.AreEqual(expected, reader.ReadLine());
		}
	}
}

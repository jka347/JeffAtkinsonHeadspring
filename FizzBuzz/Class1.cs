using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzDivisor
	{
		public int Divisor { get; set; }
		public string OutputToken { get; set; }

		public FizzBuzzDivisor(int divisor, string outputToken)
		{
			Divisor = divisor;
			OutputToken = outputToken;
		}
	}

	public static class FizzBuzz
	{
		private static int CompareDivisors(FizzBuzzDivisor x, FizzBuzzDivisor y)
		{
			if (x == null)
			{
				if (y == null)
					return 0; //consider equal if both null
				return -1; //y is greater
			}
			else if (y == null)
				return 1; //x is greater

			return x.Divisor.CompareTo(y.Divisor);
		}

		public static void PrintFizzBuzzString(int min, int max, System.IO.Stream stream, List<FizzBuzzDivisor> divisors)
		{	
			if (min > max)
				throw new System.ArgumentException("Min is greater than Max");
			if(stream == null)
				throw new System.ArgumentNullException("stream");
			if (!stream.CanWrite)
				throw new System.ArgumentException("Invalid stream", "stream");
			if (divisors == null)
				throw new System.ArgumentNullException("divisors");
			if (divisors.Count == 0)
				throw new System.ArgumentException("No divisors", "divisors");

			divisors.Sort(FizzBuzz.CompareDivisors);
			System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
			string output;
			for (int i = min; i <= max; i++)
			{
				output = "";
				bool usedToken = false;
				foreach (FizzBuzzDivisor d in divisors)
				{
					if (i % d.Divisor == 0)
					{
						output += d.OutputToken;
						usedToken = true;
					}
				}
				if (!usedToken)
					output = i.ToString();
				output += " ";
				sw.Write(output);
			}
			sw.Write('\n');
			sw.Flush();
		}
	}
}

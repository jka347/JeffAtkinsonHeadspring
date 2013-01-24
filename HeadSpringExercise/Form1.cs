using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HeadSpringExercise
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void fizzBuzzButton_Click(object sender, EventArgs e)
		{
			List<FizzBuzz.FizzBuzzDivisor> divisors = new List<FizzBuzz.FizzBuzzDivisor>();
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(3, "Fizz"));
			divisors.Add(new FizzBuzz.FizzBuzzDivisor(5, "Buzz"));
			FizzBuzz.FizzBuzz.PrintFizzBuzzString(1, 100, System.Console.OpenStandardOutput(), divisors);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator
{
	class Calculator
	{
		public static double DoOperation(double num1, double num2, string op)
		{
			double res = double.NaN;
			switch (op)
			{
				case "a":
					res = num1 + num2;
					break;

				case "s":
					res = num1 - num2;
					break;

				case "m":
					res = num1 * num2;
					break;

				case "d":
					res = num1 / num2;
					break;

				default: break;
			}
			return res;
		}
	}
}

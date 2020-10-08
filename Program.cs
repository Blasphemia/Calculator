using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;


namespace CalculatorProgram
{
	class Program
	{
		static void Main(string[] args)
		{

			bool endApp = false;
			Console.WriteLine("Console Calculator in C#\r");
			Console.WriteLine("------------------------\n");

			while (!endApp)
			{
				string numInput1 ;
				string numInput2;
				double res;
				double cleanNum1; double cleanNum2;

				Console.WriteLine("Type a number, and then press Enter");
				numInput1 = Console.ReadLine();

				while (!double.TryParse(numInput1, out cleanNum1))
				{
					Console.Write("This is not valid input. Please enter an integer value: ");
					numInput1 = Console.ReadLine();
				}

				Console.WriteLine("Type a number, and then press Enter");
				numInput2 = Console.ReadLine();

				while (!double.TryParse(numInput2, out cleanNum2))
				{
					Console.Write("This is not valid input. Please enter an integer value: ");
					numInput2 = Console.ReadLine();
				}






				Console.WriteLine("Choose an option from the following list:");
				Console.WriteLine("\t a - Add");
				Console.WriteLine("\t s - Subtract");
				Console.WriteLine("\t m - Multiply");
				Console.WriteLine("\t d - Divide");
				Console.Write("Your option? ");

				string op = Console.ReadLine();

				while (op != "a" && op != "s" && op != "m" && op != "d") 
				{
					Console.Write("Please, choose a correct operation: ");
					op = Console.ReadLine();
				}
					
			
				

				try
				{
					res = Calculator.DoOperation(cleanNum1, cleanNum2, op);
					if (double.IsNaN(res))
					{
						Console.WriteLine("This operation will result in a mathematical error.\n");
					}
					else Console.WriteLine("Your result: {0:0.##}\n", res);
				}
				catch (Exception e)
				{
					Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
				}

				Console.Write("Do you want to continue? \n Press 'n' to close the app, or press 'y' to continue: ");
				string key = Console.ReadLine();


				do
				{
					if (key == "n")
					{
						endApp = true; break;
					}
					else if (key == "y")
					{
						endApp = false; break;
					}
					else
					{
						Console.Write("Please, press 'n' to close the app, or press 'y' to continue: ");
						key = Console.ReadLine();
					}


				}
				while (key != "n" || key != "y");


				
				Console.WriteLine("\n");
			}



			return;
		}


	}












}


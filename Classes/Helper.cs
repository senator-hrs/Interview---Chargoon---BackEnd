using System;
using System.Linq;

namespace Interview.Classes
{
	internal static class Helper
	{
		internal static void PrintSeprator()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\n{String.Concat(Enumerable.Repeat("-", 25))}\n");
			Console.ResetColor();
		}

		internal static void PrintError(string errorMessage)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\nError: {errorMessage}");
			Console.ResetColor();
		}

		internal static void PrintInfo(string infoMessage)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"\n{infoMessage}\n");
			Console.ResetColor();
		}

		internal static void PrintMenu(params string[] messages)
		{
			PrintSeprator();
			Console.ForegroundColor = ConsoleColor.Green;
			foreach (var message in messages)
			{
				Console.WriteLine(message);
			}
			PrintSeprator();
			Console.ResetColor();
		}

		internal static void PrintMessage(string message)
		{
			Console.WriteLine(message);
		}

		internal static void PrintMessageInline(string message)
		{
			Console.Write(message);
		}
	}
}

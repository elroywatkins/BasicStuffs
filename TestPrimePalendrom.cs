using System;

public class Test
{
	public static void Main()
	{
		//TestPrimeNumbers();
		
		TestPalendrom();
		
	}
	
	public static void TestPrimeNumbers()
	{
		// your code goes here
		var x = Console.ReadLine();
		for(int i = 1;i<100;i++)
		{
			var n = (IsPrime(i)) ? "" : "not";
			Console.WriteLine($"{i} is {n} prime ");
		}
	}
	
	public static bool IsPrime(int x)
	{
		int num = x;
		for(int i = 2;i<num;i++)
		{
		//	Console.WriteLine($"{num} mod {i} = :{num % i}");
			if (num % i == 0)
			
			return false;
		}
		
		return true;
	}
	
	public static void TestPalendrom()
	{
		string i = Console.ReadLine();
		string n = (IsPalendrom(i)) ? "" : "not";
		Console.Write($"{i} is {n} a palendrom");
	}
	
	public static bool IsPalendrom(string x)
	{
		int len = x.Length / 2;
	
		int compareIdx = 0;
		
		for (int i = 0;i<len ;i++)
		{
			compareIdx = x.Length - i -1;
			if (x[i] != x[compareIdx])	
			return false;
		}
		return true;
		
	}
}
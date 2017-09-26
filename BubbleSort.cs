using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		var x = new int[] {5,2,3,5,8,4,1};
		int tmp = 0;
		for(int i = 0;i<x.Length;i++)
		{
			for(int j=0;j<x.Length-1;j++)
			{
				if (x[j] > x[j+1])
				{
					tmp = x[j]; 
					x[j] = x[j+1];
					x[j+1] = tmp;
					
				}
			}
		}
		for(int j=0;j<x.Length;j++)
			{
			Console.Write(x[j]);			
			}
	}
}
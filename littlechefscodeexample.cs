using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		// your code goes here
		new LittleChefs().Bake();
	}
}

public class TestCase
{
	public int[] sampleArray {get;set;}
	public int arrayLength  {get;set;}	
}

public class LittleChefs
{	 
    private int numOfTestCases = 0;
    private List<TestCase> testCaseList;
    public LittleChefs()
    { 
        testCaseList = new List<TestCase>();
        //Create Test Cases
        ImportInput();
    }
	
	private void ImportInput()
	{
		//Read file and parse into testCaseList
		var moreData = true;
		int lineTypeCounter = 0;
		int arrayLength = 0;
		int[] arrayData;
		string line = "";
	
		while(moreData)
		{
			line = Console.ReadLine();
		
			if(string.IsNullOrEmpty(line))
			{
				moreData = false;
				break;
			}
			
			//read number of test cases
			if (lineTypeCounter == 0)
			{
				int.TryParse(line,out numOfTestCases);
			}
			else
			{
				//array length
				if (lineTypeCounter % 2 != 0)
				{
					int.TryParse(line,out arrayLength);
				}
				//array data
				else
				{
					var stringArray = line.Split(' ');
					arrayData = Array.ConvertAll(stringArray, int.Parse);
					testCaseList.Add(new TestCase() {arrayLength = arrayLength,sampleArray = arrayData});
				}
			}
			lineTypeCounter++;
		}
		// testCaseList.Add(new TestCase() {iptArrayLength = 3;iptSampleArray = new int[]{1,3,6};});
		// testCaseList.Add(new TestCase() {iptArrayLength = 2;iptSampleArray = new int[]{4,2};});
		// testCaseList.Add(new TestCase() {iptArrayLength = 4;iptSampleArray = new int[]{5,3,4,10};});
	}
	
	public void Bake()
	{
		 foreach (var item in testCaseList)
		 {
		 	Console.WriteLine($"{GetMinimumIndex(item)}");			
		 }
	}
	
	private int GetMinimumIndex(TestCase item)
	{
		//find minimum value and return index
		var minVal = -1;
		var idx = 0;
		for(int i = 1;i<=item.arrayLength;i++)
		{
			var res = prefixSum(i,item.sampleArray) + suffixSum(i,item.sampleArray);
			if (res < minVal || minVal == -1)
			{
				minVal = res;
				idx = i;
			}
		}
		
		return idx;
	}

	private int prefixSum(int idx,int[] arrayToTraverse)
	{		
		//add all numbers until idx
		var res = 0;
		for(int i = 0;i < idx;i++)
		{			
			res+= arrayToTraverse[i];
		}
		return res;
	}
	
	private int suffixSum(int idx,int[] arrayToTraverse)
	{
		//add all numbers until idx
		var res = 0;
		for(int i = idx-1;i <= arrayToTraverse.Length-1;i++)
		{
			res+=arrayToTraverse[i];
		}
		return res;
	}
}



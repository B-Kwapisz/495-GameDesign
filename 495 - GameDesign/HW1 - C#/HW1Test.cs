//BRIAN KWAPISZ
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using HW1;
[TestFixture]
public class HW1Test
{

	HW1Code code;

	[SetUp]
	public void Init()
	{
		code = new HW1Code();
	}

	[Test]
	public void TwoMax_Test()
	{
		Assert.AreEqual(HW1Code.TwoMax(4, 6), 6);
		Assert.AreEqual(HW1Code.TwoMax(1, -5), 1);
		Assert.AreEqual(HW1Code.TwoMax(-100, -99), -99);
	}

	[Test]
	public void ThreeMax_Test()
	{
		Assert.AreEqual(HW1Code.TwoMax(4, 6, 3), 6);
		Assert.AreEqual(HW1Code.TwoMax(1, -5, 0), 1);
		Assert.AreEqual(HW1Code.TwoMax(-100, -101, -99), -99);
	}

	[Test]
	public void StartsWithVowel_Test()
	{
		Assert.AreEqual(HW1Code.StartsWithVowel("apple"), true);
		Assert.AreEqual(HW1Code.StartsWithVowel("Egg"), true);
		Assert.AreEqual(HW1Code.StartsWithVowel("Yellow"), false);
		Assert.AreEqual(HW1Code.StartsWithVowel("blue"), false);
	}

	[Test]
	public void PalindromeCheck_Test()
	{
		Assert.AreEqual(HW1Code.PalindromeCheck("apple"), false);
		Assert.AreEqual(HW1Code.PalindromeCheck("radar"), true);
		Assert.AreEqual(HW1Code.PalindromeCheck("RADAR"), true);
	}

	[Test]
	public void OddArray_Test()
	{
		var array1 = new int[] { 3, 1, 5, 6 }; //test array
		var array1A = new int[] { 3, 1, 5 };   //answer array
		var array2 = new int[] { 4321, -5, 1, 2 };
		var array2A = new int[] { 4321, -5, 1 };
		var array3 = new int[] { 0, 2, 4, 6 };
		var array3A = new int[] { 0 };
		Assert.AreEqual(HW1Code.OddArray(array1).ToString(), array1A.ToString());
		Assert.AreEqual(HW1Code.OddArray(array2).ToString(), array2A.ToString());
		Assert.AreEqual(HW1Code.OddArray(array3).ToString(), array3A.ToString());
	}
	[Test]
	public void Multiply_Test()
	{
		List<int> list1 = new List<int>(); //check for function
		list1.Add(5);
		list1.Add(3);
		list1.Add(2);
		list1.Add(10);

		List<int> list2 = new List<int>(); //check for 0 
		list2.Add(5);
		list2.Add(3);
		list2.Add(0);
		list2.Add(10);

		List<int> list3 = new List<int>(); //check for negative
		list3.Add(5);
		list3.Add(3);
		list3.Add(-2);
		list3.Add(10);

		Assert.AreEqual(HW1Code.Multiply(list1), 300);
		Assert.AreEqual(HW1Code.Multiply(list2), 0);
		Assert.AreEqual(HW1Code.Multiply(list3), -300);
	}
	[Test]
	public void IsSorted_Test()
	{
		var doubles1 = new List<double>();         //6
		doubles1.Add(3.5);
		doubles1.Add(6.6);
		doubles1.Add(8.5);
		doubles1.Add(4.4);
		Assert.AreEqual(HW1Code.IsSorted(doubles1), false);
		var doubles2 = new List<double>();         //6

		doubles2.Add(3.5);
		doubles2.Add(4.4);
		doubles2.Add(6.6);
		doubles2.Add(7.2);
		Assert.AreEqual(HW1Code.IsSorted(doubles2), true);
	}
	[Test]
	public void Dups_Test()
	{ 
		var dups = new List<char>();
		dups.Add('a');
		dups.Add('g'); dups.Add('f');
		dups.Add('f');
		dups.Add('s');
		dups.Add('v');
		dups.Add('g');
		dups.Add('f');
		dups.Add('5');
		Assert.AreEqual(HW1Code.Dups(dups), 3);
	}

	[Test]
	public void PangramCheck_Test()
	{
		string pangram = "The quick brown fox jumps over the lazy dog";
		string pangramVar = "ThE QuIcK BrOwN FoX Jumps Over The LAzy Dog";
		string notPangram = "Words words words words";

		Assert.AreEqual(HW1Code.PangramCheck(pangram), true);
		Assert.AreEqual(HW1Code.PangramCheck(pangramVar), true);
		Assert.AreEqual(HW1Code.PangramCheck(notPangram), false);

	}
	[Test]
	public void Lowest_Test()
	{
		var array1 = new int[] { 3, 5, 2, 7, 8, 2 };
		var array2 = new int[] { 3, 5, 2, 7, 8, -2 };
		var array3 = new int[] { 3, -5, 2, 7, 8, 2 };
		var array4 = new int[] { -3, 5, 2, 7, 8, 2 };

	    Assert.AreEqual(HW1Code.Lowest(array1), 2);
		Assert.AreEqual(HW1Code.Lowest(array2), -2);
		Assert.AreEqual(HW1Code.Lowest(array3), -5);
		Assert.AreEqual(HW1Code.Lowest(array4), -3);
	}

	[Test]
	public void LowestValue_Test()
	{

		var stuff = new Dictionary<string, int>();
		stuff.Add("Books", 3);
		stuff.Add("Bottles", 12);
		stuff.Add("Apples", 5);
		stuff.Add("Eggs", 10);
		stuff.Add("Rice", 4);
		stuff.Add("Tacos", 8);
		Assert.AreEqual(HW1Code.LowestValue(stuff), 3);
	}


	[Test]
	public void LoShu_Test()
	{
		var square1 = new int[3, 3]
			{
				{4, 9, 2},
				{3, 5, 7},
				{8, 1, 6}
			};
		var square2 = new int[3, 3]
			{
				{4, 9, 2},
				{3, 5, 1},
				{8, 7, 6}
			};
		var square3 = new int[4, 3]
			{
				{4, 9, 2},
				{3, 5, 7},
				{8, 1, 6},
			    {3, 4, 2}
			};
		Assert.AreEqual(HW1Code.LoShu(square1), true);
		Assert.AreEqual(HW1Code.LoShu(square2), false);
		Assert.AreEqual(HW1Code.LoShu(square3), false);
	}

	[Test]
	public void FilterLongWords_Test()
	{
		var words1 = new List<string>();
		words1.Add("West");
		words1.Add("Chester");
		words1.Add("University");
		words1.Add("of");
		words1.Add("Pennsylvania");

		var words2 = new List<string>();
		words2.Add("West");
		words2.Add("CHESTER");
		words2.Add("UNIVERSITY");
		words2.Add("of");
		words2.Add("PENNSYLVANIA");
		string compare = string.Join(",", words2.ToArray());
		string outputString = string.Join(",", HW1Code.FilterLongWords(words1, 5).ToArray());
		Assert.AreEqual(outputString, compare);
	}

	[Test]
	public void TopTen_Test()
	{
		var highScores = new Dictionary<string, int>();
		highScores.Add("Brian", 3500000);
		highScores.Add("Bill", 12500000);
		highScores.Add("Bob", 5500000);
		highScores.Add("Eddard", 10500000);
		highScores.Add("Rob", 4500000);
		highScores.Add("Tyrion", 8500000);
		highScores.Add("Jon", 9500000);
		highScores.Add("LSH", 11500000);
		highScores.Add("Davos", 7500000);
		highScores.Add("Steve", 6500000);
		highScores.Add("Drogo", 13500000);
		highScores.Add("Batman", 24511333);


		var sorted = new Dictionary<string, int>();
		sorted.Add("Batman", 24511333); 
		sorted.Add("Drogo", 13500000);
		sorted.Add("Bill", 12500000);
		sorted.Add("LSH", 11500000);
		sorted.Add("Eddard", 10500000);
		sorted.Add("Jon", 9500000);
		sorted.Add("Tyrion", 8500000);
		sorted.Add("Davos", 7500000);
		sorted.Add("Steve", 6500000);
		sorted.Add("Bob", 5500000);


		var sortedString = string.Join(",", sorted.ToArray()); 

		 
		var hsString = string.Join(",", HW1Code.TopTen(highScores).ToArray());



		Assert.AreEqual(hsString, sortedString);
	}
}


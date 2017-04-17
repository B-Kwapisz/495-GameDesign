/*
BRIAN KWAPISZ
CSC495 - Topics in Computer Science: Game Design (Large-Scale Systems)
HW1Code.cs
Objective: Learn basic C# and test using NUnit
*/

using System;
using System.Collections.Generic;
using System.Linq;
namespace HW1
{
    public class HW1Code
    {
    	//Write a method TwoMax that takes two integer arguments and returns the largest. 
    	//(Do not use any built-in max() function. Write if statements.
        public static int TwoMax(int a, int b)
        {
            if (a >= b) { return a; }
            else return b;
        }

        //override for 3 parameters being passed into TwoMax
        public static int TwoMax(int a, int b, int c) //overload
        {
           return ThreeMax(a, b, c);
        }

        //Write a method ThreeMax that takes three arguments and returns the largest of them. 
        //(Once again, do not use any built-in max().)
        public static int ThreeMax(int a, int b, int c)
        {
            if ((a >= b) && (a >= c)) { return a; }
            else if ((b >= a) && (b >= c)){ return b; }
            else return c;
        }

        //Write a method StartsWithVowel that takes a character and returns the boolean true if it is a vowel, false otherwise.
        public static bool StartsWithVowel(string word)
        {
            string upperWord = word.ToUpper();
            if ((upperWord[0] == 'A') || (upperWord[0] == 'E') || 
                (upperWord[0] == 'I') || (upperWord[0] == 'O') || 
                (upperWord[0] == 'U'))
            { return true; }
            else return false;
        }

        //Write a method PalindromeCheck that recognizes palindromes 
        //(i.e. words that read the same backward or foreward). For example, is_palindrome("radar") should return True.
        public static bool PalindromeCheck(string word)
        {
			int i = 0;
			int j = word.Length - 1;

			while (i<j)
			{
				if (word[i] != word[j])
					return false;

				i++;
				j--;
			}

			return true;
		}
        
		//Write a method named OddArray that takes an array of integers and returns a new array 
		//that only contains those numbers that are odd.
        public static int[] OddArray(int[] nums)
        {
            int[] odds = new int[nums.Length];
            int count = 0;

            foreach(int i in nums)
            {
                if((i % 2) == 1) 
				{
                    
                    odds[count] = i;
                    count++; 
				}
            }
            return odds;
        }
        
        //Write a method Multiply that multiplies all the numbers in a list of integers and returns the product.
        public static int Multiply(List<int> numList)
        {
            int product = 1;
            foreach(int i in numList)
            {
                product *= i;
            }
		return product;
        }

		//Write a method IsSorted that takes a list of doubles as a parameter and 
		//returns true if the list is sorted in ascending order and false otherwise.

		public static bool IsSorted(List<double> list)
		{
			var nums = list.ToArray();
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] < nums[i-1]) { return false; }
			}
			return true;
		}
		//Write a method Lowest that takes an array of integers and returns the value of the smallest element.
		public static int Lowest(int[] nums)
		{
			int lowest = nums[0];

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] < lowest) { lowest = nums[i]; }
			}
			return lowest;
		}

		//Write a method Dups that takes a list of characters and returns the number of duplicates in the list.
		public static int Dups(List<char> list)
		{
			int counter = 0;
			var dupChars = list.GroupBy(x => x);
			char checker = '*';
			foreach (char c in list)
			{
				if(c == checker)
					{
						counter++;
						checker = c;
					}
			}
			return counter;
		}

		//Write a method LowestValue that takes a dictionary of string, 
		//integer key-value pairs. (The strings can be fruit inventory, 
		//such as "apple" and "pear" and the integers are inventory remaining,
		//like 3.) Have the method return the smallest value in the dictionary.
		public static int LowestValue(Dictionary<string, int> list)
		{
			var lowest = list.Min(x => x.Value);
			return lowest;
		}

		//A pangram is a sentence that contains all the letters of the English alphabet at least once, 
		//for example: The quick brown fox jumps over the lazy dog. Write a methold PangramCheck to check a sentence to see if it is a pangram or not.
		public static bool PangramCheck(string sentence)
		{
			string alphabet = "abcdefghijklmnopqrstuvwxyz";

			return alphabet.All(sentence.ToLower().Contains);
		}

		//Learn how to make 2d arrays in C#. Write a method LoShu that accepts a two-dimensional array as an argument and 
		//returns whether or not the array is a Lo Shu Magic Square. Lo Shu Magic Square have three rows and three columns, 
		//where the numbers 1 through 9 occur exactly once, and the sum of each row, each column, and each diagonal all add up to the same number.
		public static bool LoShu(int[,] square)
		{
			if (square.Length != 9)
			{
				return false;
			}
			if ((square[0, 0] + square[0, 1] + square[0, 2] != square[1, 0] + square[1, 1]
						  + square[1, 2]) || (square[2, 0] + square[2, 1] + square[2, 2] != square[0, 0] 
			                                  + square[1, 0] + square[2, 0] ) || (square[0, 1] + square[1, 1]
                         + square[2, 1] != square[0, 2] + square[1, 2] + square[2, 2])){
				return false;
			}
			else return true;
		}

		//Write a method FilterLongWords that takes a list of words and an integer n and returns the list of words, CAPITALIZED, that are longer than n.
		public static List<string> FilterLongWords(List<string> words, int n)
		{
			
			var array = words.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length >= n)
				{
					array[i] = array[i].ToUpper();
				}
			}
			return array.ToList();
		}    

		//Write a method TopTen that takes a dictionary of string, integer key-value pairs. 
		//(Imagine that the strings are names, such as "Rich" and the integers are high scores, like 300000000.) 
		//Have the method return a string, integer key-value dictionary that only contains the ten highest scores.
        public static Dictionary<string, int> TopTen(Dictionary<string, int> topTen)
        {
			var sorted = topTen.OrderByDescending(score => score.Value)
			        .Take(10);
			
			return sorted.ToDictionary(score => score.Key, score => score.Value);
        }

        //In-program testing
        public static void Main()
        {
        //TwoMax
			Console.WriteLine(TwoMax(3, 4));
		//ThreeMax
            Console.WriteLine(ThreeMax(3, 5, 6));
		//StartsWithVowels
            Console.WriteLine(StartsWithVowel("apple"));
		//PalindromeCheck
			Console.WriteLine(PalindromeCheck("radar")); //4
		//OddArray
            var array1 = new int[] { 3, 4, 3, 7 };     //5
			Console.WriteLine(OddArray(array1).ToArray());
		//Multiply
            var numbers = new List<int>();         //6
                numbers.Add(3);
                numbers.Add(6);
                numbers.Add(8);
                numbers.Add(4);
            Console.WriteLine(Multiply(numbers));

			//dups
			var dups = new List<char>();
			dups.Add('a');
			dups.Add('g');dups.Add('f');
			dups.Add('f');
			dups.Add('s');
			dups.Add('v');
			dups.Add('g');
			dups.Add('f');
			dups.Add('5');
			Console.WriteLine(Dups(dups));

		//Lowest
			//IsSorted
			var doubles1 = new List<double>();         //6
			doubles1.Add(3.5);
			doubles1.Add(6.6);
			doubles1.Add(8.5);
			doubles1.Add(4.4);
			Console.WriteLine(IsSorted(doubles1));
			var doubles2 = new List<double>();         //6
			doubles2.Add(3.5);
			doubles2.Add(4.4);
			doubles2.Add(6.6);
			doubles2.Add(7.2);
			Console.WriteLine(IsSorted(doubles2));
		//LowestValue
		//PangramCheck
			string pangram = "The quick brown fox jumps over lazy dogs";
			string notPangram = "Jon Snow knows nothing.";
			Console.WriteLine(PangramCheck(pangram));
			Console.WriteLine(PangramCheck(notPangram));
		//LoShu
			var square = new int[3, 3]
			{
				{4, 9, 2},
				{3, 5, 7},
				{8, 1, 6}
			};
			Console.WriteLine(LoShu(square));

		//FilterLongWords
            var words = new List<string>();
            words.Add("West");
            words.Add("Chester");
            words.Add("University");
            words.Add("of");
            words.Add("Pennsylvania");

			string outputString = string.Join(",", FilterLongWords(words, 5).ToArray());
			Console.WriteLine(outputString);
        
		//Top Ten
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

			TopTen (highScores);
			outputString = string.Join(",", TopTen(highScores).ToArray());
			Console.WriteLine(outputString);
		}
    }
}

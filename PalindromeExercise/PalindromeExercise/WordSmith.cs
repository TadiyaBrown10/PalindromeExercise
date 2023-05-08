using System;
namespace PalindromeExercise
{
	public class WordSmith
	{

		public bool IsAPalindrome(string word)
		{
			var Reverse = "";
			for(int i = word.Length - 1; i >= 0; i--)
			{
				Reverse += word[i];
			}

			if (Reverse.ToLower() == word.ToLower())
			{
				return true;
			}

			else
			{
				return false;
			}
		}
	}
}


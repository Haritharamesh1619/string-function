using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace string_function
{
     class Program
    {
        static void Main()
        {
            string str = "doodle blue";
            int length = str.Length;  // length is used to measure the length of given length  
            Console.WriteLine("Enter the Length:"+length);

            string y = "welcome to doodle blue";
            string subStr = y.Substring(8, 5); // substring is used find the particular word 
            Console.WriteLine("Enter the substring:" + subStr);

            string x = "hello world";
            int index = x.IndexOf("world");// Returns the index of the first occurrence of a specified substring
            Console.WriteLine("Enter the Index:" + index);

            bool contains = str.Contains("doodle");// Checks whether the specified substring occurs within the string
            Console.WriteLine("Enter the Contains:" + contains);

            string newStr = str.Replace("blue", "doodle");// Replace blue as doodle
            Console.WriteLine("Enter the Replace string:" + newStr);

            string upperStr = str.ToUpper(); // upperStr return captial letter
            Console.WriteLine("Enter the string into UpperCase:" + upperStr);

            string lowerStr = str.ToLower(); // lowerStr returns small letter
            Console.WriteLine("Enter the string into lowerCase:" + lowerStr);

            string trimmedStr = str.Trim();// Removes all whitespace characters from the string
            Console.WriteLine(" Trim the  given string:" + trimmedStr);

            string trimSStr = str.TrimStart();// Removes leading whitespace characters from the string
            Console.WriteLine("Trim the given startstring:" + trimSStr);

            string trimEStr = str.TrimEnd();// Removes trailing whitespace characters from the string
            Console.WriteLine("Trim the given endstring:" + trimEStr);

            string ary = "doodle,blue,innovation";
            string[] words = ary.Split(','); // Splits a string into an array of strings
            Console.WriteLine("Splitted strings:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string[] wordarry = { "welcome", "back" };
            string joinedStr = string.Join(", ", wordarry);
            Console.WriteLine("joinned string:" + joinedStr);

            
            bool startsWith = str.StartsWith("doodle"); // Checks if the string starts with 'doodle'
            bool endsWith = str.EndsWith("blue!"); // Checks if the string ends with 'blue!' 
            Console.WriteLine("Beginning  of the string:" + startsWith + endsWith);
            Console.WriteLine(" End of the string:" + startsWith + endsWith);

            Console.ReadLine();
        }
    }
}

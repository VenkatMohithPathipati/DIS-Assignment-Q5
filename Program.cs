using System;
using System.Collections.Generic;

namespace AssignQues5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string word = Console.ReadLine();// enter the string
            var array = new int[word.Length]; // and array with lenght of the word since they are same
            Console.WriteLine("Enter the indices");
            for (int i = 0; i < word.Length; i++)//input to the array
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var dict = new Dictionary<int, char>();// dictionalry initialization
            for (int i = 0; i < word.Length; i++)
            {
                dict.Add(array[i], word[i]); // adding key, values to the dictionary
            }
            var dum = "";
            for (int i = 0; i < word.Length; i++)
            {
                dum = dum + dict[i]; // adding each value sorted from 0 to word length of dictionary
            }
            Console.WriteLine(dum);
 
            

        }
    }
}

/* Given a string s consisting of words and spaces, return the length of the last word in the string. 
 * A word is a maximal substring consisting of non-space characters only.
 * Example 1:
    * Input: s = "Hello World"
    * Output: 5
    * Explanation: The last word is "World" with length 5.
 * 
 * Example 2:
    * Input: s = " fly me to the moon "
    * Output: 4
    * Explanation: The last word is "moon" with length 4.*/

using System.Reflection.PortableExecutable;

namespace CCAD16_Assignment5_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a sentence with spaces. I'll calculate the length of the last word.");
            string input = Console.ReadLine();
            input = input.Trim();
            int output = LastWordLength(input);

            Console.WriteLine($"The last word in '{input}' has a length of {output}");
        }

        static int LastWordLength(string s)
        {
            int length = 0;
            
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                }

                else
                {
                    break;
                }
            }
            return length;
        }
    }   
}

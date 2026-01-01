using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // PART 1: Concatenate three strings
            // -------------------------------

            // Declare the first string
            string firstName = "Naif";

            // Declare the second string
            string middleText = " is learning ";

            // Declare the third string
            string subject = "C# programming.";

            // Concatenate the three strings into one sentence
            string fullSentence = firstName + middleText + subject;

            // Print the concatenated string to the console
            Console.WriteLine(fullSentence);


            // -------------------------------
            // PART 2: Convert a string to uppercase
            // -------------------------------

            // Convert the sentence to uppercase using ToUpper()
            string upperCaseSentence = fullSentence.ToUpper();

            // Display the uppercase version of the string
            Console.WriteLine(upperCaseSentence);


            // -------------------------------
            // PART 3: Use StringBuilder to build a paragraph
            // -------------------------------

            // Create a new StringBuilder object
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence to the paragraph
            paragraph.Append("C# is a powerful programming language. ");

            // Add the second sentence to the paragraph
            paragraph.Append("It is commonly used for building applications on Windows. ");

            // Add the third sentence to the paragraph
            paragraph.Append("StringBuilder is useful when working with large or changing text.");

            // Display the completed paragraph
            Console.WriteLine(paragraph.ToString());


            // -------------------------------
            // Pause the program so the console stays open
            // -------------------------------

            // Wait for the user to press a key before closing the console
            Console.ReadLine();
        }
    }
}

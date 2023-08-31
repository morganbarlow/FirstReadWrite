using System;
using System.Collections.Generic;
using System.IO; // Pulling in the system input output to be used to read and write

namespace FirstReadWrite // Names are in White
{
    internal class Program // Class Name in Teal, if you change the name here the file name will change
    {
        static void Main(string[] args) // Method called right when program starts
        {
            const string FILE_NAME = "myclasses.txt"; // Create a constant string and reference FILE_NAME rather than remembering spelling of named file
            
            // Write to File
            StreamWriter outputFile = File.CreateText(FILE_NAME); // Create StreamWriter object to create txt file
            outputFile.WriteLine("INFO 2200-001"); // Write a NEW LINE into the txt 
            outputFile.WriteLine("IT 1510-X01"); // Write a NEW LINE into the txt 
            outputFile.WriteLine("IT 2700-X01"); // Write a NEW LINE into the txt 
            outputFile.WriteLine("IT 2800-006"); // Write a NEW LINE into the txt 
            outputFile.Close(); // Close the file we have written to \

            Console.WriteLine("Morgan's Classes");

            // Read from File
            StreamReader inputFile = File.OpenText(FILE_NAME); // Create a StreamReader object to read from the txt file
            List<string> allclasses = new List<string>(); // Create list of strings called allclasses, call constructor method

            while(!inputFile.EndOfStream) // While inputFile above is NOT at the end of the stream, run below, if it is at the end stop loop
            {
                string line = inputFile.ReadLine(); // Add each line to a line to send through single Read line through the while loop
                Console.WriteLine(line); // Read line from input file and write it to the console
                allclasses.Add(line); // Add class to list of all classes
            }
            inputFile.Close();

            Console.WriteLine("-----------"); // Write to console 
            Console.WriteLine("Random Class"); // Write to console 

            Random rand = new Random(); // New Random Object

            // Pick a random number with the max value being the number of items in allclasses
            Console.WriteLine(allclasses[rand.Next(allclasses.Count)]);

            // Keep console open
            Console.ReadLine();
        }
    }
}

// ctrl + k + d = clean up your code spacing
// ctrl + k + c = comment highlighted code
//ctrl + k + u = uncomment highlighted code
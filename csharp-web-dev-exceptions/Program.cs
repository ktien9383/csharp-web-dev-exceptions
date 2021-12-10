using System;
using System.Collections.Generic;
using System.IO;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        /*
        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
        }
        */

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            /*       
             try
             {
                 double x = Divide(5, 0);
             }
             catch (ArgumentOutOfRangeException e)
             {
                 Console.WriteLine($"Divided by zero: '{e}'");
             }
             catch (IOException e)
             {
                 Console.WriteLine($"Problem with Read/Write: '{e}'");
             }
             */

            // Test out your CheckFileExtension() function here!
            try
            {
                int y = CheckFileExtention("inputFile.cs");
                Console.WriteLine($"The return code is {y}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"'{e}'");
            }

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

        }
        
         static double Divide(double x, double y)
        {
           if (y == 0)
           {
                throw new ArgumentOutOfRangeException();
           }
           return x / y;
        }
        
         static int CheckFileExtention(string fileName)
        {
            if (fileName is null)
            {
                throw new ArgumentNullException("The Filename is missing!");
            }
            return fileName.Substring(fileName.LastIndexOf('.')) == ".cs" ? 1 : 0;
        }
    }
}

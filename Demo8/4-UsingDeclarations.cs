using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Demo8
{
    public static class UsingDeclarations
    {
        public static int ConvertFiles()
        {
            int output = 0;

            using var inputFile = new StreamReader(@"C:\Users\Sasha\Downloads\Sample.txt");
            using var outputFile = new StreamWriter(@"C:\Users\Sasha\Downloads\SampleOutput.txt");
            
            string line;
            
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.Write(line);
                output += 1;
            }

            //using (var inputfile = new StreamReader(@"‪C:\Users\Sasha\Downloads\Sample.txt"))
            //{
            //    using (var outputFile = new StreamWriter(@"‪C:\Users\Sasha\Downloads\SampleOutput.txt"))
            //    {
            //        string line;
            //        while ((line = inputfile.ReadLine()) != null)
            //        {
            //            outputFile.Write(line);
            //            output += 1;
            //        }
            //    }
            //}
            return output;
        }
    }
}

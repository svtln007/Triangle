using System;
using System.IO;

namespace triangle_test
{
    class triangle_test
    {
        static void Main()
        {
            int testCounter = 1;
            using var outputFile = new StreamWriter("../../../../output.txt", false);
            using (var inputFile = new StreamReader("../../../../input.txt"))
            {
                string testCaseArguments;
                string expectedOutput;
                string realOutput;

                while ((testCaseArguments = inputFile.ReadLine()) != null)
                {
                    char[] delimiter = { ' ' };
                    string[] args = testCaseArguments.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    expectedOutput = inputFile.ReadLine();

                    var output = new StringWriter();
                    Console.SetOut(output);
                    Console.SetError(output);

                    Triangle.Program.Main(args);
                    realOutput = output.ToString();
                    realOutput = realOutput.Replace("\n", "").Replace("\r", "");

                    if (realOutput == expectedOutput)
                    {
                        outputFile.WriteLine("Test passed " + testCounter + ": successfully");
                    }
                    else
                    {
                        outputFile.WriteLine("Test " + testCounter + ": failed. Expected: " + expectedOutput + " Recieved: " + realOutput);
                    }

                    testCounter++;
                }
            }
        }
    }
}
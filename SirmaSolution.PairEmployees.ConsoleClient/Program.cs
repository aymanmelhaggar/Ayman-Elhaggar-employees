using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SirmaSolution.PairEmployees.ConsoleClient
{
    class Program
    {
        static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().Location;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        static void Main(string[] args)
        {
            string dataFilePath = OperatingSystem.IsWindows() ? $"{AssemblyDirectory}\\DataFileSample.txt" : $"{AssemblyDirectory}//DataFileSample.txt";

            List<Employee> employees = null;
            try
            {
                employees = EmployeeFileReader.ReadEmployeeFile(dataFilePath);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException || ex is FormatException || ex is System.IO.IOException)
                {
                    Console.WriteLine("Read Employee File Error: " + ex.Message);

                    Console.WriteLine("\n\nPress any key to exist...");

                    Console.ReadKey();

                    return;
                }
                else throw;
            }

            List<ProjectEmployeePair> projectEmployeePairPairs = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            PrintResult(projectEmployeePairPairs);

            Console.WriteLine("\n\nPress any key to exist...");
            
            Console.ReadKey();
        }

        private static void PrintResult(List<ProjectEmployeePair> projectEmployeePairPairs)
        {
            Console.WriteLine("Employee ID #1,\tEmployee ID #2,\tProject ID,\tDays Worked");
            if (projectEmployeePairPairs.Count > 0)
                foreach (var projectEmployeePairPairsRecord in projectEmployeePairPairs.OrderByDescending(e => e.DaysWorked))
                    Console.WriteLine($"{projectEmployeePairPairsRecord.EmpID1}\t\t{projectEmployeePairPairsRecord.EmpID2}\t\t{projectEmployeePairPairsRecord.ProjectID}\t\t{projectEmployeePairPairsRecord.DaysWorked}");
            else
                Console.WriteLine("No Employee pairs found..");
        }
    }
}

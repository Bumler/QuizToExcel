using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizToExcel
{
    class Program
    {
        private static string quizFilePath, rosterFilePath, columnName;
        private List<string> roster;
        private static readonly string resource = "pathfinder.txt";

        public static void Main(string[] args)
        {
            //gets our quiz and roster file path and the column name from the first three lines of text
            quizFilePath = GetLine(resource, 0);
            rosterFilePath = GetLine(resource, 1);
            columnName = GetLine(resource, 2);
        }

        private static void readRoster()
        {
            //Needs to read through the first column of the excel file and write the names/email addresses to a roster
        }

        //http://stackoverflow.com/questions/1262965/how-do-i-read-a-specified-line-in-a-text-file
        //reads through the txt file and returns the specified line
        private static string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 0; i < line; i++)
                {
                    sr.ReadLine();
                }
                return sr.ReadLine();
            }
        }
    }
}

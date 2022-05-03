using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;  
//using Excel = Microsoft.Office.Interop.Excel;

namespace ListEcxel
{
    class Program
    {
        static void Main()
        {
            List<string[]> file = ReadingFile();
            file = DeleteFirst(file);
            file = Sort(file);
            YourResult(file);
            file = Accept(file);
            file = Arrive(file);
            file = DeleteLast(file);

        }

        public static List<string[]> ReadingFile()
        {
            string path = (@"your path to file");

            List<string[]> result = new List<string[]>();
            List<string> line = new List<string>();

            using (StreamReader stremreader = new StreamReader(path))
            {
                for (int i = 0; i < 400; i++)
                {
                    line.Add(stremreader.ReadLine());
                }

                for (int i = 0; i < line.Count; i++)
                {
                    result.Add(line[i].Split(';'));
                }
                return result;
            }
        }

        
        static List<string[]> Sort(List<string[]> list)
        {
            List<string[]> intermediate = new List<string[]>();

            List<string[]> low = new List<string[]>();
            List<string[]> medium = new List<string[]>();
            List<string[]> high = new List<string[]>();
            List<string[]> notSpecified = new List<string[]>();
            List<string[]> critical = new List<string[]>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][3] == "Low") low.Add(list[i]);
                else if (list[i][3] == "Medium") medium.Add(list[i]);
                else if (list[i][3] == "High") high.Add(list[i]);
                else if (list[i][3] == "Not Specified") notSpecified.Add(list[i]);
                else if (list[i][3] == "Critical") critical.Add(list[i]);
            }
            intermediate.AddRange(low);
            intermediate.AddRange(medium);
            intermediate.AddRange(high);
            intermediate.AddRange(critical);
            intermediate.AddRange(notSpecified);
            
            low.Clear();
            medium.Clear();
            high.Clear();
            notSpecified.Clear();
            critical.Clear();

            return intermediate;
        }
        static List<string[]> Accept(List<string[]> list)
        {
            return list.OrderBy(x => DateTime.Parse(x[2])).ToList();
        }
        static List<string[]> Arrive(List<string[]> list)
        {
            return list.OrderBy(x => DateTime.Parse(x[20])).ToList();
        }

        static List<string[]> DeleteFirst(List<string[]> list)
        {
            List<string[]> intermediate = new List<string[]>();

            for (int i = 1; i < list.Count; i++)
            {
                intermediate.Add(list[i]);
            }
            return intermediate;
        }
        static List<string[]> DeleteLast(List<string[]> list)
        {
            List<string[]> intermediate = new List<string[]>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                intermediate.Add(list[i]);
            }
            return intermediate;
        }

        static void YourResult(List<string[]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (string intermediate in list[i]) Console.Write(intermediate);
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace KnimeObjects
{
    public class FileReader
    {
        public DataFrame dataFrame;

        public FileReader(string path, bool index = true)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    string[] firstRow = new string[1];
                    List<string[]> table = new List<string[]>();

                    int counter = 0;

                    if (index){}
                    else
                    {
                        counter = 1;
                    }

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');
                        for (int i=0; i<temp.Length; i++)
                        {
                            if (temp[i].Contains("\"")) {
                                temp[i] = temp[i].Substring(1, temp[i].Length - 2);
                            }
                        }
                        if (counter > 0)
                        {
                            table.Add(temp);
                        }
                        else if (counter == 0)
                        {
                            firstRow = temp;
                        }
                        counter++;
                    }

                    string[][] tableArray = table.ToArray();

                    dataFrame = new DataFrame(firstRow, tableArray);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public DataFrame GetDataFrame()
        {
            return dataFrame;
        }
    }
}

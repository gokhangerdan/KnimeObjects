using System.Collections.Generic;

namespace KnimeObjects
{
    public class DataFrame
    {
        public object[] header;
        public object[,] data;

        public DataFrame(string[] header, string[][] bufferedTable)
        {
            object[] temp = new object[header.Length];
            for (int i=0; i<header.Length; i++)
            {
                temp[i] = header[i];
            }

            int rowCount = bufferedTable.Length;
            int colCount = bufferedTable[0].Length;

            object[,] temp2 = new object[colCount, rowCount];
            for (int i=0; i<rowCount; i++)
            {
                for (int j=0; j<colCount; j++)
                {
                    temp2[j, i] = bufferedTable[i][j];
                }
            }

            data = temp2;
        }

        public object[] GetHeader()
        {
            return header;
        }

        public object[,] GetData()
        {
            return data;
        }
    }
}

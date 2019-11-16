using System;

namespace KnimeObjects
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/home/ggerdan/Downloads/ornek_veri.csv";
            FileReader reader = new FileReader(path, true);
            DataFrame df = reader.GetDataFrame();

            object[] header = df.GetHeader();
            object[,] data = df.GetData();

            int rowLength = data.GetLength(0);
            int colLength = data.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", data[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}

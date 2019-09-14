using System;
using System.IO;
using System.Globalization;

namespace ExerciseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter the FULL path of file (eg: C:\Folder1\file1.csv): ");
            string sourcePath = Console.ReadLine();
            string targetPath = Path.GetDirectoryName(sourcePath) + @"\out";

            try
            {
                Directory.CreateDirectory(targetPath);

                using (StreamWriter sw = new StreamWriter(new FileStream(targetPath + @"\summary.csv", FileMode.Create)))
                {
                    using (StreamReader sr = new StreamReader(new FileStream(sourcePath, FileMode.Open)))
                    {
                        while (!sr.EndOfStream)
                        {
                            string tempLine = sr.ReadLine();
                            string[] tempLine2 = tempLine.Split(",");
                            float f1 = float.Parse(tempLine2[1], CultureInfo.InvariantCulture);
                            float f2 = float.Parse(tempLine2[2], CultureInfo.InvariantCulture);
                            float f3 = f1 * f2;
                            sw.WriteLine(tempLine2[0] + "," + f3.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Ocurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

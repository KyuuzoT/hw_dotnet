using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * Algorithm
             * 1. Open text file as stream
             * 2. Read all data from file to resulting string
             * 3. Split resulting string using spaces as delimiters to get an 'array of substrings'
             * 4. In cycle get each substring and convert it to byte
             * 5. Make an array of such bytes
             * 7. Write it to new image file.
             * 
             **/

            byte binary;
            using (StreamReader sr = new StreamReader(
                @"D:\Development\Prog\HW_02\HW_02\Task3\Assets\image.txt", true))
            {
                string res = sr.ReadToEnd();
                string[] arrRes = res.Split(' ');
                byte[] imageBytes = new byte[arrRes.Length - 1];

                for (int i = 0; i < arrRes.Length - 1; i++)
                {
                    binary = Convert.ToByte(arrRes[i], 2);
                    imageBytes[i] = binary;
                }
                string sNameOfImage = "Screenshot.txt";
                File.WriteAllBytes(@"D:\Development\Prog\HW_02\HW_02\Task3\Assets\" + sNameOfImage, imageBytes);
            }
        }
    }
}

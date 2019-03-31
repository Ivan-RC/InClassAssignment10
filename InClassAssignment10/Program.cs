using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Ivan Rivas
//This is my own work

namespace InClassAssignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("TextFile3.txt");
            string[] splitText = text.Split();
            Console.WriteLine(text);
            int etCount = 0;

            for (int i = 0; i < splitText.Length; i++)
            {
                string curr = splitText[i];
                while (curr.Length > 0 && !Char.IsLetter(curr[curr.Length - 1]))
                {
                    curr = curr.Substring(0, curr.Length - 1);
                }

                if (curr[curr.Length - 1].Equals('e') ||
                    curr[curr.Length - 1].Equals('t'))
                {
                    etCount++;
                }

            }
            Console.WriteLine("There are " + etCount + " words that end in t or e.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            var name = Console.ReadLine();
            char[] separators = {' ', '.', ',', ';'};

            string[] words = name.Split(separators);
            string correctFormatName = "";
            foreach (var word in words)
            {
                if (word != "")
                {
                    correctFormatName += CorrectFormatWord(word) + " ";
                }
            }
            if (correctFormatName.Length >= 1)
            {
                correctFormatName.Remove(correctFormatName.Length - 1);
            }
            Console.WriteLine(correctFormatName);
            Console.ReadKey();
        }

        static string CorrectFormatWord(string word)
        {
            string correctFormatWord = word[0].ToString().ToUpper();
            for (int i = 1; i < word.Length; i++)
            {
                correctFormatWord += word[i].ToString().ToLower();
            }
            return correctFormatWord;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyVowel_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            string inpWords;
            int vowelCount = 0;
            
            //get input
            Console.Write("Please enter a word: ");
            inpWords = Console.ReadLine();

            //loop for count
            for (int x = 0; x < inpWords.Length; x = x + 1)
            {
                if (inpWords[x] == 'a' || inpWords[x] == 'e' || inpWords[x] == 'i' || inpWords[x] == 'o' || inpWords[x] == 'u')
                {
                    vowelCount = vowelCount + 1;
                }
            }
            
            //give count
            Console.WriteLine(vowelCount);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTask.Models
{

    public class FizzBuzzDetector
    {
        private StringBuilder output=new StringBuilder();
        private StringBuilder currentWord=new StringBuilder();

        private int wordIndex=0;
        private int count=0;


        public Result GetOverlappings(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));


            if (input.Length < 7 || input.Length > 100)
                throw new ArgumentOutOfRangeException(nameof(input));


            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    currentWord.Append(c);// add the current char at the end of the cuurent word untill space
                }
                else
                {
                    ProcessWord();

                    // keep spaces and symbols
                    output.Append(c);
                }
            }


            // process last word if exists
            ProcessWord();


            return new Result
            {
                OutputString = output.ToString(),
                Count = count
            };
        }


        private void ProcessWord()
        {
            if (currentWord.Length == 0)
                return;//return or get out there is no word


            wordIndex++;//the index of the word increasing to replace if it match

            string word = currentWord.ToString();//currentWord is string builder and replaceword recept string so we turn it into string

            string replacedWord = ReplaceWord(word, wordIndex);//decide if it match the replace else keep it 


            if (replacedWord != word)
            {
                count++; // the word replaced by fizz or buzz or fizz buzz so we need to increase count 
            }


            output.Append(replacedWord);//add the word to the end 

            currentWord.Clear();// because we finished the proccess in the current word the clear to recept another on if exists
        }


        private string ReplaceWord(string word, int index)
        {
            if (index % 15 == 0)
                return "FizzBuzz";


            if (index % 3 == 0)
                return "Fizz";


            if (index % 5 == 0)
                return "Buzz";


            return word;
        }
    }
}


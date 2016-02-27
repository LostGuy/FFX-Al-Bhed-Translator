using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_Al_Bhed_Translator
{
    class Translator
    {
        //Create the english dictionary
        private Dictionary<char, char> englishDictionary = new Dictionary<char, char>();

        //Create the english dictionary
        private Dictionary<char, char> alBhedDictionary = new Dictionary<char, char>();

        //Constructor
        public Translator()
        {
            //Add values to the English Dictionary
            englishDictionary.Add('a', 'y');
            englishDictionary.Add('b', 'p');
            englishDictionary.Add('c', 'l');
            englishDictionary.Add('d', 't');
            englishDictionary.Add('e', 'a');
            englishDictionary.Add('f', 'v');
            englishDictionary.Add('g', 'k');
            englishDictionary.Add('h', 'r');
            englishDictionary.Add('i', 'e');
            englishDictionary.Add('j', 'z');
            englishDictionary.Add('k', 'g');
            englishDictionary.Add('l', 'm');
            englishDictionary.Add('m', 's');
            englishDictionary.Add('n', 'h');
            englishDictionary.Add('o', 'u');
            englishDictionary.Add('p', 'b');
            englishDictionary.Add('q', 'x');
            englishDictionary.Add('r', 'n');
            englishDictionary.Add('s', 'c');
            englishDictionary.Add('t', 'd');
            englishDictionary.Add('u', 'i');
            englishDictionary.Add('v', 'j');
            englishDictionary.Add('w', 'f');
            englishDictionary.Add('x', 'q');
            englishDictionary.Add('y', 'o');
            englishDictionary.Add('z', 'w');

            //Add values to the Al Bhed Dictionary
            alBhedDictionary.Add('y', 'a');
            alBhedDictionary.Add('p', 'b');
            alBhedDictionary.Add('l', 'c');
            alBhedDictionary.Add('t', 'd');
            alBhedDictionary.Add('a', 'e');
            alBhedDictionary.Add('v', 'f');
            alBhedDictionary.Add('k', 'g');
            alBhedDictionary.Add('r', 'h');
            alBhedDictionary.Add('e', 'i');
            alBhedDictionary.Add('z', 'j');
            alBhedDictionary.Add('g', 'k');
            alBhedDictionary.Add('m', 'l');
            alBhedDictionary.Add('s', 'm');
            alBhedDictionary.Add('h', 'n');
            alBhedDictionary.Add('u', 'o');
            alBhedDictionary.Add('b', 'p');
            alBhedDictionary.Add('x', 'q');
            alBhedDictionary.Add('n', 'r');
            alBhedDictionary.Add('c', 's');
            alBhedDictionary.Add('d', 't');
            alBhedDictionary.Add('i', 'u');
            alBhedDictionary.Add('j', 'v');
            alBhedDictionary.Add('f', 'w');
            alBhedDictionary.Add('q', 'x');
            alBhedDictionary.Add('o', 'y');
            alBhedDictionary.Add('w', 'z');
        }

        //Translates English to Al Bhed
        public string englishToAlBhed(string input)
        {
            //Make all characters lowercase
            string inputToTranslate = input.ToLower();

            //Holds the translation
            string translation = "";

            //Step through each letter and translate if possible
            for(int i = 0; i < inputToTranslate.Length; i++)
            {
                //Make sure it's a valid character in our dictionary
                if (inputToTranslate[i] < 96 || inputToTranslate[i] > 122)
                {
                    translation += inputToTranslate[i];
                }
                else
                {
                    translation += englishDictionary[inputToTranslate[i]];
                }

            }

            //Return the translation (capitalize the first letter of the sentence)
            return translation.First().ToString().ToUpper() + translation.Substring(1);
        }

        //Translates Al Bhed to English
        public string alBhedToEnglish(string input)
        {
            //Make all characters lowercase
            string inputToTranslate = input.ToLower();

            //Holds the translation
            string translation = "";

            //Step through each letter and translate if possible
            for (int i = 0; i < inputToTranslate.Length; i++)
            {
                //Make sure it's a valid character in our dictionary
                if (inputToTranslate[i] < 96 || inputToTranslate[i] > 122)
                {
                    translation += inputToTranslate[i];
                }
                else
                {
                    translation += alBhedDictionary[inputToTranslate[i]];
                }

            }

            //Return the translation (capitalize the first letter of the sentence)
            return translation.First().ToString().ToUpper() + translation.Substring(1);
        }
    }
}

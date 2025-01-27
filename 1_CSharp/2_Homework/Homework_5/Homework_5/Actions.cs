using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public class Actions
    {
        public void stringConcat(string word1, string word2)
        { 
            string word3 = string.Concat(word1 + word2);
            Console.WriteLine(word3);
        }
        public void stringEquals(string word3, string word4)
        {
            if (word3.Equals(word4, StringComparison.Ordinal))
            {
                Console.WriteLine("word3 and word4 are not equal");
            }
            else
            {
                Console.WriteLine("word3 and word4 are equal");
            }
        }
        public void stringContains(string text, string word5)
        {
            if (text.Contains(word5))
            {
                Console.WriteLine("Referans metin içerisinde aranan deger bulunmaktadir");
            }
            else
            {
                Console.WriteLine("Referans metin içerisinde aranan deger bulunmamaktadir");
            };
        }
        public void stringSubstring(string text1, int startIndex, int endIndex)
        {
            string altString = text1.Substring(startIndex, endIndex);
            Console.WriteLine(altString);
        }
        public void stringInsert(string text2, int startIndex1, string adedWord)
        {
            string newString = text2.Insert(startIndex1, adedWord);
            Console.WriteLine(newString);
        }
        public void stringRemove(string text3, string deleteString)
        {
            int index = text3.IndexOf(deleteString);
            string newText = text3.Remove(index, deleteString.Length);
            Console.WriteLine(newText);
        }
        public void stringSplit(string text4, char bracket)
        {
            string[] words = text4.Split(bracket);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
        public void stringReplace(string text5, string replaceText, string newText2)
        {
            string newText5 = text5.Replace(replaceText, newText2);
            Console.WriteLine(newText5);
        }
        public void stringTrim(string textTrim)
        {
            string trimmedText = textTrim.Trim();
            Console.WriteLine(trimmedText);
        }
        public void stringIndexOf(string text6, string textSearch)
        {
            int index = text6.IndexOf(textSearch);
            Console.WriteLine(index);
        }
        public void personelİnfo()
        {

        }
    }
}

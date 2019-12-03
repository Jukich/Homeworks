using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "My name is Maria and I have bicycle";
            Translator(ref str);
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(str);

            Task2();


        }

        public static void Translator(ref string originalString)
        { 

            Dictionary<string, string> translator = new Dictionary<string, string>();
            translator.Add("name", "име");
            translator.Add("eat", "ям");
            translator.Add("sleep", "спя");
            translator.Add("My", "Mоето");
            translator.Add("bicycle", "колело");
            string translatedString = "";

            foreach (string subString in originalString.Split(new char[] { ' ', '.' }))
            {
                bool flag = false;
                foreach (KeyValuePair<string, string> word in translator)
                {
                    if (word.Key.Equals(subString))
                    {
                        translatedString += word.Value + " ";
                        flag = true;
                        break;
                    }

                }
                if (flag == false)
                    translatedString += subString + " ";
            }

            originalString = translatedString;

        }

        public static void Task2()
        {
            /* 2.Напишете програма, която приема 20 думи и показва по колко пъти се среща всяка една от тях.*/

            string str =
                "Your name is not Maria and I have motorcycle " +
                "My name is not Maria and I have bicycle " +
                "My name is Maria and I have motorcycle " +
                "My surename is Maria and I ride bicycle " +
                "I am Maria and I have bicycle " +
                "My surename is Marieva and I have car";

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach(string subString in str.Split(' '))
            {
                if (wordCount.ContainsKey(subString))
                {
                       wordCount[subString]++;

                }
                else
                {
                    wordCount.Add(subString, 1);
                }
            }
            foreach (KeyValuePair<string, int> word in wordCount.OrderBy(a=>a.Key))
            {
                Console.WriteLine("Word: " +word.Key + "\nCount: " + word.Value+"\n");
            }


        }
    }
}

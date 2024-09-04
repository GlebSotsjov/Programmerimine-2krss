using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
{
    internal class WordCount
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine().ToLower();


            Console.WriteLine($"Input received: {input}");

            // Разбиваем предложение на слова
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine("Words detected:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Словарь для хранения количества каждого слова
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }


            if (wordCount.Count == 0)
            {
                Console.WriteLine("No words were counted. Please check the input.");
            }
            else
            {
                // Выводим результат
                Console.WriteLine("Количество каждого слова в предложении:");
                foreach (var item in wordCount)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}





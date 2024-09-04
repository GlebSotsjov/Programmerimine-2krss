using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{

    class Program
    {
        // Основной словарь, где ключ — это мааконд, а значение — столица
        static Dictionary<string, string> countyToCapital = new Dictionary<string, string>()
        {
            { "Harju", "Tallinn" },
            { "Tartu", "Tartu" },
            { "Pärnu", "Pärnu" },
            { "Ida-Viru", "Jõhvi" },
            { "Lääne-Viru", "Rakvere" }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Valige toiming: ");
                Console.WriteLine("1: Otsi maakonna järgi pealinna");
                Console.WriteLine("2: Otsi pealinna järgi maakonda");
                Console.WriteLine("3: Lisa uus maakond ja pealinn");
                Console.WriteLine("4: Testi oma teadmisi");
                Console.WriteLine("5: Välju");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SearchByCounty();
                        break;
                    case "2":
                        SearchByCapital();
                        break;
                    case "3":
                        AddNewCountyAndCapital();
                        break;
                    case "4":
                        TestKnowledge();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Vale valik, proovi uuesti.");
                        break;
                }
            }
        }

        // Функция для поиска столицы по названию мааконда
        static void SearchByCounty()
        {
            Console.WriteLine("Sisestage maakonna nimi:");
            string county = Console.ReadLine();
            if (countyToCapital.ContainsKey(county))
            {
                Console.WriteLine($"Maakonna {county} pealinn on {countyToCapital[county]}.");
            }
            else
            {
                Console.WriteLine("Seda maakonda pole sõnastikus.");
            }
        }

        // Функция для поиска мааконда по названию столицы
        static void SearchByCapital()
        {
            Console.WriteLine("Sisestage pealinna nimi:");
            string capital = Console.ReadLine();
            string county = countyToCapital.FirstOrDefault(x => x.Value == capital).Key;
            if (county != null)
            {
                Console.WriteLine($"Pealinn {capital} asub maakonnas {county}.");
            }
            else
            {
                Console.WriteLine("Seda pealinna pole sõnastikus.");
            }
        }

        // Функция для добавления новой пары мааконд-пеаллин в словарь
        static void AddNewCountyAndCapital()
        {
            Console.WriteLine("Sisestage uus maakonna nimi:");
            string newCounty = Console.ReadLine();
            Console.WriteLine("Sisestage selle maakonna pealinn:");
            string newCapital = Console.ReadLine();

            if (!countyToCapital.ContainsKey(newCounty))
            {
                countyToCapital.Add(newCounty, newCapital);
                Console.WriteLine("Uus maakond ja pealinn on lisatud sõnastikku.");
            }
            else
            {
                Console.WriteLine("See maakond on juba olemas sõnastikus.");
            }
        }

        // Функция для тестирования знаний пользователя
        static void TestKnowledge()
        {
            int correctAnswers = 0;
            int totalQuestions = 0;

            // Перемешиваем список вопросов
            var random = new Random();
            var shuffledCounties = countyToCapital.OrderBy(x => random.Next()).ToList();

            foreach (var pair in shuffledCounties)
            {
                Console.WriteLine($"Mis maakonnas asub pealinn {pair.Value}?");
                string answer = Console.ReadLine();
                totalQuestions++;

                if (answer.Equals(pair.Key, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Õige!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus on {pair.Key}.");
                }
            }

            // Подсчитываем и выводим результат тестирования
            double score = (double)correctAnswers / totalQuestions * 100;
            Console.WriteLine($"Teie tulemus: {correctAnswers}/{totalQuestions} ({score}%)");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp
{
    internal class hw5String
    {
        public static void TaskString(string str)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            StringBuilder menu = new StringBuilder("\nВыберите задачу:\n");
            menu.Append("1. Найти слова, содержащие максимальное количество цифр.\n");
            menu.Append("2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.\n");
            menu.Append("3. Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».\n");
            menu.Append("4. Вывести на экран сначала вопросительные, а затем восклицательные предложения.\n");
            menu.Append("5. Вывести на экран только предложения, не содержащие запятых.\n");
            menu.Append("6. Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.\n");
            menu.Append("7. Добавить возможность поиска по части ввода. ( не учитывать регистр)\n");
            menu.Append("8. Вывести палиндромы, если они есть.\n");
            menu.Append("9. Вывести строку.\n");
            menu.Append("0. Выйти из программы.\n");

            int operation = 1;

            while (operation != 0)
            {
                Console.WriteLine(menu);

                if (!int.TryParse(Console.ReadLine(), out operation) || operation > 9)
                {
                    Console.WriteLine("Некорректный ввод.\n");
                    continue;
                }

                switch (operation)
                {
                    case 1:
                        MaxNumQty(str);
                        break;
                    case 2:
                        LongestWord(str);
                        break;
                    case 3:
                        ReplaceNumbers(str);
                        break;
                    case 4:
                        Sentences(str);
                        break;
                    case 5:
                        SentencesWithoutComma(str);
                        break;
                    case 6:
                        WordsFirstLetter(str);
                        break;
                    case 7:
                        Search(str);
                        break;
                    case 8:
                        Palindroms(str);
                        break;
                    case 9:
                        Console.WriteLine(str);
                        break;
                    default:
                        break;
                }
            }

            //1. Найти слова, содержащие максимальное количество цифр.
            void MaxNumQty(string _str)
            {
                string[] wordsWithNumbers = _str.Split(new char[] { ';', ',', ' ', '!', '?', '.' });
                string[] words = wordsWithNumbers.Where(x => x.Any(char.IsLetter)).ToArray();

                Dictionary<int, int> dictNumCount = new Dictionary<int, int>();

                for (int i = 0; i < words.Length; i++)
                {
                    dictNumCount.Add(i, 0);

                    char[] letters = words[i].ToCharArray();

                    foreach (char letter in letters)
                    {
                        if (Char.IsDigit(letter))
                        {
                            dictNumCount[i]++;
                        }
                    }
                }

                int maxN = dictNumCount.Values.Max();
                Console.WriteLine("Cлова, содержащие максимальное количество цифр: \n");

                for (int i = 0; i < dictNumCount.Count; i++)
                {
                    if (dictNumCount[i] == maxN)
                    {
                        Console.Write(words[i] + " ");
                    }
                }
            }


            //2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
            void LongestWord(string _str)
            {
                string[] words = _str.Split(new char[] { ';', ',', ' ', '!', '?', '.' });

                HashSet<string> longestWords = new HashSet<string>();
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                int maxLength = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }

                    if (maxLength < word.Length)
                    {
                        longestWords.Clear();
                        maxLength = word.Length;
                        longestWords.Add(word);
                    }
                    else if (maxLength < word.Length)
                    {
                        longestWords.Add(word);
                    }

                }

                Console.WriteLine("Самые длинные слова и сколько раз они встречались в тексте:");
                foreach (string w in longestWords)
                {
                    Console.WriteLine($"{w} \t- {wordCount[w]}");
                }
            }

            //3. Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
            void ReplaceNumbers(string _str)
            {
                string newStr = "";

                Dictionary<String, string> dictReplace = new Dictionary<String, string>();

                dictReplace.Add("0", "ноль");
                dictReplace.Add("1", "один");
                dictReplace.Add("2", "два");
                dictReplace.Add("3", "три");
                dictReplace.Add("4", "четыре");
                dictReplace.Add("5", "пять");
                dictReplace.Add("6", "шесть");
                dictReplace.Add("7", "семь");
                dictReplace.Add("8", "восемь");
                dictReplace.Add("9", "девять");

                for (int i = 0; i < dictReplace.Count; i++)
                {
                    newStr = _str.Replace($"{i}", dictReplace[$"{i}"]);
                    _str = newStr;
                }

                Console.WriteLine(newStr);
            }

            //4. Вывести на экран сначала вопросительные, а затем восклицательные предложения.
            void Sentences(string _str)
            {
                string[] sentences = Regex.Split(_str, @"(?<![A-Z][a-z]\.)(?<=\.|\?|\!)\s");

                foreach (var w in sentences)
                {
                    if(w.Last() == '?')
                    {
                        Console.WriteLine(w);
                    }
                }

                foreach (var w in sentences)
                {
                    if (w.Last() == '!')
                    {
                        Console.WriteLine(w);
                    }
                }
            }

            //5. Вывести на экран только предложения, не содержащие запятых.
            void SentencesWithoutComma(string _str)
            {
                string[] sentences = Regex.Split(_str, @"(?<![A-Z][a-z]\.)(?<=\.|\?|\!)\s");

                foreach (var w in sentences)
                {
                    if (!w.Contains(','))
                    {
                        Console.WriteLine(w);
                    }
                }
            }

            //6. Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
            void WordsFirstLetter(string _str)
            {
                var words = Regex.Matches(_str, @"\b\w+\b").Select(x => x.Value.ToLower()).ToList().Where(w => w.First() == w.Last() && w.Length > 1);

                foreach (var w in words)
                {
                    Console.WriteLine(w);
                }
            }

            //7. Добавить возможность поиска по части ввода. ( не учитывать регистр)
            void Search(string _str)
            {
                string strLower = _str.ToLower();

                Console.WriteLine("Введите строку для поиска:");

                string search = Console.ReadLine().ToLower();
                var words = Regex.Matches(strLower, search).ToList().Count > 0;

                if (Regex.Matches(strLower, search).ToList().Count > 0)
                {
                    Console.WriteLine("Найдена такая подстрока.");
                }
                else
                {
                    Console.WriteLine("Такая подстрока не найдена.");
                }
            }

            //8. Вывести палиндромы, если они есть.
            void Palindroms(string _str)
            {
                var words = Regex.Matches(_str, @"\b\w+\b").Select(x => x.Value.ToLower()).ToList().Where(w => w.Length > 1);

                foreach (var w in words)
                {
                    int palindrom = 1;
                    for (var i = 0; i < w.Length/2; i++)
                    {
                        if (w[i] != w[w.Length - i - 1])
                        {
                            palindrom = 0;
                            break;
                        }
                    }

                    if (palindrom == 1)
                    {
                        Console.WriteLine(w);
                    }
                }
            }
        }
    }
}

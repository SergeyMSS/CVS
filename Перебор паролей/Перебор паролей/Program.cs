using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Перебор_паролей
{
    //Вася забыл пароль от своего почтового ящика, но он отчетливо помнит, что его пароль содержал только буквы a, b и с. Посмотрев предыдущее видео Вася легко написал программу перебора всех паролей заданной длины, содержащих лишь две различные буквы. Но ведь его пароль может содержать три различные буквы!
    //Исправьте программу так, чтобы она перебирала все слова из букв a, b, c в лексикографическом порядке.

    class Program
    {
        static void Main(string[] args)
        {
            WriteAllWordsOfSize(1);
            WriteAllWordsOfSize(2);
            WriteAllWordsOfSize(0);
            WriteAllWordsOfSize(4);

        }

        static void WriteAllWordsOfSize(int size)
        {
            MakeSubsets(new char[size]);
        }



        static void MakeSubsets(char[] subset, int position = 0)
        {
            if (position == subset.Length)
            {
                Console.WriteLine(new string(subset));
                return;
            }
            subset[position] = 'a';
            MakeSubsets(subset, position + 1);
            subset[position] = 'b';
            MakeSubsets(subset, position + 1);
            subset[position] = 'c';
            MakeSubsets(subset, position + 1);
        }
    }
}

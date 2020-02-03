using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Применение_ref
{
    // В этой задаче демонстрируется один из редких случаев, когда уместно использовать ref.

    class Program
    {
        static void Main(string[] args)
        {
            WriteAllNumbersFromText("23 4   43 23 3423");
        }


        // SkipSpaces пропускает все пробельные символы в text, начиная с позиции pos. В конце pos оказывается установлен в первый непробельный символ.
        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }


        // ReadNumber пропускает все цифры в text, начиная с позиции pos, а затем возвращает все пропущенные символы. В конце pos оказывается установлен в первый символ не цифру.
        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }


        // Допишите функцию, которая читает все числа из строки и выводит их, разделяя единственным пробелом.
        public static void WriteAllNumbersFromText(string text)
        {
            int pos = 0;
            while (true)
            {
                // skip space
                SkipSpaces(text, ref pos);
                //read next number
                var num = ReadNumber(text, ref pos);
                if (num == "")
                    break;
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

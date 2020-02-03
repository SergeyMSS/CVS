using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    public class RightBorderTask
    {
        /// <returns>
        /// Возвращает индекс правой границы. 
        /// То есть индекс минимального элемента, который не начинается с prefix и большего prefix.
        /// Если такого нет, то возвращает items.Length
        /// </returns>
        /// <remarks>
        /// Функция должна быть НЕ рекурсивной
        /// и работать за O(log(items.Length)*L), где L — ограничение сверху на длину фразы
        /// </remarks>
        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            //IReadOnlyList похож на List, но у него нет методов модификации списка.
            // Этот код решает задачу, но слишком неэффективно. Замените его на бинарный поиск!

            #region 1
            while (left < right)
            {
                var middle = (left + right) / 2;
                if (string.Compare(prefix, phrases[middle], StringComparison.OrdinalIgnoreCase) < 0)
                    right = middle;
                else if (phrases[middle].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    return middle;
                }
                else
                    left = middle + 1;
            }

            if (phrases[right] == prefix)
                return right + 1;
            return prefix.Length - 1;
            #endregion


            //for (int i = phrases.Count - 1; i >= 0; i--)
            //{
            //    if (string.Compare(prefix, phrases[i], StringComparison.OrdinalIgnoreCase) >= 0
            //        || phrases[i].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            //        return i + 1;
            //}
            //return 0;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoHW2
{
    static class BinSearch
    {
        // Задание 2 (двоичный поиск)
        // Сложность O(log n) - алгоритм проходит дополнительную итерацию каждый раз, когда изменяется количество данных
        /// <summary>Осуществляет двоичный поиск в массиве целочисленного типа</summary>
        /// <param name="array">Массив для передачи в качечтве параметра</param>
        /// <param name="term">Ключ для поиска</param>
        /// <returns>Индекс элемента - если он найден, в противном случае -1</returns>
        public static int BinarySearch(int[] array, int term) {
            int l = 0;
            int h = array.GetLength(0) - 1;


            while (l <= h) {
                int mid = (h + l) / 2;
                int mv = array[mid];
                if (mv > term) {
                    h = mid - 1;
                }
                else if (mv < term) {
                    l = mid + 1;
                }
                else return mid;
            }
            return -1;
        }
    }
}

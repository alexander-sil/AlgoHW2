using System;
using DynalistNamespace;

namespace AlgoHW2 {
    class Program {
        static void Main(string[] args) {

            // Проверочный код для двусвязного списка (задание 1)
            Console.WriteLine("Двусвязный список");
            // Создание объекта
            DoubleLinkedList dllist = new DoubleLinkedList();
            // Число элементов в массиве
            int len = dllist.GetCount();
            // Проверка наличия элемента в двусвязном списке
            dllist.AddNode(11);
            // True
            Console.WriteLine(dllist.Contains(11).ToString());
            // False
            dllist.RemoveNode(dllist.FindNode(11));
            Console.WriteLine(dllist.Contains(11).ToString());

            // Добавление элементов
            dllist.AddNode(11);
            dllist.AddNode(44);
            dllist.AddNode(77);
            dllist.AddNode(88);
            dllist.AddNode(99);
            // Вставка элементов
            dllist.AddNodeAfter(dllist.FindNode(11), 22);
            // Удаление элементов по ссылке на объект узла
            dllist.RemoveNode(dllist.FindNode(99));
            // Удаление элементов по индексу
            dllist.RemoveNode(4);
            
            
            
            // Вывод элементов
            int i = 0;
            Node head = dllist.FindNode(11);
            while (head != null) {
               Console.WriteLine(head.value.ToString());
               head = head.next;
               i++;
            }
            // Вывод количества элементов
            Console.WriteLine(dllist.GetCount());

            // Проверочный код для бинарного поиска (задание 2)
            int[] arr = { 1,2,3,4,5 };
            string index = BinSearch.BinarySearch(arr, 2).ToString();
            Console.WriteLine("Бинарный поиск");
            // Индекс найденного элемента
            // 1
            Console.WriteLine(index);
           

            
            
            Console.WriteLine("Выполнение завершено");
            Console.ReadKey(true);
        }
    }
}

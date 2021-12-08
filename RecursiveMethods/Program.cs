using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayNumbers(1, 10);
            DisplayNumbersRecursive(1, 10);
            List<int> list = new List<int>()
            {
                1, 2, 3
            };
            int? result = FindItemByLoop(list, 2);
            //if (result == null)
            if (!result.HasValue)  // yukardakinin aynisi.
                Console.WriteLine("sayi bulunamadi");
            else
                Console.WriteLine(result.Value + "sayi bulundu.");

            result = FindItemByRecursion(list, 4);
            if (!result.HasValue)
                Console.WriteLine("sayi yok.");
            else
                Console.WriteLine(result.Value + "sayi bulundu.");
                

            

            Console.ReadLine();
        }

        static void DisplayNumbers(int start, int end, int increment = 1)
        {
            for (int i = start; i <= end; i+= increment)
            {
                Console.WriteLine(i);
            }

        }

        static void DisplayNumbersRecursive(int start, int end, int increment = 1)
        {
            if (start > end)
                return;
            Console.WriteLine(start);
            start += increment;
            DisplayNumbersRecursive(start, end, increment);
        }

        static int? FindItemByLoop(List<int> list, int itemToFind)   //static int tanimlamistik, int? yaptik alttaki icin.
        {
            int? result = null; // NULLABLE INT "?"  int?   soru isareti int/double/bool/char icin kullanabilirsin. Bir soruya null atarak ariza aliyorsan "?" koycaz nullable yapcaz.
            foreach (int item in list)
            {
                if (item == itemToFind)
                    result = item;
                break;

            }

            return result;

        }

        static int? FindItemByRecursion(List<int> list, int itemToFind, int? result = null)
        {

            if (list[0] == itemToFind)
            {
                result = list[0];
            }

            else
            {
                list.RemoveAt(0); //listenin en basindaki elemani sil, her dongude.
                if (list.Count > 0)
                    result = FindItemByRecursion(list, itemToFind); 
            }

            return result;

        }
    }
}

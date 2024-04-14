using System;

class Program
{
    // Tartiblangan ruyxatda binary qidiruv algoritmi
    static int BinarySearch(int[] array, int target)
    {
        int left = 0; // o- indexdan boshlab
        int right = array.Length - 1; // oxirgi index gacha

        while (left <= right) // shart asosida
        {
            int mid = left + (right - left) / 2; // har sikl aylanganda ruyxatni teng ikkiga bulish

            // Agar qidirilayotgan elementni topgan bo'lsak, indeksni qaytarib beramiz
            if (array[mid] == target)
                return mid;

            // Agar qidirilayotgan element ortidagi elementdan kichik bo'lsa, 
            // o'ng tomonini qisqartiramiz
            if (array[mid] < target)
                left = mid + 1;
            // Aks holda, chap tomonini qisqartiramiz
            else
                right = mid - 1;
        }

        // Element topilmagan holatda -1 qaytaradi
        return -1;
    }

    static void Main()
    {
        int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = 12;
        int result = BinarySearch(array, target);
        if (result != -1)
            Console.WriteLine("Element {0} tartib raqami: {1}", target, result);
        else
            Console.WriteLine("Element topilmadi");
    }
}

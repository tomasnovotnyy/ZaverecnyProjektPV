using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class HeapSort
    {
        // Metode přijímá pole celých čísel
        public static string Sort(int[] arr)
        {
            // Získání délky pole 'n'
            int n = arr.Length;

            // Provedení inicializace haldy pomocí for cyklu, sestupně od poloviny pole až po první prvek
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                // Volání metody Heapify zajišťuje, že strom splňuje vlastnosti haldy
                Heapify(arr, n, i);
            }

            // For cyklus sloužící k výměně prvků a opětovnému sestavení haldy
            // Tento for cyklus iteruje od konce pole až po první prvek a v každé iteraci se provede výměna 1. prvku s aktuálním prvkem, který je na řadě. Následně se zavolá metoda Heapify
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }

            string result = "";
            for (int i = 0; i < n; ++i)
            {
                result += arr[i] + " ";
            }

            // Vracení řetězce 'result' po odstranění poslední mezery pomocí metody -> result.TrimEnd()
            return result.TrimEnd();
        }

        // Metoda Heapify slouží k sestavení haldy
        // int[] arr = pole, int n = velikost haldy, int i = index vrcholu
        private static void Heapify(int[] arr, int n, int i)
        {
            // nastavení hodnoty 'largest' na hodnotu indexu 'i'
            int largest = i;
            // Výpočet indexu levého potomka
            int l = 2 * i + 1;
            // Výpočet indexu pravého potomka
            int r = 2 * i + 2;

            // Porovnání hodnot levého a pravého potomka s hodnotou vrcholu 'largest'
            // Pokud je hodnota levého nebo pravého potomka větší než hodnota vrcholu 'largest', aktualizuje se hodnota 'largest'
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            // Pokud se hodnota 'largest' změnila, dojde k výměně prvků mezi vrcholem 'i' a vrcholem 'largest' v poli 'arr'
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Rekurzivní volání metody Heapify
                Heapify(arr, n, largest);
            }
        }
    }
}

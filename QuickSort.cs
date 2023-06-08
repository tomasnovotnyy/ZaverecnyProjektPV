using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class QuickSort
    {
        // Tato metoda přijímá pole 'arr' a hranice 'left' a 'right' pro ohraničení řazené části pole
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                Sort(arr, left, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, right);
            }
        }

        // Tato metoda slouží k rozdělení části pole kolem pivota
        private static int Partition(int[] arr, int left, int right)
        {
            // Výpočet indexu pivota jako průměru levé a pravé hranice
            int pivotIndex = (left + right) / 2;
            // Uložení hodnoty pivota ze vstupního pole
            int pivotValue = arr[pivotIndex];
            // Prohození hodnoty pivota s prvkem na pravé hranici
            Swap(arr, pivotIndex, right);

            // Inicializace proměnné "storeIndex" na hodnotu levé hranice
            int storeIndex = left;
            // Procházení prvků od levé hranice do pravé hranice (bez posledního prvku)
            for (int i = left; i < right; i++)
            {
                // Pokud je prvek menší než hodnota pivota:
                if (arr[i] < pivotValue)
                {
                    // Prohození aktuálního prvku s prvkem na pozici "storeIndex"
                    Swap(arr, i, storeIndex);
                    // Inkrementace hodnoty 'storeIndex'
                    storeIndex++;
                }
            }
            // Prohození hodnoty pivota s prvkem na pozici 'storeIndex'
            Swap(arr, storeIndex, right);
            // Vrácení 'storeIndex' jako nového indexu pivota
            return storeIndex;
        }

        // Tato metoda slouží k prohození dvou prvků v poli
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
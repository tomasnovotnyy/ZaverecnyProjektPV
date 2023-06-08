using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class ReverseEncoding
    {
        public static string Encode(string input)
        {
            // Převedení řetězce na pole znaků pomocí metody -> ToCharArray()
            char[] charArray = input.ToCharArray();
            // Metoda Array.Reverse() slouží k obrácení pořadí prvků v poli
            Array.Reverse(charArray);
            // Vytvoření nového řetězce pomocí konstruktoru třídy 'string'
            return new string(charArray);
        }

        // Tato metoda slouží jako inverzní operace k metodě 'Encode'
        public static string Decode(string input)
        {
            // Převedení řetězce na pole znaků pomocí metody -> ToCharArray()
            char[] charArray = input.ToCharArray();
            // Metoda Array.Reverse() slouží k obrácení pořadí prvků v poli
            Array.Reverse(charArray);
            // Vytvoření nového řetězce pomocí konstruktoru třídy 'string'
            return new string(charArray);
        }
    }
}

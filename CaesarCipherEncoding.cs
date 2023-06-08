using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class CaesarCipherEncoding
    {
        public static string Encode(string input)
        {
            // Vrácení zakódovaného řetězce 'input' posunutého o 3 pozice doprava pomocí metody -> ShiftCharacters(input, 3)
            return ShiftCharacters(input, 3);
        }

        public static string Decode(string input)
        {
            // Vrácení dekódovaného řetězce 'input' posunutého o 3 pozice doleva pomocí metody -> ShiftCharacters(input, -3)
            return ShiftCharacters(input, -3);
        }

        // string 'input' je zde uživatelem zadaný text a int 'shift' je  parametr, který určuje počet pozic posunu
        private static string ShiftCharacters(string input, int shift)
        {
            // Vytvoření prázdného řetězce, který bude obsahovat výsledný posunutý řetězec
            string encodedString = string.Empty;

            // Tento for cyklus iteruje přes každý znak 'a' ve vstupním řetězci 'input'
            foreach (char a in input)
            {
                // Kontrola, zda je znak 'a' písmeno pomocí metody -> char.IsLetter(a)
                if (char.IsLetter(a))
                {
                    // Určíme, zda je písmeno velké nebo malé pomocí metody -> char.IsUpper(a)
                    // Pokud je písmeno velké, je nastavena proměnná 'baseChar' na hodnotu 'A', jinak na hodnotu 'a'. Tím se získá referenční znak 'A' nebo 'a', od kterého bude probíhat následující posun
                    char baseChar = char.IsUpper(a) ? 'A' : 'a';
                    // Posun znaku o hodnotu 'shift' a 26, přičemž číslo 26 je počet písmen v anglické abecedě. Přetypování výsledku zpět na 'char' a uložení do proměnné 'shiftedChar'
                    char shiftedChar = (char)((((a - baseChar) + shift + 26) % 26) + baseChar);
                    // Připojení znaku 'shiftedChar' k stringu 'encodedString'
                    encodedString += shiftedChar;
                }
                else
                {
                    // Pokud znak 'a' není písmeno, je rovnou připojen k stringu 'encodedString'
                    encodedString += a;
                }
            }
            // Vrácení posunutého řetězce
            return encodedString;
        }
    }
}

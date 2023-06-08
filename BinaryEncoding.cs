using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class BinaryEncoding
    {

        // Zakódování vstupního řetězce do binární podoby
        public static string Encode(string input)
        {
            // Vytvoření prázdného řetězce, který bude obsahovat zakódováný výstup
            string encodedString = string.Empty;

            foreach (char a in input)
            {
                // Při každé iteraci je znak 'a' převeden na binární hodnotu pomocí metody -> Convert.ToString(a, 2), přičemž argument '2' znamená, že chceme binární reprezentaci
                // Metoda PadLeft(8, '0') doplní binární řetězec binary na délku 8 bitů pomocí znaku '0', to ale pouze v případě, že byl původní binární řetězec kratší
                string binary = Convert.ToString(a, 2).PadLeft(8, '0');
                // Připojení stringu 'binary' k stringu 'encodedString'
                encodedString += binary;
            }
            // Vrácení zakódovaného řetězce
            return encodedString;
        }

        public static string Decode(string input)
        {
            // Vytvoření prázdného řetězce, který bude obsahovat dekódováný výstup
            string decodedString = string.Empty;

            // Tento for cyklus iteruje s krokem 8, aby byla délka řetězce v metodě 'Decode' shodná s délkou řetězce z metody 'Encode'
            for (int i = 0; i < input.Length; i += 8)
            {
                // V každé iteraci vyberu 8 znaků binárního řetězce pomocí metody -> Substring(i, 8), kde 'i' je aktuální index a následně je uložím do stringu 'binary'
                string binary = input.Substring(i, 8);
                // Řetězec 'binary' je zde převeden na číselnou hodnotu pomocí metody Convert.ToInt32(binary, 2), kde argument '2' znamená, že se jedná o binární číslo. Nakonec je výsledek přetypován na char a uložen do proměnné 'a'
                char a = (char)Convert.ToInt32(binary, 2);
                // Připojení znaku 'a' k stringu 'decodedString'
                decodedString += a;
            }
            // Vrácení dekódovaného řetězce
            return decodedString;
        }
    }
}

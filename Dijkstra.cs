using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class Dijkstra
    {
        // int[] distance = vzdálenost mezi vrcholy, bool[] shortestPathTreeSet = kotnrola, zda je vrchol součástí nejkratší cesty, int verticesCount = počet vrcholů 
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            // Nastavení největší možné hodnoty
            int min = int.MaxValue;
            // Nastavení na nulu
            int minIndex = 0;

            // For cyklus, který iteruje přes všechny vrcholy v grafu, kde 'v' slouží jako index vrcholu
            for (int v = 0; v < verticesCount; ++v)
            {
                // Kontrola, zda je vrchol 'v' ještě neoznačený a zda je jeho vzdálenost menší nebo rovna minimální hodnotě 'min'
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    // Aktualizace hodnoty 'min' na novou minimální vzdálenost a 'minIndex' na index vrcholu 'v'
                    min = distance[v];
                    minIndex = v;
                }
            }
            // Vrácení indexu vrcholu s nejmenší vzdáleností, který zároveň není součástí nejkratší cesty
            return minIndex;
        }

        // int[,] graph = matice sousednosti grafu, int source = počáteční/zdrojový vrchol, int verticesCount = počet vrcholů 
        public static string DijkstraAlgo(int[,] graph, int source, int verticesCount)
        {
            // Inicializace pole pro vzdálenost a nejkratší cestu
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            // Všechny vzdálenosti jsou nastaveny na nekonečno a booly na false -> žádný vrchol zatím není součástí nejkratší cesty
            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }
            // Vzdálenost počátečního vrcholu je nastavena na 0
            distance[source] = 0;

            // Tento for cyklus probíhá (verticesCount - 1)krát 
            for (int count = 0; count < verticesCount - 1; ++count)
            {
                // Hledání vrcholu 'u' s nejmenší vzdáleností, který ještě není součástí nejkratší cesty.
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                // Označení tohoto vrcholu jako součást nejkratší cesty
                shortestPathTreeSet[u] = true;

                // Aktualizování vzdálenosti pro všechny sousední vrcholy vrcholu 'u'. Pokud je sousední vrchol 'v' ještě neoznačený a existuje hrana mezi 'u' a 'v', je zkontrolováno, zda je nová vzdálenost menší než stávající vzdálenost. Pokud ano, je aktualizována vzdálenost 'v' na novou hodnotu
                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            // Vypsání vzdáleností vrcholů
            string result = "";
            for (int i = 0; i < verticesCount; ++i)
            {
                result += $"Vrchol {i} --> Vzdálenost od počátku = {distance[i]}\n";
            }
            // Vrácení tohoto řetězce
            return result;
        }
    }
}

using System;

namespace ZaverecnyProjekt
{
    public class Graph
    {
        // Deklarace kořenového vrcholu stromu
        public Node root;

        // Nastavení počáteční hodnoty atributu 'root' na 'null'
        public Graph()
        {
            root = null;
        }

        // Metoda pro nastavení kořene stromu
        public void SetRoot(Node root)
        {
            this.root = root;
        }

        // Metoda pro získání kořene stromu
        public Node GetRoot()
        {
            return root;
        }

        // Metoda pro výpočet počtu vrcholů ve stromu
        public int CountNodes(Node node)
        {
            // Rekurzivní počítání počtu vrcholů v levém podstromu a v pravém podstromu a následné přidávání k výslednému počtu vrcholů
            int count = 1;
            if (node == null)
            {
                return 0;
            }
            else
            {
                count += CountNodes(node.GetLeft());
                count += CountNodes(node.GetRight());
                return count;
            }
        }

        // Metoda pro vložení nové hodnoty do stromu
        public void VlozeniHodnoty(Node node, int value)
        {
            // Porovnávání hodnoty 'value' s hodnotou aktuálního vrcholu -> na základě toho se rozhodne, zda vložit hodnotu do levého nebo pravého podstromu
            // Pokud je vrchol v daném směru již obsazený, metoda se rekurzivně zavolá na tento vrchol
            // Pokud je vrchol v daném směru volný, vloží se nový vrchol s hodnotou 'value' a vypíše se informace o vložení do konzole
            if (value < node.value)
            {
                if (node.left != null)
                {
                    VlozeniHodnoty(node.left, value);
                }
                else
                {
                    Console.WriteLine("Cislo " + value + " pridano z leva od hodnoty " + node.value);
                    node.left = new Node(value);
                }
            }
            else if (value > node.value)
            {
                if (node.right != null)
                {
                    VlozeniHodnoty(node.right, value);
                }
                else
                {
                    Console.WriteLine("Cislo " + value + " pridano z prava od hodnoty " + node.value);
                    node.right = new Node(value);
                }
            }
        }

        // Metody "InOrder", "PreOrder" a "PostOrder" slouží k průchodu stromem a vrácení hodnot ve vrcholech v pořadí In-order, Pre-order a Post-order
        // Každá z těchto metod přijímá jako parametr objekt "node" typu "Node", který představuje aktuální vrchol
        // Metody rekurzivně volají samy sebe na levém a pravém podstromu a sestavují výsledný řetězec obsahující hodnoty ve správném pořadí
        public string InOrder(Node node)
        {
            string output = "";
            if (node != null)
            {
                output += InOrder(node.GetLeft());
                output += " " + node.value;
                output += InOrder(node.GetRight());
            }
            return output;
        }

        public string PreOrder(Node node)
        {
            string output = "";
            if (node != null)
            {
                output += " " + node.value;
                output += PreOrder(node.GetLeft());
                output += PreOrder(node.GetRight());
            }
            return output;
        }

        public string PostOrder(Node node)
        {
            string output = "";
            if (node != null)
            {
                output += PostOrder(node.GetLeft());
                output += PostOrder(node.GetRight());
                output += " " + node.value;
            }
            return output;
        }
    }
}
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ZaverecnyProjekt
{
    public class Node
    {
        public int value; // Proměnná pro uložení hodnoty uzlu
        public Node left; // Proměnná pro odkaz na levého potomka
        public Node right; // Proměnná pro odkaz na pravého potomka

        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        // Veřejná metoda pro výpis obsahu stromu v lidsky čitelné podobě
        public string PrintTree()
        {
            // Vytvoření prázdného řetězce
            string result = "";
            if (right != null)
            {
                // Rekurzivní volání metody PrintTree na pravém potomkovi s parametrem 'isRight' nastaveným na true
                result += right.PrintTree(true, "", "");
            }
            result += value.ToString() + "\n";
            if (left != null)
            {
                // Rekurzivní volání metody PrintTree na levém potomkovi s parametrem 'isRight' nastaveným na false
                result += left.PrintTree(false, "", "");
            }
            return result;
        }

        // Soukromá metoda sloužící k rekurzivnímu výpisu obsahu stromu
        // Tato metoda používá stejnou metodu jako veřejná metoda 'PrintTree', ale navíc přijímá parametry -> 'isRight' pro určení, zda je uzel pravým potomkem, 'indent' pro odsazení a 'result' pro konečný výpis výsledného řetězce
        private string PrintTree(bool isRight, string indent, string result)
        {
            if (right != null)
            {
                result = right.PrintTree(true, indent + (isRight ? "        " : " |      "), result);
            }
            result += indent;
            if (isRight)
            {
                result += " /";
            }
            else
            {
                result += " \\";
            }
            result += "----- " + value.ToString() + "\n";
            if (left != null)
            {
                result = left.PrintTree(false, indent + (isRight ? " |      " : "        "), result);
            }
            return result;
        }


        // Metoda sloužící pro nastavení levého potomka uzlu, pokud není již nastavený
        public void SetLeft(Node node)
        {
            if (left == null)
            {
                left = node;
            }
        }

        // Metoda sloužící pro nastavení pravého potomka uzlu, pokud není již nastavený
        public void SetRight(Node node)
        {
            if (right == null)
            {
                right = node;
            }
        }

        // Metoda pro získání levého potomka uzlu
        public Node GetLeft()
        {
            return left;
        }

        // Metoda pro získání pravého potomka uzlu
        public Node GetRight()
        {
            return right;
        }

        // Metoda pro získání hodnoty uzlu
        public int GetValue()
        {
            return value;
        }

        // Metoda pro nastavení hodnoty uzlu
        public void SetValue(int value)
        {
            this.value = value;
        }
    }

}
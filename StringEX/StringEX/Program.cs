using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dalinda = "Dalinda Mi alma" +
                " te llama Ven en mi" +
                " cama Quiero amarte " +
                "Dulce nina Dame tus besos Mirame" +
                " a los ojos Jurame tu amor Every " +
                "night in my mind I feel the perfume" +
                " of your skin Baby I won't deny You're" +
                " the lady of my dreams Nina dame tus besos" +
                " Quero tenerte en mis brazos Toda la noche" +
                " en mi cama Mi amor Mi amor";
            string DalindaChange = ChangeTextCase(Dalinda, 1);
            Console.WriteLine(DalindaChange);
            Console.WriteLine();
            DalindaChange = ChangeTextCase(Dalinda, 0);
            Console.WriteLine(DalindaChange);
            int counter = CountSubString(DalindaChange, "mi");
            Console.WriteLine();
            Console.WriteLine(counter);
            string newText = "";
            Replacer(DalindaChange, 'm', '$', out newText);
            Console.WriteLine(newText);
        }

        static string ChangeTextCase(string text, int cue)
        {
            string NewText = null;
            if (cue == 1)
            {
                NewText = text.ToUpper();
            }
            else if (cue == 0)
            {
                NewText = text.ToLower();
            }
            return NewText;
        }

        static int CountSubString(string text, string substring)
        {
            int counter = 0;
            int length = substring.Length;
            for (int i = 0; i < (text.Length - (length - 1)); i++)
            {
                if (i > 0 && i < (text.Length - length - 1))
                {
                    if (text.Substring(i, length + 2) == (" " + substring + " "))
                    {
                        counter++;
                    }
                }
                else if (i == 0)
                {
                    if (text.Substring(i, length + 1) == (substring + " "))
                    {
                        counter++;
                    }
                }
                else if (i == (text.Length - length - 1))
                {
                    if (text.Substring(i, length + 1) == " " + substring)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static void Replacer(string text, char chr1, char chr2, out string newText)
        {
            newText = "";
            for (int i = 0; i <text.Length;i++)
            {
                if(text[i]!=chr1)
                {
                    newText += text.Substring(i, 1);
                }
                else if(text[i]==chr1)
                {
                    newText += chr2;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //both string /String can be used
            String str = "Developer";
            Console.WriteLine(str);//Developer
            String up = str.ToUpper();
            Console.WriteLine("Upper: "+up);//DEVELOPER
            string lower=str.ToLower();
            Console.WriteLine("Lower: "+lower);//developer

            string substr = str.Substring(4);
            Console.WriteLine("Substring at 4:" + substr);//loper
            string substr2 = str.Substring(4,3);
            Console.WriteLine("Substring at 4,3 length:" + substr2);//lop

            string repl = str.Replace("e", "a");
            Console.WriteLine("Replaced:" + repl);//Davalopar

            string msg = "how are you";
            string[] words = msg.Split(' ');
            Console.WriteLine("\nSplit:");
            foreach(string  w in words)
            {
                Console.WriteLine(w);//how,are,you
            }

            string message = " hello ";
            string trim=message.Trim();
            Console.WriteLine("Trim:"+trim);//hello

            char[] ch = str.ToCharArray();
            Console.WriteLine("Characters:");
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }

            string[] mywords = new string[] { "how", "are", "you" };
            string strjn = string.Join("--", mywords);
            Console.WriteLine("Join:" + strjn);

            char[] char2 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string strnew = new string(char2);
            Console.WriteLine("New string:" + strnew);
            Console.ReadKey();

        }
    }
}

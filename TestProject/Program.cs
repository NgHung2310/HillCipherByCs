using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myStr = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"," ","~","`","!","@","#","$","%","^","&","*","(",")","-","_","+","=","|","\\","\"","\n","\t","{","[","]","}",":",";","'","<",",",".",">","?","/","0","1","2","3","4","5","6","7","8","9"};
            Console.WriteLine(myStr.Length);
            Console.ReadKey();
        }
    }
}

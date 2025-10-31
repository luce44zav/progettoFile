using GestioneFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il path");
            string path = Console.ReadLine();
            //commento di prova
            Writer w = new Writer(path);

            w.ScriviFile();

            Console.WriteLine("Operazione completata");
        }
    }
}

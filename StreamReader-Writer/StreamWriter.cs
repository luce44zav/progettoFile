using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Writer
    {
        private string filePath;
        
        public Writer(string path)
        {
            filePath = path;
        }

        public void ScriviFile()
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Prima riga");
                    writer.WriteLine("Seconda riga");
                    writer.WriteLine("Terza riga");
                }
                Console.WriteLine("File scritto con successo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore nella scrittura nel file" + ex.Message);
            }
        }
    }
}
using System;
using System.IO;
using System.Xml.Linq;

namespace csvToxml
{
    class ToXML
    {
        static void Main(string[] args)
        {
            // file1 in path1 is csv
            Console.Write("Podaj ścieżkę dla pobranego pliku csv: ");
            var path1 = Console.ReadLine();
            Console.Write("Podaj ścieżkę do zapisu xml: ");
            var path2 = Console.ReadLine();
            if (File.Exists(path1))
            {
                var file1 = File.ReadAllLines(path1);
                var xml = new XElement("TopElement",
                file1.Select(line => new XElement("Item",
                line.Split(';').Select((column, index) => new XElement("Column" + index, column)))));
                if (path2 != null)
                {
                    xml.Save(path2+ "\\xmlout.xml");
                    Console.WriteLine("Zapisano plik w ścieżce do zapisu xml");
                }
                else
                {
                    Console.WriteLine("Nie podano ścieżki do zapisu pliku xml!");
                }
            }
            else
            {
                Console.WriteLine("Brak pliku csv!");
            }
        }
    }
}
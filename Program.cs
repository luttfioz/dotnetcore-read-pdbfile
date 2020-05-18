using System;
using System.Collections.Generic;
using myapp.Models;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
        }

        static void ReadFile()
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            var file = System.IO.File.ReadAllLines(@"C:\temp\6g94.pdb");
            //var file = System.IO.File.ReadAllLines(@"/Users/users/Downloads/6g94.pdb");
            List<string> lines = new List<string>(file);
            List<Atom> atomList = new List<Atom>();
            Atom atom;
            Console.WriteLine("Toplam Satır Sayısı: " + lines.Count);

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                var row = line.Split(" ");
                var firstColumnNameInRow = row[0];
                // Use a tab to indent each line of the file.
                if (firstColumnNameInRow.Equals("ATOM"))
                {
                    List<string> rowList = new List<string>(row);
                    rowList.RemoveAll(item => item == "");

                    atom = new Atom();
                    atom.AtomNumarasi = Int32.Parse(rowList[1]);
                    atom.AtomAdi = rowList[2];
                    atom.XKoordinati = float.Parse(rowList[6]);

                    atomList.Add(atom);
                }
            }

            Console.WriteLine("Protein Adı : " + "6g94");
            Console.WriteLine("Proteindeki Toplam Atom Sayısı : " + atomList.Count);
            Console.WriteLine("X Koordinati En Büyük Atom : " + FindMax(atomList).toString());
            Console.WriteLine("Son Atom : " + atomList[0].toString());
        }

        private static Atom FindMax(List<Atom> list)
        {
            Atom returnValue = null;
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            float max = int.MinValue;
            foreach (Atom item in list)
            {
                if (item.XKoordinati > max)
                {
                    max = item.XKoordinati;
                    returnValue = item;
                }
            }
            return returnValue;
        }

    }
}

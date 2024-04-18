using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EredmenyCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            EredmenyRepository.Path = "eredmenyek.txt";

            Eredmeny eredmenyindex = EredmenyRepository.FindById(21);
            Console.WriteLine(eredmenyindex);
            Console.WriteLine();

            eredmenyindex.Targy = "történelem";
            // ha Id != null, akkor meglévő rekord frissítése
            EredmenyRepository.Save(eredmenyindex);

            // új elem esetén nem állítunk be Id-t (marad null)
            Eredmeny ujEredmeny = new Eredmeny()
            {
                Vezeteknev = "Test",
                Keresztnev = "Test",
                Targy = "Test",
                Szazalek = 86,
            };

        }
    }
}

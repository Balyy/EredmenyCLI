using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EredmenyCLI
{
    class EredmenyRepository
    {
        public static string Path { get; set; }
        public static bool SkipHeader { get; set; } = true;
        public static char Separator { get; set; } = ',';

        public static List<Eredmeny> FindAll()
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                if (SkipHeader)
                {
                    reader.ReadLine();
                }

                List<Eredmeny> eredmeny = new List<Eredmeny>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Eredmeny eredmenyline = Eredmeny.CreateFromLine(line, Separator);
                    eredmeny.Add(eredmenyline);
                }

                return eredmeny;
            }
        }

        public static Eredmeny FindById(int id)
        {
            foreach (Eredmeny eredmeny in FindAll())
            {
                if (eredmeny.Id == id)
                {
                    return eredmeny;
                }                                          
                
            }
            return null;

        }

        public static void Save(Eredmeny eredmeny)
        {
            List<Eredmeny> eredmenyek = FindAll();

            if (eredmeny.Id == 0)
            {
                // új elem létrehozása

                int maxId = 0;

                for (int i = 0; i < eredmenyek.Count; i++)
                {
                    if (eredmenyek[i].Id > maxId)
                    {

                    }
                }
            }
            else
            {
                // meglévő frissítése

                for (int i = 0; i < eredmenyek.Count; i++)
                {
                    if (eredmenyek[i].Id == eredmeny.Id)
                    {
                        eredmenyek[i] = eredmeny;
                        break;
                    }
                }
            }
        }
    }
}

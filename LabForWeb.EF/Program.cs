using LabForWeb.EF.Models;

namespace LabForWeb.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dc = new CsharpEfContext();

            var c = new Categorie();
            c.Nome = "Sport";
            c.Descrizione = "Articoli per lo sport";

            dc.Categories.Add(c);
            

            dc.SaveChanges();
        }
    }
}


using AdventureWorks;
using LabForWeb.EF.Models;

namespace LabForWeb.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dc = new CsharpEfContext();                

            if (dc.Categories.Count() == 0)
            {
                var c = new Categorie();
                c.Id = 1;
                c.Nome = "Abbigliamento";

                dc.Categories.Add(c);

                var u = new Utenti();
                u.Nome = "Marilyn Monroe";
                u.Attivo = true;

                dc.Utentis.Add(u);

                dc.SaveChanges();
            }

            using var dcAW = new AdventureWorksLt2019Context();

            foreach (var cat in dcAW.ProductCategories)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}


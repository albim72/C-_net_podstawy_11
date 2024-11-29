using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gardenSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectString = ConfigurationManager.
                ConnectionStrings["gardenSQL.Properties.Settings.GARDENConnectionString"].ToString();
            gardenDataContext  db = new gardenDataContext(connectString);

            Produkty nowyProdukt = new Produkty();
            nowyProdukt.IDProduktu = 3245;
            nowyProdukt.NazwaProduktu = "Mysło AX3";
            nowyProdukt.CenaJednostkowa = 17;

            db.Produkty.InsertOnSubmit(nowyProdukt);
            db.SubmitChanges();

            Produkty wybProdukt = db.Produkty.FirstOrDefault(d => d.IDProduktu.Equals("3245"));
            Console.WriteLine($"Produkt: ID = {wybProdukt.IDProduktu}, " +
                $"nazwa produktu: {wybProdukt.NazwaProduktu}," +
                $"Cena jednostowa: {wybProdukt.CenaJednostkowa} ");

            Console.ReadKey();
        }
    }
}

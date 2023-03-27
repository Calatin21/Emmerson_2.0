namespace Emmerson_2._0
{
    internal class ArtikelAngebot
    {
        List<AnbieterArtikelListe> anbieterArtikelListen = new List<AnbieterArtikelListe>();
        public void AddanbieterArtikelListe(AnbieterArtikelListe aaListe)
        {
            anbieterArtikelListen.Add(aaListe);
        }
        public void RemoveanbieterArtikelListe(AnbieterArtikelListe aaListe)
        {
            anbieterArtikelListen.Remove(aaListe);
        }
        public void PrintAnbieterArtikelListe(Anbieter anbieter)
        {
            foreach (AnbieterArtikelListe item in anbieterArtikelListen)
            {
                if (item.GetAnbieter() == anbieter)
                {
                    item.PrintArtikels();
                    break;
                }
            }
        }
        public Anbieter SucheAnbieter(int nummer)
        {
            Anbieter ergebnis = null;
            foreach (AnbieterArtikelListe item in anbieterArtikelListen)
            {
                if (item.GetAnbieter().GetAnbieternummer() == nummer)
                {
                    ergebnis = item.GetAnbieter();
                    break;
                }
            }
            return ergebnis;
        }

    }
}

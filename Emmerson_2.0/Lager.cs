namespace Emmerson_2._0 {
    internal class Lager {
        List<Artikel> lager = new List<Artikel>();
        public void AddArtikel(Artikel artikel) {
            lager.Add(artikel);
        }
        public void RemoveArtikel(Artikel artikel) {
            lager.Remove(artikel);
        }
        public void PrintAll() {
            foreach (Artikel item in lager) {
                Console.WriteLine("Artikelnummer: " + item.GetArtikelnummer() + "\nBezeichnung: " + item.GetBezeichnung());
                Console.WriteLine("");
            }
        }
        public Artikel ArtikelAuswaehlen(int anummer) {
                Artikel ergebnis = null;
            foreach (Artikel item in lager) {
                if (item.GetArtikelnummer() == anummer) {
                    item.PrintArtikel();
                    ergebnis = item;
                }         
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            return ergebnis;
        }
        public Artikel ArtikelSuchen(int artikelnummer) {
            Artikel ergebnis = null;
            foreach (Artikel item in lager) {
                if (item.GetArtikelnummer() == artikelnummer) {
                    ergebnis = item;
                    break;
                }
            }
            return ergebnis;
        }
        public void ArtikelSuchen(String wort) {
            int treffernummer = 1;
            foreach (Artikel item in lager) {
                if (item.GetBezeichnung().Contains(wort) || item.GetBeschreibung().Contains(wort)) {
                    Console.WriteLine("Treffer "+treffernummer+":");
                    item.PrintArtikel();
                    Console.WriteLine("");
                    treffernummer++;
                }
            }
        }

    }
}

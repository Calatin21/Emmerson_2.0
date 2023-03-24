namespace Emmerson_2._0 {
    internal class Artikel {
        int artikelnummer;
        int eAN;
        String bezeichnung;
        String beschreibung;
        String kategorie;
        Double preis;
        int abgabeeinheit;
        Double versandkosten;
        Double mehrwertsteuersatz;
        public Artikel(int artikelnummer, String bezeichnung, String beschreibung,String Kategorie, Double preis, int abgabeeinheit, Double versandkosten, Double mehrwertsteuersatz) {
            this.artikelnummer = artikelnummer;
            this.eAN = artikelnummer;
            this.bezeichnung = bezeichnung;
            this.beschreibung = beschreibung;
            this.kategorie = Kategorie;
            this.preis = preis;
            this.abgabeeinheit = abgabeeinheit;
            this.versandkosten = versandkosten;
            this.mehrwertsteuersatz = mehrwertsteuersatz;
        }
        public void SetArtikelnummer(int nummer) {
            artikelnummer = nummer;
        }
        public int GetArtikelnummer() {
            return artikelnummer;
        }
        public void SetEAN(int nummer) {
            eAN = nummer;
        }
        public int GetEAN() {
            return eAN;
        }
        public void SetBezeichnung(String bz) {
            bezeichnung = bz;
        }
        public String GetBezeichnung() {
            return bezeichnung;
        }
        public void SetBeschreibung(String bs) {
            beschreibung = bs;
        }
        public String GetBeschreibung() {
            return beschreibung;
        }
        public void SetKategorie(String kat) {
            kategorie = kat;
        }
        public String GetKategorie() {
            return kategorie;
        }
        public void SetPreis(Double preis) {
            this.preis = preis;
        }
        public Double GetPreis() {
            return preis;
        }
        public void SetAbgabeeinheit(int ae) {
            abgabeeinheit = ae;
        }
        public int GetAbgabeeinheit() {
            return abgabeeinheit;
        }
        public void SetVersandkosten(Double vk) {
            versandkosten = vk;
        }
        public double GetVersandkosten() {
            return versandkosten;
        }
        public void SetMerhwertsteuersatz(Double satz) {
            mehrwertsteuersatz = satz;
        }
        public Double getMehrwertsteuersatz() {
            return mehrwertsteuersatz;
        }
        public void PrintArtikel() {
            Console.WriteLine("\t\tArtikelnummer: " + this.GetArtikelnummer() + " Bezeichnung: " + this.GetBezeichnung());
            Console.WriteLine("\t\tBeschreibung: " + this.GetBeschreibung());
            Console.WriteLine("\t\tKategorie: " + this.GetKategorie() + " Preis: " + this.GetPreis() + " Abgabeeinheit: " + this.GetAbgabeeinheit() + " Mehrwert Steuersatz: " + this.getMehrwertsteuersatz() + " Versandkosten: " + this.GetVersandkosten());
        }
    }
}

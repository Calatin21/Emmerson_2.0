namespace Emmerson_2._0 {
    internal class Rechnung {
        int rechnungsnummer;
        int kundennummer;
        DateTime rechnungsdatum;
        Warenkorb warenkorb;
        Double rechnungssumme;
        public Rechnung(int rechnungsnummer, int kundennummer, DateTime rechunugsdatum, Warenkorb warenkorb) {
            this.rechnungsnummer = rechnungsnummer;
            this.kundennummer   = kundennummer;
            this.rechnungsdatum = rechunugsdatum;
            this.warenkorb = warenkorb;
            this.SetRechnugssumme();
            this.rechnungssumme = this.GetRechnugssumme();
        }
        public void SetRechnungsnummer(int nummer) {
            rechnungsnummer = nummer;
        }
        public int GetRechnungsnummer() {
            return rechnungsnummer;
        }
        public void SetKundennummer(int nummer) {
            kundennummer = nummer;
        }
        public int GetKundennummer() {
            return kundennummer;
        }
        public void SetRechnungsdatum(DateTime datum) {
            rechnungsdatum = datum;
        }
        public DateTime GetRechnugsdatum() {
            return rechnungsdatum;
        }
        public void SetWarenkorb(Warenkorb wk) {
            warenkorb = wk;
        }
        public Warenkorb GetWarenkorb() {
            return warenkorb;
        }
        public void SetRechnugssumme() {
            double ergebnis = 0;
            foreach(BestellPosition item in warenkorb.GetWarenkorb()) {
                ergebnis += item.GetMenge() * item.GetArtikel().GetPreis();
                ergebnis += item.GetMenge() * item.GetArtikel().GetVersandkosten();
            }
            rechnungssumme = ergebnis;
        }
        public Double GetRechnugssumme() {
            return rechnungssumme;
        }
        public void Printrechnug() {
            Console.WriteLine($"Rechnungsnummer: {this.rechnungsnummer}\t\t\t\t{this.rechnungsdatum}\nKundennummer: {this.kundennummer}");
            this.warenkorb.PrintWarenkorb();
            Console.WriteLine($"Gesamtsumme mit versand ist: {this.rechnungssumme}");
            Console.WriteLine("");
        }
    }
}

namespace Emmerson_2._0 {
    internal class BestellPosition {
        //int positionsnummer;
        Artikel artikel;
        int menge;
        Double positionsprodukt;
        public BestellPosition(Artikel artikel, int menge) {
            //positionsnummer= ;
            this.artikel = artikel;
            this.menge = menge;
            positionsprodukt = menge * artikel.GetPreis();
        }
        public void SetArtikel(Artikel artikel) {
            this.artikel = artikel;
        }
        public Artikel GetArtikel() {
            return artikel;
        }
        public void SetMenge(int zahl) {
            menge = zahl;
            positionsprodukt = zahl * this.artikel.GetPreis();
        }
        public int GetMenge() {
            return menge;
        }
        public void SetPositionsprodukt(Double produkt) {
            positionsprodukt = produkt;
        }
        public Double GetPositionsprodukt() {
            return positionsprodukt;
        }
    }
}

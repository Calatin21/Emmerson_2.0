namespace Emmerson_2._0 {
    internal class Warenkorb {
        int id;
        List<BestellPosition> bestellpositionen = new();
        Double positionssumme;
        public void SetId(int nummer) {
            id = nummer;
        }
        public int GetId() {
            return id;
        }
        public void ChangeBestellPositionsMenge(Artikel artikel, int menge) {
            foreach (BestellPosition item in bestellpositionen) {
                if (item.GetArtikel() == artikel) {
                    item.SetMenge(menge);
                    break;
                }
            }
        }
        public void Addbestellposition(Artikel artikel, int menge) {
            bestellpositionen.Add(new BestellPosition(artikel, menge));
        }
        public void RemoveBestellPosition(Artikel artikel) {
            foreach (BestellPosition item in bestellpositionen) {
                if (item.GetArtikel() == artikel) {
                    bestellpositionen.Remove(item);
                    break;
                }
            }
        }
        public void SetPositionssumme(Double summe) {
            positionssumme = summe;
        }
        public Double GetPositionssumme() {
            return positionssumme;
        }
        public List<BestellPosition> GetBestellPositions() {
            return bestellpositionen;
        }
        public void PrintWarenkorb() {

            foreach (BestellPosition item in bestellpositionen) {

                item.GetArtikel().PrintArtikel();
            }
        }
        public List<BestellPosition> GetWarenkorb() {
            return bestellpositionen;
        }
    }
}

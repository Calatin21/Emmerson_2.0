namespace Emmerson_2._0 {
    internal class KundenKartei {
        List<Kunde> kundenkartei = new List<Kunde>();
        public void AddKunde(Kunde kunde) {
            kundenkartei.Add(kunde);
        }
        public void RemoveKunde(Kunde kunde) {
            kundenkartei.Remove(kunde);
        }
        public Kunde SearchKunde(Kunde kunde) {
            Kunde ergebnis = null;
            foreach (Kunde item in kundenkartei) {
                if (item == kunde) {
                    ergebnis = item;
                    break;
                }
            }
            return ergebnis;
        }
        public void PrintKunden() {
            int knummer = 1;
            foreach (Kunde item in kundenkartei) {
                Console.WriteLine($"Kunde {knummer}:");
                item.PrintKunde();
                knummer++;
            }
        }
        public List<Kunde> GetKartei() {
            return kundenkartei;
        
        }
    }
}

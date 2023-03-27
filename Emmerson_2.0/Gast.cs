using System.Reflection.Emit;

namespace Emmerson_2._0 {
    internal class Gast {
        int id;
        Warenkorb warenkorb;
        public Gast() {
            id = 0;
            warenkorb = new Warenkorb();
        }
        public void SetId(int nummer) {
            id = nummer;
        }
        public int GetId() {
            return id;
        }
        public void SetWarenkorb(Warenkorb warenkorb) {
            this.warenkorb = warenkorb;
        }
        public Warenkorb GetWarenkorb() {
            return this.warenkorb;
        }
        public void PostenHinzufuegen(Artikel artikel, int menge) {
            this.warenkorb.Addbestellposition(artikel, menge);
        }
        public void PostenEntfernen(Artikel artikel) {
            warenkorb.RemoveBestellPosition(artikel);
        }
        public void AnzahlFestlegen(Artikel artikel, int menge) {
            warenkorb.ChangeBestellPositionsMenge(artikel, menge);
        }
        public Artikel ArtikelAuswaehlen(Lager lager, int anummer) {
            Console.WriteLine("Sie haben folgenden Artikel ausgesucht:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            return lager.ArtikelAuswaehlen(anummer);
        }
        public void ArtikelSuchen(Lager lager, String wort) {
            Console.WriteLine("Artikel Suche hat folgende Treffer ergeben:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            lager.ArtikelSuchen(wort);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
        public void AnbieterSuche(ArtikelAngebot aa,int nummer)
        {
            Console.WriteLine("Anbieter Suche hat folgende Treffer ergeben:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            aa.PrintAnbieterArtikelListe(aa.SucheAnbieter(nummer));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
        public Kunde Login(KundenKartei kartei) {
            Kunde ergebnis = null;
            if (kartei.GetKartei().Count() > 0) {
                int versuch = 3;
                String loginname, passwort;
                Console.Write("Login Namen eingeben: ");
                loginname = Console.ReadLine();
                Console.Write("Passwort eingeben: ");
                passwort = Console.ReadLine();
                foreach (Kunde item in kartei.GetKartei()) {
                    if (item.GetLoginname() == loginname) {
                        while (versuch != 0) {
                            if (item.GetPasswort() == passwort) {
                                ergebnis = item;
                                break;
                            }
                            else {
                                Console.Write($"Das Passwort ist falsch! sie haben noch {versuch} Versuche.\t Bitte neu Eingeben: ");
                                passwort = Console.ReadLine();
                                versuch--;
                            }
                        }
                    }
                }
            }
            else {
                Console.WriteLine("Es gibt noch keine Kunden, sorry.");
                Console.ReadLine();
            }
            return ergebnis;
        }
        public void zurKasse(KundenKartei kartei, String art) {
            if (art == "gast") {
                Console.WriteLine("Sie müssen sich vorher registrieren!");                
            }
            else if (art == "kunde") {
                if (((Kunde)this).warenkorb.GetWarenkorb().Count == 0) {
                    Console.WriteLine("Ihr Warenkorb ist leer!");
                    Console.ReadLine();
                }
                else {
                    int rnummer = 0;
                    DateTime datum = DateTime.Now;
                    rnummer = ((Kunde)this).GetRechnungen().Count() + 1;
                    Rechnung rechnung = new(rnummer, this.GetId(), datum, this.GetWarenkorb());
                    ((Kunde)this).AddRechnung(rechnung);
                    ((Kunde)this).SetWarenkorb(new Warenkorb());
                    ((Kunde)this).PrintRechnungen();
                }
            }
        }
        public void WarenkorbAnzeigen() {
            int positionsnummer = 1;
            double produkt = 0;
            double summe = 0;
            Console.WriteLine("Ihr Warenkorb enthält folgende Artikel");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (BestellPosition item in warenkorb.GetBestellPositions()) {
                Console.WriteLine("Bestell Position " + positionsnummer + ":");
                item.GetArtikel().PrintArtikel();
                produkt = item.GetMenge() * item.GetArtikel().GetPreis();
                Console.WriteLine($"Menge: {item.GetMenge()}\tGesamtpreis: {produkt}");
                Console.WriteLine("");
                positionsnummer++;
                summe += produkt;
            }
            Console.WriteLine($"Gesamtsumme: {summe}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
        public void Registrieren(KundenKartei kartei) {
            String nachname, vorname, loginname, passwort;
            DateTime geburtstag;
            int kundennummer;
            Console.Write("Bitte geben Sie Ihren Nachname ein: ");
            nachname = Console.ReadLine();
            Console.Write("Bitte geben Sie Ihren Vornamen ein: ");
            vorname = Console.ReadLine();
            Console.Write("Bitte geben Sie Ihren Geburtstag ein: ");
            geburtstag = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Bitte geben Sie Ihren Login Namen ein: ");
            loginname = Console.ReadLine();
            Console.Write("Bitte geben Sie Ihr Passwort ein: ");
            passwort = Console.ReadLine();
            kundennummer = kartei.GetKartei().Count() + 1;
            kartei.AddKunde(new(this.warenkorb, kundennummer, nachname, vorname, geburtstag, loginname, passwort));
        }
    }
}
